namespace rentcar {
    partial class manager_frm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_frm));
            this.panelView = new System.Windows.Forms.Panel();
            this.z1akaz_pictureBox = new System.Windows.Forms.Label();
            this.k2lient_pictureBox = new System.Windows.Forms.Label();
            this.a0vto_pictureBox = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.zakazAdd_label = new System.Windows.Forms.Label();
            this.klientAdd_label = new System.Windows.Forms.Label();
            this.avtomobilAdd_label = new System.Windows.Forms.Label();
            this.timerView = new System.Windows.Forms.Timer(this.components);
            this.timerAdd = new System.Windows.Forms.Timer(this.components);
            this.add_pictureBox = new System.Windows.Forms.PictureBox();
            this.view_pictureBox = new System.Windows.Forms.PictureBox();
            this.panelView.SuspendLayout();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.z1akaz_pictureBox);
            this.panelView.Controls.Add(this.k2lient_pictureBox);
            this.panelView.Controls.Add(this.a0vto_pictureBox);
            this.panelView.Location = new System.Drawing.Point(280, 59);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(130, 230);
            this.panelView.TabIndex = 2;
            // 
            // z1akaz_pictureBox
            // 
            this.z1akaz_pictureBox.AutoSize = true;
            this.z1akaz_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.z1akaz_pictureBox.Font = new System.Drawing.Font("Apple Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z1akaz_pictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.z1akaz_pictureBox.Location = new System.Drawing.Point(3, 34);
            this.z1akaz_pictureBox.Name = "z1akaz_pictureBox";
            this.z1akaz_pictureBox.Size = new System.Drawing.Size(63, 23);
            this.z1akaz_pictureBox.TabIndex = 2;
            this.z1akaz_pictureBox.Text = "Заказы";
            this.z1akaz_pictureBox.Click += new System.EventHandler(this.a0vto_pictureBox_Click);
            this.z1akaz_pictureBox.MouseLeave += new System.EventHandler(this.avtomobil_label_MouseLeave);
            this.z1akaz_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.avtomobil_label_MouseMove);
            // 
            // k2lient_pictureBox
            // 
            this.k2lient_pictureBox.AutoSize = true;
            this.k2lient_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.k2lient_pictureBox.Font = new System.Drawing.Font("Apple Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k2lient_pictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.k2lient_pictureBox.Location = new System.Drawing.Point(3, 57);
            this.k2lient_pictureBox.Name = "k2lient_pictureBox";
            this.k2lient_pictureBox.Size = new System.Drawing.Size(71, 23);
            this.k2lient_pictureBox.TabIndex = 1;
            this.k2lient_pictureBox.Text = "Клиенты";
            this.k2lient_pictureBox.Click += new System.EventHandler(this.a0vto_pictureBox_Click);
            this.k2lient_pictureBox.MouseLeave += new System.EventHandler(this.avtomobil_label_MouseLeave);
            this.k2lient_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.avtomobil_label_MouseMove);
            // 
            // a0vto_pictureBox
            // 
            this.a0vto_pictureBox.AutoSize = true;
            this.a0vto_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a0vto_pictureBox.Font = new System.Drawing.Font("Apple Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a0vto_pictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.a0vto_pictureBox.Location = new System.Drawing.Point(3, 11);
            this.a0vto_pictureBox.Name = "a0vto_pictureBox";
            this.a0vto_pictureBox.Size = new System.Drawing.Size(97, 23);
            this.a0vto_pictureBox.TabIndex = 0;
            this.a0vto_pictureBox.Text = "Автомобили";
            this.a0vto_pictureBox.Click += new System.EventHandler(this.a0vto_pictureBox_Click);
            this.a0vto_pictureBox.MouseLeave += new System.EventHandler(this.avtomobil_label_MouseLeave);
            this.a0vto_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.avtomobil_label_MouseMove);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.zakazAdd_label);
            this.panelAdd.Controls.Add(this.klientAdd_label);
            this.panelAdd.Controls.Add(this.avtomobilAdd_label);
            this.panelAdd.Location = new System.Drawing.Point(-136, 59);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(130, 230);
            this.panelAdd.TabIndex = 3;
            // 
            // zakazAdd_label
            // 
            this.zakazAdd_label.AutoSize = true;
            this.zakazAdd_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zakazAdd_label.Font = new System.Drawing.Font("Apple Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zakazAdd_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zakazAdd_label.Location = new System.Drawing.Point(75, 34);
            this.zakazAdd_label.Name = "zakazAdd_label";
            this.zakazAdd_label.Size = new System.Drawing.Size(52, 23);
            this.zakazAdd_label.TabIndex = 2;
            this.zakazAdd_label.Text = "Заказ";
            this.zakazAdd_label.Click += new System.EventHandler(this.zakazAdd_label_Click);
            this.zakazAdd_label.MouseLeave += new System.EventHandler(this.avtomobilAdd_labe_MouseLeave);
            this.zakazAdd_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.avtomobilAdd_labe_MouseMove);
            // 
            // klientAdd_label
            // 
            this.klientAdd_label.AutoSize = true;
            this.klientAdd_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.klientAdd_label.Font = new System.Drawing.Font("Apple Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klientAdd_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.klientAdd_label.Location = new System.Drawing.Point(67, 57);
            this.klientAdd_label.Name = "klientAdd_label";
            this.klientAdd_label.Size = new System.Drawing.Size(60, 23);
            this.klientAdd_label.TabIndex = 1;
            this.klientAdd_label.Text = "Клиент";
            this.klientAdd_label.Click += new System.EventHandler(this.klientAdd_label_Click);
            this.klientAdd_label.MouseLeave += new System.EventHandler(this.avtomobilAdd_labe_MouseLeave);
            this.klientAdd_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.avtomobilAdd_labe_MouseMove);
            // 
            // avtomobilAdd_label
            // 
            this.avtomobilAdd_label.AutoSize = true;
            this.avtomobilAdd_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avtomobilAdd_label.Font = new System.Drawing.Font("Apple Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avtomobilAdd_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.avtomobilAdd_label.Location = new System.Drawing.Point(30, 11);
            this.avtomobilAdd_label.Name = "avtomobilAdd_label";
            this.avtomobilAdd_label.Size = new System.Drawing.Size(97, 23);
            this.avtomobilAdd_label.TabIndex = 0;
            this.avtomobilAdd_label.Text = "Автомобиль";
            this.avtomobilAdd_label.Click += new System.EventHandler(this.avtomobilAdd_label_Click);
            this.avtomobilAdd_label.MouseLeave += new System.EventHandler(this.avtomobilAdd_labe_MouseLeave);
            this.avtomobilAdd_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.avtomobilAdd_labe_MouseMove);
            // 
            // timerView
            // 
            this.timerView.Interval = 1;
            this.timerView.Tick += new System.EventHandler(this.timerView_Tick);
            // 
            // timerAdd
            // 
            this.timerAdd.Interval = 1;
            this.timerAdd.Tick += new System.EventHandler(this.timerAdd_Tick);
            // 
            // add_pictureBox
            // 
            this.add_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("add_pictureBox.Image")));
            this.add_pictureBox.Location = new System.Drawing.Point(140, 59);
            this.add_pictureBox.Name = "add_pictureBox";
            this.add_pictureBox.Size = new System.Drawing.Size(130, 230);
            this.add_pictureBox.TabIndex = 1;
            this.add_pictureBox.TabStop = false;
            this.add_pictureBox.Click += new System.EventHandler(this.view_pictureBox_Click);
            // 
            // view_pictureBox
            // 
            this.view_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("view_pictureBox.Image")));
            this.view_pictureBox.Location = new System.Drawing.Point(4, 59);
            this.view_pictureBox.Name = "view_pictureBox";
            this.view_pictureBox.Size = new System.Drawing.Size(130, 230);
            this.view_pictureBox.TabIndex = 0;
            this.view_pictureBox.TabStop = false;
            this.view_pictureBox.Click += new System.EventHandler(this.view_pictureBox_Click);
            // 
            // manager_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 295);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.add_pictureBox);
            this.Controls.Add(this.view_pictureBox);
            this.Name = "manager_frm";
            this.Text = "Выберите функцию";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.manager_frm_FormClosing);
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox view_pictureBox;
        private System.Windows.Forms.PictureBox add_pictureBox;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Timer timerView;
        private System.Windows.Forms.Timer timerAdd;
        private System.Windows.Forms.Label z1akaz_pictureBox;
        private System.Windows.Forms.Label k2lient_pictureBox;
        private System.Windows.Forms.Label a0vto_pictureBox;
        private System.Windows.Forms.Label zakazAdd_label;
        private System.Windows.Forms.Label klientAdd_label;
        private System.Windows.Forms.Label avtomobilAdd_label;
    }
}