namespace All_tools_Form_Apps.MessageBoxs
{
    partial class Messages_showder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages_showder));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            conten = new Label();
            close = new Button();
            disable_forever = new Button();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork_1;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // conten
            // 
            resources.ApplyResources(conten, "conten");
            conten.Name = "conten";
            // 
            // close
            // 
            resources.ApplyResources(close, "close");
            close.Name = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // disable_forever
            // 
            resources.ApplyResources(disable_forever, "disable_forever");
            disable_forever.Name = "disable_forever";
            disable_forever.UseVisualStyleBackColor = true;
            disable_forever.Click += disable_forever_Click;
            // 
            // Messages_showder
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(disable_forever);
            Controls.Add(close);
            Controls.Add(conten);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Messages_showder";
            ShowInTaskbar = false;
            Load += Messages_showder_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label conten;
        private Button close;
        private Button disable_forever;
    }
}