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
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using FDL.Library.Numeric;

namespace Project_JAPA
{
	public partial class Form1 : Form
	{
		#region properties
		JSONSettings settings = new JSONSettings
		{
			textMode = false,
			silentMode = false,
			disableChatBot = false,
			startAutomatically = false,
			hideWhenMinimized = false,
			name = "user",
			companionSettings = new CompanionSettings { volume = 100, speed = 1, randomWaitToRespondMaxMs = 0 },
			logSettings = new LogSettings { logConversations = true, logDirectory = Directory.GetCurrentDirectory() }
		};

		public bool _JAPAenabled = false;
		public bool _JAPArunning = false;
		public bool _expectsResponse = false;

		public List<string> conversation = new List<string>();
		public static Logger logger = LogManager.GetCurrentClassLogger();

		Bot companion = new Bot();
		User user;

		SpeechRecognitionEngine recognitionEngine;
		SpeechSynthesizer synthesisEngine = new SpeechSynthesizer();
		#endregion

        public Form1()
		{
			InitializeComponent();
			this.AcceptButton = btn_submitCommand;
			companion.loadSettings();
			companion.loadAIMLFromFiles();
			companion.isAcceptingUserInput = false;

			if (File.Exists("settings.json"))
			{
				logger.Info("Loading settings...");
				settings = JsonConvert.DeserializeObject<JSONSettings>(File.ReadAllText(@"settings.json"));
				UpdateSettings();
				logger.Info("Settings loaded.");
			}
			else
			{
				logger.Info("Could not find settings file. Creating a new one.");
				UpdateSettings();
			}

			user = new User(settings.name, companion);

			synthesisEngine.Volume = 100;
			synthesisEngine.Rate = 1;
		}

		#region eventHandlers
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

			if (this.WindowState == FormWindowState.Minimized && cursorNotInBar && settings.hideWhenMinimized == true)
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
		private void resetConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			logger.Info("Reset settings to their default values.");
			File.Delete("settings.json");
			settings = new JSONSettings
			{
				textMode = false,
				silentMode = false,
				disableChatBot = false,
				startAutomatically = false,
				hideWhenMinimized = false,
				name = "user",
				companionSettings = new CompanionSettings { volume = 100, speed = 1, randomWaitToRespondMaxMs = 0 },
				logSettings = new LogSettings { logConversations = true, logDirectory = Directory.GetCurrentDirectory() }
			};
			UpdateSettings();
		}
		private void silentModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			settings.silentMode = !settings.silentMode;
			UpdateSettings();
			// TODO - Enable Silent Mode (Does Text based output instead of tts.)
		}

		private void textModeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			settings.textMode = !settings.textMode;
			UpdateSettings();
			// TODO - Enable Text mode (inputs text entered in the application as speech recognition and disables speech recognition)
		}
		private void startAutomaticallyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			settings.startAutomatically = !settings.startAutomatically;
			UpdateSettings();
			// TODO - Makes application start automatically as a service.
		}
		private void disableChatBotToolStripMenuItem_Click(object sender, EventArgs e)
		{
			settings.disableChatBot = !settings.disableChatBot;
			UpdateSettings();
		}
		private void hideWhenMinimizedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			settings.hideWhenMinimized = !settings.hideWhenMinimized;
			UpdateSettings();
		}
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void startJAPAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_JAPArunning == false)
			{
				startJAPAToolStripMenuItem.Text = "Stop JAPA";
				statusBar.Text = "Starting";
				logger.Info("Starting JAPA...");
				_JAPArunning = true;
				userInput.Enabled = true;

				companion.isAcceptingUserInput = true;
				logger.Info("Session started.");
				statusBar.Text = "Awaiting user input";
			}
			else
			{
				startJAPAToolStripMenuItem.Text = "Start JAPA";
				statusBar.Text = "Stopping";
				logger.Info("Stopping JAPA...");
				_JAPArunning = false;
				userInput.Enabled = false;

				companion.isAcceptingUserInput = false;
				logger.Info("Session ended.");
				statusBar.Text = "Stopped";
			}
			_JAPAenabled = !_JAPAenabled;
		}

		private void recognitionEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
		{

		}
		private void btn_submitCommand_Click(object sender, EventArgs e)
		{
			statusBar.Text = "Processing command";
			logger.Info("Sent Text - \"{0}\"", userInput.Text);
			System.Threading.Thread.Sleep(RandomNumber.Between(0, settings.companionSettings.randomWaitToRespondMaxMs));
			string returnValue = "";

			if (userInput.Text.ToLower().StartsWith("say"))
			{
				returnValue = userInput.Text.Substring(4, userInput.Text.Length-4);
			} 
			else if (userInput.Text.ToLower().StartsWith("clear screen"))
			{
				tb_console.Text = "";
				returnValue = "Cleared screen.";
			}
			else if (userInput.Text.ToLower().StartsWith("stop talking"))
			{
				synthesisEngine.SpeakAsyncCancelAll();
				returnValue = "Sounds good.";
			}
			else if (settings.disableChatBot == false)
			{
				Request r;
				Result res;

				r = new Request(userInput.Text.ToString(), user, companion);
				res = companion.Chat(r);
				returnValue = res.Output;
			}

			if (returnValue == "" || returnValue == null)
			{
				logger.Info("Could not generate a response.");

			}
			else
			{
				logger.Info("Response - \"{0}\"", returnValue.ToString());
			}
			userInput.Text = "";

			if (settings.silentMode == false)
			{
				synthesisEngine.SpeakAsync(returnValue);
			}
			statusBar.Text = "Awaiting user input";
		}
        #endregion
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
		void UpdateSettings()
		{
			silentModeToolStripMenuItem.Checked = settings.silentMode;
			startAutomaticallyToolStripMenuItem.Checked = settings.startAutomatically;
			textModeToolStripMenuItem.Checked = settings.textMode;
			hideWhenMinimizedToolStripMenuItem.Checked = settings.hideWhenMinimized;
			disableChatBotToolStripMenuItem.Checked = settings.disableChatBot;
			logUserInteractionsToolStripMenuItem.Checked = settings.logSettings.logConversations;
			System.IO.File.WriteAllText("settings.json", JsonConvert.SerializeObject(settings, Formatting.Indented));
		}

		private void logUserInteractionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			settings.logSettings.logConversations = !settings.logSettings.logConversations;
			UpdateSettings();
		}

		private void setLogDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog folderBrowser = new OpenFileDialog();
			// Set validate names and check file exists to false otherwise windows will
			// not let you select "Folder Selection."
			folderBrowser.Title = "Select a folder to house the logs";
			folderBrowser.InitialDirectory = settings.logSettings.logDirectory;
			folderBrowser.ValidateNames = false;
			folderBrowser.CheckFileExists = false;
			folderBrowser.CheckPathExists = true;
			// Always default to Folder Selection.
			folderBrowser.FileName = "Select a folder";

			if (folderBrowser.ShowDialog() == DialogResult.OK)
			{
				settings.logSettings.logDirectory = Path.GetDirectoryName(folderBrowser.FileName);
				UpdateSettings();
			}
		}
		void openBrowser(string target)
		{
			try
			{
				System.Diagnostics.Process.Start(target);
			}
			catch
				(
				 System.ComponentModel.Win32Exception noBrowser)
			{
				if (noBrowser.ErrorCode == -2147467259)
					MessageBox.Show(noBrowser.Message);
			}
			catch (System.Exception other)
			{
				MessageBox.Show(other.Message);
			}
		}

		private void knownIssuesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openBrowser("https://github.com/UndyingSoul/Project-JAPA/issues?q=is%3Aopen+is%3Aissue+label%3Abug");
		}

		private void gitHubRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openBrowser("https://github.com/UndyingSoul/Project-JAPA");
		}
	}
}
