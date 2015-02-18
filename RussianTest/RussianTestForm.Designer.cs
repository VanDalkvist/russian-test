namespace RussianTest
{
    partial class RussianTestForm
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.NewToolStripMenuItem,
            this.ExitToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuestionsToolStripMenuItem});
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // QuestionsToolStripMenuItem
            // 
            this.QuestionsToolStripMenuItem.Name = "QuestionsToolStripMenuItem";
            this.QuestionsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.QuestionsToolStripMenuItem.Text = "текст вопросов";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Enabled = false;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.NewToolStripMenuItem.Text = "Начать заново";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.ExitToolStripMenuItem1.Text = "Выход";
            this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.AboutToolStripMenuItem.Text = "Авторы";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonStart.Location = new System.Drawing.Point(195, 123);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(143, 40);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Начать тест!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelGreeting
            // 
            this.labelGreeting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.BackColor = System.Drawing.Color.Transparent;
            this.labelGreeting.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGreeting.Location = new System.Drawing.Point(9, 34);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(96, 18);
            this.labelGreeting.TabIndex = 9;
            this.labelGreeting.Text = "Здравствуйте!";
            this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelQuestion
            // 
            this.panelQuestion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelQuestion.Controls.Add(this.buttonNextQuestion);
            this.panelQuestion.Controls.Add(this.panelAnswers);
            this.panelQuestion.Controls.Add(this.labelQuestion);
            this.panelQuestion.Location = new System.Drawing.Point(75, 55);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(593, 370);
            this.panelQuestion.TabIndex = 10;
            this.panelQuestion.Visible = false;
            this.panelQuestion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuestion_Paint);
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Location = new System.Drawing.Point(250, 311);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(98, 46);
            this.buttonNextQuestion.TabIndex = 2;
            this.buttonNextQuestion.Text = "Следующий вопрос";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // panelAnswers
            // 
            this.panelAnswers.Location = new System.Drawing.Point(19, 86);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(570, 232);
            this.panelAnswers.TabIndex = 3;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(16, 39);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(14, 18);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "1";
            // 
            // RussianTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianTest.Properties.Resources.snow1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 447);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RussianTestForm";
            this.Text = "Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelAnswers;
    }
}

