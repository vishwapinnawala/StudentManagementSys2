namespace StudentManagementSystem2
{
    partial class itdivlogin
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
            this.labelerror = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.userid = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.ForeColor = System.Drawing.Color.Crimson;
            this.labelerror.Location = new System.Drawing.Point(176, 166);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(0, 13);
            this.labelerror.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(183, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(183, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "UserID";
            // 
            // loginbtn
            // 
            this.loginbtn.BorderColor = System.Drawing.Color.Empty;
            this.loginbtn.BorderRadius = 10;
            this.loginbtn.CheckedState.Parent = this.loginbtn;
            this.loginbtn.CustomImages.Parent = this.loginbtn;
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.HoverState.Parent = this.loginbtn;
            this.loginbtn.Location = new System.Drawing.Point(195, 194);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.ShadowDecoration.Parent = this.loginbtn;
            this.loginbtn.Size = new System.Drawing.Size(118, 35);
            this.loginbtn.TabIndex = 32;
            this.loginbtn.Text = "Login";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // password
            // 
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.BorderRadius = 5;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.FocusedState.Parent = this.password;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.HoverState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(182, 132);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(148, 21);
            this.password.TabIndex = 31;
            // 
            // userid
            // 
            this.userid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userid.BorderRadius = 5;
            this.userid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userid.DefaultText = "";
            this.userid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userid.DisabledState.Parent = this.userid;
            this.userid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userid.FocusedState.Parent = this.userid;
            this.userid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userid.HoverState.Parent = this.userid;
            this.userid.Location = new System.Drawing.Point(182, 72);
            this.userid.Name = "userid";
            this.userid.PasswordChar = '\0';
            this.userid.PlaceholderForeColor = System.Drawing.Color.White;
            this.userid.PlaceholderText = "";
            this.userid.SelectedText = "";
            this.userid.ShadowDecoration.Parent = this.userid;
            this.userid.Size = new System.Drawing.Size(148, 21);
            this.userid.TabIndex = 30;
            // 
            // itdivlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 284);
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userid);
            this.Name = "itdivlogin";
            this.Text = "itdivlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelerror;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button loginbtn;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox userid;
    }
}