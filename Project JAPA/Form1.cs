using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using NLog.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using AIMLbot;

namespace Project_JAPA
{
	public partial class Form1 : Form
	{
		#region properties
		public bool _JAPAenabled = false;
		public bool _JAPArunning = false;
		public bool _expectsResponse = false;
		public List<string> conversation = new List<string>();
		public static Logger logger = LogManager.GetCurrentClassLogger();
		Bot companion = new Bot();
		User user;
		SpeechRecognitionEngine recognitionEngine;
		#endregion

        public Form1()
		{
			InitializeComponent();
			this.AcceptButton = btn_submitCommand;
			companion.loadSettings();
			companion.loadAIMLFromFiles();
			companion.isAcceptingUserInput = false;
			user = new User(Environment.UserName, companion);
		}

		private void resetConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// TODO - need to do this.
		}

		private void silentModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			silentModeToolStripMenuItem.Checked = !silentModeToolStripMenuItem.Checked;
			// TODO - Enable Silent Mode (Does Text based output instead of tts.)
		}

		private void textModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textModeToolStripMenuItem.Checked = !textModeToolStripMenuItem.Checked;
			// TODO - Enable Text mode (inputs text entered in the application as speech recognition and disables speech recognition)
		}

		private void startAutomaticallyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			startAutomaticallyToolStripMenuItem.Checked = !startAutomaticallyToolStripMenuItem.Checked;
			// TODO - Makes application start automatically as a service.
		}


		private void startJAPAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_JAPAenabled == false)
			{
				startJAPAToolStripMenuItem.Text = "Stop JAPA";
				statusBar.Text = "Starting";
				logger.Info("Starting JAPA...");
				_JAPArunning = true;
				userInput.Enabled = true;
				companion.isAcceptingUserInput = true;
				logger.Info("Session started.");
			}
			else
			{
				startJAPAToolStripMenuItem.Text = "Start JAPA";
				statusBar.Text = "Stopping";
				logger.Info("Stopping JAPA...");
				_JAPArunning = false;
				userInput.Enabled = false;
				logger.Info("Session ended.");
			}
			_JAPAenabled = !_JAPAenabled;
		}

		private void userInput_TextChanged(object sender, EventArgs e)
		{
			if (userInput.Text != "" && userInput.Text != null && _JAPArunning == true)
			{
				btn_submitCommand.Enabled = true;
			}
			else
			{
				btn_submitCommand.Enabled = false;
			}
		}

		private void btn_submitCommand_Click(object sender, EventArgs e)
		{
			logger.Info("Sent Text - \"{0}\"", userInput.Text);
			Request r;
			Result res;
			string returnValue = "";

			r = new Request(userInput.Text, user, companion);
			res = companion.Chat(r);
			returnValue = res.Output;

			logger.Info("Response - \"{0}\"", returnValue.ToString());
			userInput.Text = "";
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void startSpeechRecognition()
		{
			recognitionEngine = new SpeechRecognitionEngine();

			Choices commands = new Choices();
			commands.Add(new string[] { "say hello", "print my name" });
			GrammarBuilder gbuilder = new GrammarBuilder();
			gbuilder.Append(commands);
			Grammar grammar = new Grammar(gbuilder);

			recognitionEngine.LoadGrammarAsync(grammar);
			recognitionEngine.SetInputToDefaultAudioDevice();
			recognitionEngine.SpeechRecognized += recognitionEngine_SpeechRecognized;
			_JAPAenabled = true;

			companion.isAcceptingUserInput = true;
		}

		private void recognitionEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{
			
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

			if(this.WindowState == FormWindowState.Minimized && cursorNotInBar)
			{
				this.ShowInTaskbar = false;
				notifyIcon.Visible = true;
				this.Hide();
				notifyIcon.ShowBalloonTip(500);

			}
		}

		private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			this.ShowInTaskbar = true;
			notifyIcon.Visible = false;
			this.Visible = true;
			this.Show();
		}

		private void tb_console_TextChanged(object sender, EventArgs e)
		{
			tb_console.SelectionStart = tb_console.TextLength;
			tb_console.ScrollToCaret();
		}
	}
}
