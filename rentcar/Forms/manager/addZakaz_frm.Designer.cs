namespace rentcar {
    partial class addZakaz_frm {
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
            this.dataZakaza_dateTime = new MetroFramework.Controls.MetroDateTime();
            this.dataZakaza_label = new System.Windows.Forms.Label();
            this.addZakaz_button = new System.Windows.Forms.Button();
            this.avtomobil_comboBox = new MetroFramework.Controls.MetroComboBox();
            this.avtomobil_label = new System.Windows.Forms.Label();
            this.klient_comboBox = new MetroFramework.Controls.MetroComboBox();
            this.klient_label = new System.Windows.Forms.Label();
            this.srok_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.srok_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataZakaza_dateTime
            // 
            this.dataZakaza_dateTime.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dataZakaza_dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataZakaza_dateTime.Location = new System.Drawing.Point(25, 76);
            this.dataZakaza_dateTime.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.dataZakaza_dateTime.MinimumSize = new System.Drawing.Size(0, 25);
            this.dataZakaza_dateTime.Name = "dataZakaza_dateTime";
            this.dataZakaza_dateTime.Size = new System.Drawing.Size(140, 25);
            this.dataZakaza_dateTime.TabIndex = 13;
            this.dataZakaza_dateTime.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dataZakaza_label
            // 
            this.dataZakaza_label.AutoSize = true;
            this.dataZakaza_label.Location = new System.Drawing.Point(23, 60);
            this.dataZakaza_label.Name = "dataZakaza_label";
            this.dataZakaza_label.Size = new System.Drawing.Size(72, 13);
            this.dataZakaza_label.TabIndex = 12;
            this.dataZakaza_label.Text = "Дата заказа";
            // 
            // addZakaz_button
            // 
            this.addZakaz_button.Location = new System.Drawing.Point(186, 76);
            this.addZakaz_button.Name = "addZakaz_button";
            this.addZakaz_button.Size = new System.Drawing.Size(114, 46);
            this.addZakaz_button.TabIndex = 24;
            this.addZakaz_button.Text = "Подтвердить";
            this.addZakaz_button.UseVisualStyleBackColor = true;
            this.addZakaz_button.Click += new System.EventHandler(this.addZakaz_button_Click);
            // 
            // avtomobil_comboBox
            // 
            this.avtomobil_comboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.avtomobil_comboBox.FormattingEnabled = true;
            this.avtomobil_comboBox.ItemHeight = 19;
            this.avtomobil_comboBox.Location = new System.Drawing.Point(25, 123);
            this.avtomobil_comboBox.MaxDropDownItems = 5;
            this.avtomobil_comboBox.Name = "avtomobil_comboBox";
            this.avtomobil_comboBox.Size = new System.Drawing.Size(141, 25);
            this.avtomobil_comboBox.Sorted = true;
            this.avtomobil_comboBox.TabIndex = 26;
            this.avtomobil_comboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.avtomobil_comboBox.UseSelectable = true;
            // 
            // avtomobil_label
            // 
            this.avtomobil_label.AutoSize = true;
            this.avtomobil_label.Location = new System.Drawing.Point(31, 109);
            this.avtomobil_label.Name = "avtomobil_label";
            this.avtomobil_label.Size = new System.Drawing.Size(69, 13);
            this.avtomobil_label.TabIndex = 25;
            this.avtomobil_label.Text = "Автомобиль";
            // 
            // klient_comboBox
            // 
            this.klient_comboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.klient_comboBox.FormattingEnabled = true;
            this.klient_comboBox.ItemHeight = 19;
            this.klient_comboBox.Location = new System.Drawing.Point(25, 214);
            this.klient_comboBox.MaxDropDownItems = 5;
            this.klient_comboBox.Name = "klient_comboBox";
            this.klient_comboBox.Size = new System.Drawing.Size(141, 25);
            this.klient_comboBox.Sorted = true;
            this.klient_comboBox.TabIndex = 28;
            this.klient_comboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.klient_comboBox.UseSelectable = true;
            // 
            // klient_label
            // 
            this.klient_label.AutoSize = true;
            this.klient_label.Location = new System.Drawing.Point(31, 198);
            this.klient_label.Name = "klient_label";
            this.klient_label.Size = new System.Drawing.Size(43, 13);
            this.klient_label.TabIndex = 27;
            this.klient_label.Text = "Клиент";
            // 
            // srok_numericUpDown
            // 
            this.srok_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srok_numericUpDown.Location = new System.Drawing.Point(25, 171);
            this.srok_numericUpDown.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.srok_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.srok_numericUpDown.Name = "srok_numericUpDown";
            this.srok_numericUpDown.Size = new System.Drawing.Size(73, 24);
            this.srok_numericUpDown.TabIndex = 29;
            this.srok_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Срок аренды";
            // 
            // addZakaz_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srok_numericUpDown);
            this.Controls.Add(this.klient_comboBox);
            this.Controls.Add(this.klient_label);
            this.Controls.Add(this.avtomobil_comboBox);
            this.Controls.Add(this.avtomobil_label);
            this.Controls.Add(this.addZakaz_button);
            this.Controls.Add(this.dataZakaza_dateTime);
            this.Controls.Add(this.dataZakaza_label);
            this.Name = "addZakaz_frm";
            this.Text = "Добавить заказ";
            this.Load += new System.EventHandler(this.addZakaz_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.srok_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dataZakaza_dateTime;
        private System.Windows.Forms.Label dataZakaza_label;
        private System.Windows.Forms.Button addZakaz_button;
        private MetroFramework.Controls.MetroComboBox avtomobil_comboBox;
        private System.Windows.Forms.Label avtomobil_label;
        private MetroFramework.Controls.MetroComboBox klient_comboBox;
        private System.Windows.Forms.Label klient_label;
        private System.Windows.Forms.NumericUpDown srok_numericUpDown;
        private System.Windows.Forms.Label label1;
    }
}