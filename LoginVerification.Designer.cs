namespace SchedulingDesktopUserInterfaceApp
{
    partial class LoginVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVerification));
            this.LoginVerificationLabel = new System.Windows.Forms.Label();
            this.SpanishButton = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.EnglishButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginVerificationLabel
            // 
            resources.ApplyResources(this.LoginVerificationLabel, "LoginVerificationLabel");
            this.LoginVerificationLabel.Name = "LoginVerificationLabel";
            // 
            // SpanishButton
            // 
            resources.ApplyResources(this.SpanishButton, "SpanishButton");
            this.SpanishButton.Name = "SpanishButton";
            this.SpanishButton.UseVisualStyleBackColor = true;
            this.SpanishButton.Click += new System.EventHandler(this.SpanishButton_Click_1);
            // 
            // Login
            // 
            resources.ApplyResources(this.Login, "Login");
            this.Login.Name = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // EnglishButton
            // 
            resources.ApplyResources(this.EnglishButton, "EnglishButton");
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.UseVisualStyleBackColor = true;
            this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click_1);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Username
            // 
            resources.ApplyResources(this.Username, "Username");
            this.Username.Name = "Username";
            // 
            // LoginVerification
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginVerificationLabel);
            this.Controls.Add(this.SpanishButton);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.DoubleBuffered = true;
            this.Name = "LoginVerification";
            this.Load += new System.EventHandler(this.LoginVerification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginVerificationLabel;
        private System.Windows.Forms.Button SpanishButton;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button EnglishButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Username;
    }
}