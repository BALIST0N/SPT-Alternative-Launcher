
namespace SPT_Alt_Launcher
{
    partial class CreateProfileForm
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
            usernameTextBox = new TextBox();
            label1 = new Label();
            editionListBox = new ComboBox();
            label2 = new Label();
            profileCreateButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.AccessibleDescription = "";
            usernameTextBox.BackColor = Color.FromArgb(23, 32, 40);
            usernameTextBox.Font = new Font("Candara", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            usernameTextBox.ForeColor = Color.White;
            usernameTextBox.Location = new Point(120, 13);
            usernameTextBox.Margin = new Padding(4, 3, 4, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(231, 27);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.KeyPress += usernameTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 4;
            label1.Text = "User name :";
            // 
            // editionListBox
            // 
            editionListBox.BackColor = Color.FromArgb(23, 32, 40);
            editionListBox.DropDownStyle = ComboBoxStyle.DropDownList;
            editionListBox.FlatStyle = FlatStyle.Flat;
            editionListBox.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editionListBox.ForeColor = SystemColors.Window;
            editionListBox.FormattingEnabled = true;
            editionListBox.Location = new Point(120, 63);
            editionListBox.Margin = new Padding(4, 3, 4, 3);
            editionListBox.Name = "editionListBox";
            editionListBox.Size = new Size(231, 27);
            editionListBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 6;
            label2.Text = "Edition :";
            // 
            // profileCreateButton
            // 
            profileCreateButton.BackColor = Color.FromArgb(23, 32, 40);
            profileCreateButton.FlatStyle = FlatStyle.Flat;
            profileCreateButton.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileCreateButton.ForeColor = SystemColors.Control;
            profileCreateButton.Location = new Point(1, 133);
            profileCreateButton.Margin = new Padding(4, 3, 4, 3);
            profileCreateButton.Name = "profileCreateButton";
            profileCreateButton.Size = new Size(365, 44);
            profileCreateButton.TabIndex = 7;
            profileCreateButton.Text = "Create !";
            profileCreateButton.UseVisualStyleBackColor = false;
            profileCreateButton.Click += profileCreateButton_Click;
            // 
            // CreateProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 32, 40);
            ClientSize = new Size(366, 178);
            Controls.Add(profileCreateButton);
            Controls.Add(label2);
            Controls.Add(editionListBox);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CreateProfileForm";
            Text = "Create new profile :";
            FormClosing += CreateProfileForm_FormClosing;
            Load += CreateProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox editionListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button profileCreateButton;
    }
}