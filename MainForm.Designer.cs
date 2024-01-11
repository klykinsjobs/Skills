namespace Skills
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SkillsListBox = new ListBox();
            AddSkillButton = new Button();
            DeleteSkillButton = new Button();
            UseSkillButton = new Button();
            StatusTextBox = new TextBox();
            AlphabeticalRadioButton = new RadioButton();
            LevelRadioButton = new RadioButton();
            LastUsedRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // SkillsListBox
            // 
            SkillsListBox.FormattingEnabled = true;
            SkillsListBox.ItemHeight = 15;
            SkillsListBox.Location = new Point(12, 37);
            SkillsListBox.Name = "SkillsListBox";
            SkillsListBox.Size = new Size(261, 229);
            SkillsListBox.TabIndex = 0;
            // 
            // AddSkillButton
            // 
            AddSkillButton.Location = new Point(12, 272);
            AddSkillButton.Name = "AddSkillButton";
            AddSkillButton.Size = new Size(83, 23);
            AddSkillButton.TabIndex = 4;
            AddSkillButton.Text = "Add Skill";
            AddSkillButton.UseVisualStyleBackColor = true;
            AddSkillButton.Click += AddSkillButton_Click;
            // 
            // DeleteSkillButton
            // 
            DeleteSkillButton.Location = new Point(101, 272);
            DeleteSkillButton.Name = "DeleteSkillButton";
            DeleteSkillButton.Size = new Size(83, 23);
            DeleteSkillButton.TabIndex = 5;
            DeleteSkillButton.Text = "Delete Skill";
            DeleteSkillButton.UseVisualStyleBackColor = true;
            DeleteSkillButton.Click += DeleteSkillButton_Click;
            // 
            // UseSkillButton
            // 
            UseSkillButton.Location = new Point(190, 272);
            UseSkillButton.Name = "UseSkillButton";
            UseSkillButton.Size = new Size(83, 23);
            UseSkillButton.TabIndex = 6;
            UseSkillButton.Text = "Use Skill";
            UseSkillButton.UseVisualStyleBackColor = true;
            UseSkillButton.Click += UseSkillButton_Click;
            // 
            // StatusTextBox
            // 
            StatusTextBox.Location = new Point(12, 301);
            StatusTextBox.Multiline = true;
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.ScrollBars = ScrollBars.Vertical;
            StatusTextBox.Size = new Size(261, 53);
            StatusTextBox.TabIndex = 7;
            StatusTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // AlphabeticalRadioButton
            // 
            AlphabeticalRadioButton.AutoSize = true;
            AlphabeticalRadioButton.Checked = true;
            AlphabeticalRadioButton.Location = new Point(12, 12);
            AlphabeticalRadioButton.Name = "AlphabeticalRadioButton";
            AlphabeticalRadioButton.Size = new Size(91, 19);
            AlphabeticalRadioButton.TabIndex = 8;
            AlphabeticalRadioButton.TabStop = true;
            AlphabeticalRadioButton.Text = "Alphabetical";
            AlphabeticalRadioButton.UseVisualStyleBackColor = true;
            AlphabeticalRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // LevelRadioButton
            // 
            LevelRadioButton.AutoSize = true;
            LevelRadioButton.Location = new Point(109, 12);
            LevelRadioButton.Name = "LevelRadioButton";
            LevelRadioButton.Size = new Size(52, 19);
            LevelRadioButton.TabIndex = 9;
            LevelRadioButton.Text = "Level";
            LevelRadioButton.UseVisualStyleBackColor = true;
            LevelRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // LastUsedRadioButton
            // 
            LastUsedRadioButton.AutoSize = true;
            LastUsedRadioButton.Location = new Point(167, 12);
            LastUsedRadioButton.Name = "LastUsedRadioButton";
            LastUsedRadioButton.Size = new Size(75, 19);
            LastUsedRadioButton.TabIndex = 10;
            LastUsedRadioButton.Text = "Last Used";
            LastUsedRadioButton.UseVisualStyleBackColor = true;
            LastUsedRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 366);
            Controls.Add(LastUsedRadioButton);
            Controls.Add(LevelRadioButton);
            Controls.Add(AlphabeticalRadioButton);
            Controls.Add(StatusTextBox);
            Controls.Add(UseSkillButton);
            Controls.Add(DeleteSkillButton);
            Controls.Add(AddSkillButton);
            Controls.Add(SkillsListBox);
            Name = "MainForm";
            Text = "Skills";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox SkillsListBox;
        private Button AddSkillButton;
        private Button DeleteSkillButton;
        private Button UseSkillButton;
        private TextBox StatusTextBox;
        private RadioButton AlphabeticalRadioButton;
        private RadioButton LevelRadioButton;
        private RadioButton LastUsedRadioButton;
    }
}
