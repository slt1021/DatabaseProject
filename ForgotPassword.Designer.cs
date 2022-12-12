﻿namespace DatabaseProject
{
    partial class ForgotPassword
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
            this.ResetPassGreeting = new System.Windows.Forms.Label();
            this.SecretAnswer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SecretQuestion = new System.Windows.Forms.Label();
            this.WhatIsUser = new System.Windows.Forms.Label();
            this.WhatIsUserBox = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.Label();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.SubmitNewPass = new System.Windows.Forms.Button();
            this.BackResetButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResetPassGreeting
            // 
            this.ResetPassGreeting.AutoSize = true;
            this.ResetPassGreeting.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetPassGreeting.ForeColor = System.Drawing.SystemColors.Control;
            this.ResetPassGreeting.Location = new System.Drawing.Point(110, 6);
            this.ResetPassGreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResetPassGreeting.Name = "ResetPassGreeting";
            this.ResetPassGreeting.Size = new System.Drawing.Size(255, 36);
            this.ResetPassGreeting.TabIndex = 0;
            this.ResetPassGreeting.Text = "Reset Password";
            // 
            // SecretAnswer
            // 
            this.SecretAnswer.AutoSize = true;
            this.SecretAnswer.ForeColor = System.Drawing.SystemColors.Control;
            this.SecretAnswer.Location = new System.Drawing.Point(90, 169);
            this.SecretAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecretAnswer.Name = "SecretAnswer";
            this.SecretAnswer.Size = new System.Drawing.Size(105, 20);
            this.SecretAnswer.TabIndex = 1;
            this.SecretAnswer.Text = "Secret Answer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 191);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SecretQuestion
            // 
            this.SecretQuestion.AutoSize = true;
            this.SecretQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecretQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.SecretQuestion.Location = new System.Drawing.Point(108, 42);
            this.SecretQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecretQuestion.Name = "SecretQuestion";
            this.SecretQuestion.Size = new System.Drawing.Size(0, 20);
            this.SecretQuestion.TabIndex = 3;
            this.SecretQuestion.Click += new System.EventHandler(this.SecretQuestion_Click);
            // 
            // WhatIsUser
            // 
            this.WhatIsUser.AutoSize = true;
            this.WhatIsUser.ForeColor = System.Drawing.SystemColors.Control;
            this.WhatIsUser.Location = new System.Drawing.Point(54, 73);
            this.WhatIsUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WhatIsUser.Name = "WhatIsUser";
            this.WhatIsUser.Size = new System.Drawing.Size(271, 20);
            this.WhatIsUser.TabIndex = 4;
            this.WhatIsUser.Text = "What is your username?        and email?";
            this.WhatIsUser.Click += new System.EventHandler(this.WhatIsUser_Click);
            // 
            // WhatIsUserBox
            // 
            this.WhatIsUserBox.Location = new System.Drawing.Point(27, 95);
            this.WhatIsUserBox.Margin = new System.Windows.Forms.Padding(2);
            this.WhatIsUserBox.Name = "WhatIsUserBox";
            this.WhatIsUserBox.Size = new System.Drawing.Size(168, 27);
            this.WhatIsUserBox.TabIndex = 5;
            this.WhatIsUserBox.TextChanged += new System.EventHandler(this.WhatIsUserBox_TextChanged);
            // 
            // NewPass
            // 
            this.NewPass.AutoSize = true;
            this.NewPass.ForeColor = System.Drawing.SystemColors.Control;
            this.NewPass.Location = new System.Drawing.Point(297, 169);
            this.NewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(107, 20);
            this.NewPass.TabIndex = 6;
            this.NewPass.Text = "New Password:";
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location = new System.Drawing.Point(266, 191);
            this.NewPassBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(168, 27);
            this.NewPassBox.TabIndex = 7;
            this.NewPassBox.TextChanged += new System.EventHandler(this.NewPassBox_TextChanged);
            // 
            // SubmitNewPass
            // 
            this.SubmitNewPass.Location = new System.Drawing.Point(148, 230);
            this.SubmitNewPass.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitNewPass.Name = "SubmitNewPass";
            this.SubmitNewPass.Size = new System.Drawing.Size(167, 29);
            this.SubmitNewPass.TabIndex = 8;
            this.SubmitNewPass.Text = "Change Password";
            this.SubmitNewPass.UseVisualStyleBackColor = true;
            this.SubmitNewPass.Click += new System.EventHandler(this.SubmitNewPass_Click);
            // 
            // BackResetButton
            // 
            this.BackResetButton.Location = new System.Drawing.Point(7, 6);
            this.BackResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackResetButton.Name = "BackResetButton";
            this.BackResetButton.Size = new System.Drawing.Size(92, 29);
            this.BackResetButton.TabIndex = 13;
            this.BackResetButton.Text = "Back";
            this.BackResetButton.UseVisualStyleBackColor = true;
            this.BackResetButton.Click += new System.EventHandler(this.BackResetButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 27);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(27, 126);
            this.enter.Margin = new System.Windows.Forms.Padding(2);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(167, 29);
            this.enter.TabIndex = 15;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(214, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "enter first";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(492, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BackResetButton);
            this.Controls.Add(this.SubmitNewPass);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.WhatIsUserBox);
            this.Controls.Add(this.WhatIsUser);
            this.Controls.Add(this.SecretQuestion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SecretAnswer);
            this.Controls.Add(this.ResetPassGreeting);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ResetPassGreeting;
        private Label SecretAnswer;
        private TextBox textBox1;
        private Label SecretQuestion;
        private Label WhatIsUser;
        private TextBox WhatIsUserBox;
        private Label NewPass;
        private TextBox NewPassBox;
        private Button SubmitNewPass;
        private Button BackResetButton;
        private TextBox textBox2;
        private Button enter;
        private Label label1;
    }
}