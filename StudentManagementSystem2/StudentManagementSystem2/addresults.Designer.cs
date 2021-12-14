namespace StudentManagementSystem2
{
    partial class addresults
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
            this.label9 = new System.Windows.Forms.Label();
            this.stuid = new Guna.UI2.WinForms.Guna2TextBox();
            this.savebtn = new Guna.UI2.WinForms.Guna2Button();
            this.fname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delbtn = new Guna.UI2.WinForms.Guna2Button();
            this.updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "StudentID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // stuid
            // 
            this.stuid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stuid.DefaultText = "";
            this.stuid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stuid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stuid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stuid.DisabledState.Parent = this.stuid;
            this.stuid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stuid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stuid.FocusedState.Parent = this.stuid;
            this.stuid.ForeColor = System.Drawing.Color.Gray;
            this.stuid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stuid.HoverState.Parent = this.stuid;
            this.stuid.Location = new System.Drawing.Point(99, 54);
            this.stuid.Name = "stuid";
            this.stuid.PasswordChar = '\0';
            this.stuid.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.stuid.PlaceholderText = "";
            this.stuid.SelectedText = "";
            this.stuid.ShadowDecoration.Parent = this.stuid;
            this.stuid.Size = new System.Drawing.Size(200, 25);
            this.stuid.TabIndex = 77;
            this.stuid.TextChanged += new System.EventHandler(this.stuid_TextChanged);
            // 
            // savebtn
            // 
            this.savebtn.BorderRadius = 5;
            this.savebtn.CheckedState.Parent = this.savebtn;
            this.savebtn.CustomImages.Parent = this.savebtn;
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.HoverState.Parent = this.savebtn;
            this.savebtn.Location = new System.Drawing.Point(340, 54);
            this.savebtn.Name = "savebtn";
            this.savebtn.ShadowDecoration.Parent = this.savebtn;
            this.savebtn.Size = new System.Drawing.Size(180, 45);
            this.savebtn.TabIndex = 76;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // fname
            // 
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.DefaultText = "";
            this.fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fname.DisabledState.Parent = this.fname;
            this.fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fname.FocusedState.Parent = this.fname;
            this.fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fname.HoverState.Parent = this.fname;
            this.fname.Location = new System.Drawing.Point(99, 97);
            this.fname.Name = "fname";
            this.fname.PasswordChar = '\0';
            this.fname.PlaceholderText = "";
            this.fname.SelectedText = "";
            this.fname.ShadowDecoration.Parent = this.fname;
            this.fname.Size = new System.Drawing.Size(200, 25);
            this.fname.TabIndex = 75;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Subject ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(99, 146);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 25);
            this.guna2TextBox1.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Result";
            // 
            // delbtn
            // 
            this.delbtn.BorderRadius = 5;
            this.delbtn.CheckedState.Parent = this.delbtn;
            this.delbtn.CustomImages.Parent = this.delbtn;
            this.delbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delbtn.ForeColor = System.Drawing.Color.White;
            this.delbtn.HoverState.Parent = this.delbtn;
            this.delbtn.Location = new System.Drawing.Point(340, 175);
            this.delbtn.Name = "delbtn";
            this.delbtn.ShadowDecoration.Parent = this.delbtn;
            this.delbtn.Size = new System.Drawing.Size(180, 45);
            this.delbtn.TabIndex = 89;
            this.delbtn.Text = "Delete";
            // 
            // updatebtn
            // 
            this.updatebtn.BorderRadius = 5;
            this.updatebtn.CheckedState.Parent = this.updatebtn;
            this.updatebtn.CustomImages.Parent = this.updatebtn;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.HoverState.Parent = this.updatebtn;
            this.updatebtn.Location = new System.Drawing.Point(340, 114);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.ShadowDecoration.Parent = this.updatebtn;
            this.updatebtn.Size = new System.Drawing.Size(180, 45);
            this.updatebtn.TabIndex = 88;
            this.updatebtn.Text = "Update";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(555, 22);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(51, 26);
            this.guna2Button1.TabIndex = 90;
            this.guna2Button1.Text = "GridView";
            // 
            // addresults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 289);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stuid);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Name = "addresults";
            this.Text = "addresults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox stuid;
        private Guna.UI2.WinForms.Guna2Button savebtn;
        private Guna.UI2.WinForms.Guna2TextBox fname;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button delbtn;
        private Guna.UI2.WinForms.Guna2Button updatebtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}