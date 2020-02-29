namespace Project_JAPA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startJAPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usingJAPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuringJAPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troubleshootingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logUserInteractionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLogDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.viewLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableChatBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silentModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAutomaticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWhenMinimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInput = new System.Windows.Forms.TextBox();
            this.lbl_command = new System.Windows.Forms.Label();
            this.tb_console = new System.Windows.Forms.RichTextBox();
            this.btn_submitCommand = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.gitHubRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knownIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contributingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startJAPAToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // startJAPAToolStripMenuItem
            // 
            resources.ApplyResources(this.startJAPAToolStripMenuItem, "startJAPAToolStripMenuItem");
            this.startJAPAToolStripMenuItem.Name = "startJAPAToolStripMenuItem";
            this.startJAPAToolStripMenuItem.Click += new System.EventHandler(this.startJAPAToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usingJAPAToolStripMenuItem,
            this.configuringJAPAToolStripMenuItem,
            this.troubleshootingToolStripMenuItem,
            this.toolStripSeparator5,
            this.contributingToolStripMenuItem,
            this.knownIssuesToolStripMenuItem,
            this.gitHubRepositoryToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // usingJAPAToolStripMenuItem
            // 
            resources.ApplyResources(this.usingJAPAToolStripMenuItem, "usingJAPAToolStripMenuItem");
            this.usingJAPAToolStripMenuItem.Name = "usingJAPAToolStripMenuItem";
            // 
            // configuringJAPAToolStripMenuItem
            // 
            resources.ApplyResources(this.configuringJAPAToolStripMenuItem, "configuringJAPAToolStripMenuItem");
            this.configuringJAPAToolStripMenuItem.Name = "configuringJAPAToolStripMenuItem";
            // 
            // troubleshootingToolStripMenuItem
            // 
            resources.ApplyResources(this.troubleshootingToolStripMenuItem, "troubleshootingToolStripMenuItem");
            this.troubleshootingToolStripMenuItem.Name = "troubleshootingToolStripMenuItem";
            // 
            // viewToolStripMenuItem
            // 
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem,
            this.logToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            // 
            // commandsToolStripMenuItem
            // 
            resources.ApplyResources(this.commandsToolStripMenuItem, "commandsToolStripMenuItem");
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            // 
            // logToolStripMenuItem
            // 
            resources.ApplyResources(this.logToolStripMenuItem, "logToolStripMenuItem");
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logUserInteractionsToolStripMenuItem,
            this.setLogDirectoryToolStripMenuItem,
            this.toolStripSeparator4,
            this.viewLogsToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            // 
            // logUserInteractionsToolStripMenuItem
            // 
            resources.ApplyResources(this.logUserInteractionsToolStripMenuItem, "logUserInteractionsToolStripMenuItem");
            this.logUserInteractionsToolStripMenuItem.Name = "logUserInteractionsToolStripMenuItem";
            this.logUserInteractionsToolStripMenuItem.Click += new System.EventHandler(this.logUserInteractionsToolStripMenuItem_Click);
            // 
            // setLogDirectoryToolStripMenuItem
            // 
            resources.ApplyResources(this.setLogDirectoryToolStripMenuItem, "setLogDirectoryToolStripMenuItem");
            this.setLogDirectoryToolStripMenuItem.Name = "setLogDirectoryToolStripMenuItem";
            this.setLogDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setLogDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // viewLogsToolStripMenuItem
            // 
            resources.ApplyResources(this.viewLogsToolStripMenuItem, "viewLogsToolStripMenuItem");
            this.viewLogsToolStripMenuItem.Name = "viewLogsToolStripMenuItem";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableChatBotToolStripMenuItem,
            this.textModeToolStripMenuItem,
            this.silentModeToolStripMenuItem,
            this.startAutomaticallyToolStripMenuItem,
            this.hideWhenMinimizedToolStripMenuItem,
            this.toolStripSeparator2,
            this.resetCommandsToolStripMenuItem,
            this.modifyCommandsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // disableChatBotToolStripMenuItem
            // 
            resources.ApplyResources(this.disableChatBotToolStripMenuItem, "disableChatBotToolStripMenuItem");
            this.disableChatBotToolStripMenuItem.Name = "disableChatBotToolStripMenuItem";
            this.disableChatBotToolStripMenuItem.Click += new System.EventHandler(this.disableChatBotToolStripMenuItem_Click);
            // 
            // textModeToolStripMenuItem
            // 
            resources.ApplyResources(this.textModeToolStripMenuItem, "textModeToolStripMenuItem");
            this.textModeToolStripMenuItem.Name = "textModeToolStripMenuItem";
            this.textModeToolStripMenuItem.Click += new System.EventHandler(this.textModeToolStripMenuItem_Click);
            // 
            // silentModeToolStripMenuItem
            // 
            resources.ApplyResources(this.silentModeToolStripMenuItem, "silentModeToolStripMenuItem");
            this.silentModeToolStripMenuItem.Name = "silentModeToolStripMenuItem";
            this.silentModeToolStripMenuItem.Click += new System.EventHandler(this.silentModeToolStripMenuItem_Click);
            // 
            // startAutomaticallyToolStripMenuItem
            // 
            resources.ApplyResources(this.startAutomaticallyToolStripMenuItem, "startAutomaticallyToolStripMenuItem");
            this.startAutomaticallyToolStripMenuItem.Name = "startAutomaticallyToolStripMenuItem";
            this.startAutomaticallyToolStripMenuItem.Click += new System.EventHandler(this.startAutomaticallyToolStripMenuItem_Click);
            // 
            // hideWhenMinimizedToolStripMenuItem
            // 
            resources.ApplyResources(this.hideWhenMinimizedToolStripMenuItem, "hideWhenMinimizedToolStripMenuItem");
            this.hideWhenMinimizedToolStripMenuItem.Name = "hideWhenMinimizedToolStripMenuItem";
            this.hideWhenMinimizedToolStripMenuItem.Click += new System.EventHandler(this.hideWhenMinimizedToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // resetCommandsToolStripMenuItem
            // 
            resources.ApplyResources(this.resetCommandsToolStripMenuItem, "resetCommandsToolStripMenuItem");
            this.resetCommandsToolStripMenuItem.Name = "resetCommandsToolStripMenuItem";
            this.resetCommandsToolStripMenuItem.Click += new System.EventHandler(this.resetConfigurationToolStripMenuItem_Click);
            // 
            // modifyCommandsToolStripMenuItem
            // 
            resources.ApplyResources(this.modifyCommandsToolStripMenuItem, "modifyCommandsToolStripMenuItem");
            this.modifyCommandsToolStripMenuItem.Name = "modifyCommandsToolStripMenuItem";
            // 
            // userInput
            // 
            resources.ApplyResources(this.userInput, "userInput");
            this.userInput.Name = "userInput";
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // lbl_command
            // 
            resources.ApplyResources(this.lbl_command, "lbl_command");
            this.lbl_command.Name = "lbl_command";
            // 
            // tb_console
            // 
            resources.ApplyResources(this.tb_console, "tb_console");
            this.tb_console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_console.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_console.Name = "tb_console";
            this.tb_console.ReadOnly = true;
            this.tb_console.ShortcutsEnabled = false;
            this.tb_console.TabStop = false;
            this.tb_console.TextChanged += new System.EventHandler(this.tb_console_TextChanged);
            // 
            // btn_submitCommand
            // 
            resources.ApplyResources(this.btn_submitCommand, "btn_submitCommand");
            this.btn_submitCommand.Name = "btn_submitCommand";
            this.btn_submitCommand.UseVisualStyleBackColor = true;
            this.btn_submitCommand.Click += new System.EventHandler(this.btn_submitCommand_Click);
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // gitHubRepositoryToolStripMenuItem
            // 
            resources.ApplyResources(this.gitHubRepositoryToolStripMenuItem, "gitHubRepositoryToolStripMenuItem");
            this.gitHubRepositoryToolStripMenuItem.Name = "gitHubRepositoryToolStripMenuItem";
            this.gitHubRepositoryToolStripMenuItem.Click += new System.EventHandler(this.gitHubRepositoryToolStripMenuItem_Click);
            // 
            // knownIssuesToolStripMenuItem
            // 
            resources.ApplyResources(this.knownIssuesToolStripMenuItem, "knownIssuesToolStripMenuItem");
            this.knownIssuesToolStripMenuItem.Name = "knownIssuesToolStripMenuItem";
            this.knownIssuesToolStripMenuItem.Click += new System.EventHandler(this.knownIssuesToolStripMenuItem_Click);
            // 
            // contributingToolStripMenuItem
            // 
            resources.ApplyResources(this.contributingToolStripMenuItem, "contributingToolStripMenuItem");
            this.contributingToolStripMenuItem.Name = "contributingToolStripMenuItem";
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_submitCommand;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_submitCommand);
            this.Controls.Add(this.tb_console);
            this.Controls.Add(this.lbl_command);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silentModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAutomaticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem modifyCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usingJAPAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuringJAPAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troubleshootingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startJAPAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideWhenMinimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logUserInteractionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setLogDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem viewLogsToolStripMenuItem;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label lbl_command;
        private System.Windows.Forms.RichTextBox tb_console;
        private System.Windows.Forms.Button btn_submitCommand;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem disableChatBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem contributingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knownIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubRepositoryToolStripMenuItem;
    }
}

