namespace rentcar {
    partial class authorize_frm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorize_frm));
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.btn_login_pictureBox = new System.Windows.Forms.PictureBox();
            this.registration_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Apple Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textBox.Location = new System.Drawing.Point(225, 77);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(202, 26);
            this.login_textBox.TabIndex = 1;
            this.login_textBox.Text = "vladimir";
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Apple Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(225, 132);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(202, 26);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.Text = "user";
            // 
            // btn_login_pictureBox
            // 
            this.btn_login_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login_pictureBox.BackgroundImage")));
            this.btn_login_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_pictureBox.Location = new System.Drawing.Point(225, 188);
            this.btn_login_pictureBox.Name = "btn_login_pictureBox";
            this.btn_login_pictureBox.Size = new System.Drawing.Size(136, 41);
            this.btn_login_pictureBox.TabIndex = 3;
            this.btn_login_pictureBox.TabStop = false;
            this.btn_login_pictureBox.Click += new System.EventHandler(this.btn_login_pictureBox_Click);
            this.btn_login_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_login_pictureBox_MouseDown);
            this.btn_login_pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_login_pictureBox_MouseUp);
            // 
            // registration_label
            // 
            this.registration_label.AutoSize = true;
            this.registration_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registration_label.Font = new System.Drawing.Font("Apple Garamond", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.registration_label.Location = new System.Drawing.Point(222, 164);
            this.registration_label.Name = "registration_label";
            this.registration_label.Size = new System.Drawing.Size(92, 16);
            this.registration_label.TabIndex = 4;
            this.registration_label.Text = "Регистрация";
            this.registration_label.Click += new System.EventHandler(this.registration_label_Click);
            this.registration_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registration_label_MouseDown);
            this.registration_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.registration_label_MouseUp);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Apple Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.DimGray;
            this.login_label.Location = new System.Drawing.Point(221, 54);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(52, 23);
            this.login_label.TabIndex = 5;
            this.login_label.Text = "Логин";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Apple Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.DimGray;
            this.password_label.Location = new System.Drawing.Point(221, 109);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(63, 23);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 175);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // authorize_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(469, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.registration_label);
            this.Controls.Add(this.btn_login_pictureBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Location = new System.Drawing.Point(648, 439);
            this.Name = "authorize_frm";
            this.Text = "Авторизация пользователя";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.PictureBox btn_login_pictureBox;
        private System.Windows.Forms.Label registration_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

