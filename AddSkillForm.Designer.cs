namespace Skills
{
    partial class AddSkillForm
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
            label1 = new Label();
            SkillTextBox = new TextBox();
            OKButton = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "New skill name:";
            // 
            // SkillTextBox
            // 
            SkillTextBox.Location = new Point(12, 27);
            SkillTextBox.Name = "SkillTextBox";
            SkillTextBox.Size = new Size(156, 23);
            SkillTextBox.TabIndex = 1;
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(12, 56);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 2;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            CloseButton.DialogResult = DialogResult.Cancel;
            CloseButton.Location = new Point(93, 56);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // AddSkillForm
            // 
            AcceptButton = OKButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CloseButton;
            ClientSize = new Size(174, 81);
            Controls.Add(CloseButton);
            Controls.Add(OKButton);
            Controls.Add(SkillTextBox);
            Controls.Add(label1);
            Name = "AddSkillForm";
            Text = "Add Skill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OKButton;
        private Button CloseButton;
        public TextBox SkillTextBox;
    }
}