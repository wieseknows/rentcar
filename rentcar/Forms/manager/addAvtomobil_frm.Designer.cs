namespace rentcar.forms.manager {
    partial class addAvtomobil_frm {
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
            this.marka_label = new System.Windows.Forms.Label();
            this.marka_comboBox = new System.Windows.Forms.ComboBox();
            this.kuzov_comboBox = new System.Windows.Forms.ComboBox();
            this.kuzov_label = new System.Windows.Forms.Label();
            this.model_comboBox = new System.Windows.Forms.ComboBox();
            this.model_label = new System.Windows.Forms.Label();
            this.avtomobil_groupBox = new System.Windows.Forms.GroupBox();
            this.nalichie_comboBox = new System.Windows.Forms.ComboBox();
            this.nalichie_label = new System.Windows.Forms.Label();
            this.moshnost_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.moshnost_label = new System.Windows.Forms.Label();
            this.cena_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cena_label = new System.Windows.Forms.Label();
            this.tehosmotr_groupBox = new System.Windows.Forms.GroupBox();
            this.tehosmotr_date = new System.Windows.Forms.ComboBox();
            this.date_label = new System.Windows.Forms.Label();
            this.ispravnost_label = new System.Windows.Forms.Label();
            this.ispravnost_comboBox = new System.Windows.Forms.ComboBox();
            this.strahovka_groupBox = new System.Windows.Forms.GroupBox();
            this.srok_comboBox = new System.Windows.Forms.ComboBox();
            this.summa_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.summa_label = new System.Windows.Forms.Label();
            this.kompaniya_comboBox = new System.Windows.Forms.ComboBox();
            this.kompaniya_label = new System.Windows.Forms.Label();
            this.srok_label = new System.Windows.Forms.Label();
            this.addNewCar_button = new System.Windows.Forms.Button();
            this.avtomobil_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moshnost_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena_numericUpDown)).BeginInit();
            this.tehosmotr_groupBox.SuspendLayout();
            this.strahovka_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summa_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // marka_label
            // 
            this.marka_label.AutoSize = true;
            this.marka_label.Location = new System.Drawing.Point(4, 20);
            this.marka_label.Name = "marka_label";
            this.marka_label.Size = new System.Drawing.Size(40, 13);
            this.marka_label.TabIndex = 0;
            this.marka_label.Text = "Марка";
            // 
            // marka_comboBox
            // 
            this.marka_comboBox.FormattingEnabled = true;
            this.marka_comboBox.Location = new System.Drawing.Point(7, 36);
            this.marka_comboBox.Name = "marka_comboBox";
            this.marka_comboBox.Size = new System.Drawing.Size(126, 21);
            this.marka_comboBox.TabIndex = 1;
            // 
            // kuzov_comboBox
            // 
            this.kuzov_comboBox.FormattingEnabled = true;
            this.kuzov_comboBox.Location = new System.Drawing.Point(7, 79);
            this.kuzov_comboBox.Name = "kuzov_comboBox";
            this.kuzov_comboBox.Size = new System.Drawing.Size(126, 21);
            this.kuzov_comboBox.TabIndex = 3;
            // 
            // kuzov_label
            // 
            this.kuzov_label.AutoSize = true;
            this.kuzov_label.Location = new System.Drawing.Point(4, 63);
            this.kuzov_label.Name = "kuzov_label";
            this.kuzov_label.Size = new System.Drawing.Size(37, 13);
            this.kuzov_label.TabIndex = 2;
            this.kuzov_label.Text = "Кузов";
            // 
            // model_comboBox
            // 
            this.model_comboBox.FormattingEnabled = true;
            this.model_comboBox.Location = new System.Drawing.Point(7, 120);
            this.model_comboBox.Name = "model_comboBox";
            this.model_comboBox.Size = new System.Drawing.Size(126, 21);
            this.model_comboBox.TabIndex = 5;
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Location = new System.Drawing.Point(4, 104);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(46, 13);
            this.model_label.TabIndex = 4;
            this.model_label.Text = "Модель";
            // 
            // avtomobil_groupBox
            // 
            this.avtomobil_groupBox.Controls.Add(this.nalichie_comboBox);
            this.avtomobil_groupBox.Controls.Add(this.nalichie_label);
            this.avtomobil_groupBox.Controls.Add(this.moshnost_numericUpDown);
            this.avtomobil_groupBox.Controls.Add(this.moshnost_label);
            this.avtomobil_groupBox.Controls.Add(this.cena_numericUpDown);
            this.avtomobil_groupBox.Controls.Add(this.cena_label);
            this.avtomobil_groupBox.Controls.Add(this.marka_comboBox);
            this.avtomobil_groupBox.Controls.Add(this.model_comboBox);
            this.avtomobil_groupBox.Controls.Add(this.marka_label);
            this.avtomobil_groupBox.Controls.Add(this.model_label);
            this.avtomobil_groupBox.Controls.Add(this.kuzov_label);
            this.avtomobil_groupBox.Controls.Add(this.kuzov_comboBox);
            this.avtomobil_groupBox.Location = new System.Drawing.Point(11, 63);
            this.avtomobil_groupBox.Name = "avtomobil_groupBox";
            this.avtomobil_groupBox.Size = new System.Drawing.Size(162, 223);
            this.avtomobil_groupBox.TabIndex = 6;
            this.avtomobil_groupBox.TabStop = false;
            this.avtomobil_groupBox.Text = "Автомобиль";
            // 
            // nalichie_comboBox
            // 
            this.nalichie_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nalichie_comboBox.FormattingEnabled = true;
            this.nalichie_comboBox.Items.AddRange(new object[] {
            "В наличии",
            "Под заказ"});
            this.nalichie_comboBox.Location = new System.Drawing.Point(70, 201);
            this.nalichie_comboBox.Name = "nalichie_comboBox";
            this.nalichie_comboBox.Size = new System.Drawing.Size(63, 21);
            this.nalichie_comboBox.TabIndex = 12;
            // 
            // nalichie_label
            // 
            this.nalichie_label.AutoSize = true;
            this.nalichie_label.Location = new System.Drawing.Point(67, 185);
            this.nalichie_label.Name = "nalichie_label";
            this.nalichie_label.Size = new System.Drawing.Size(50, 13);
            this.nalichie_label.TabIndex = 11;
            this.nalichie_label.Text = "Наличие";
            // 
            // moshnost_numericUpDown
            // 
            this.moshnost_numericUpDown.Location = new System.Drawing.Point(7, 202);
            this.moshnost_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moshnost_numericUpDown.Name = "moshnost_numericUpDown";
            this.moshnost_numericUpDown.Size = new System.Drawing.Size(57, 20);
            this.moshnost_numericUpDown.TabIndex = 10;
            this.moshnost_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // moshnost_label
            // 
            this.moshnost_label.AutoSize = true;
            this.moshnost_label.Location = new System.Drawing.Point(4, 186);
            this.moshnost_label.Name = "moshnost_label";
            this.moshnost_label.Size = new System.Drawing.Size(60, 13);
            this.moshnost_label.TabIndex = 8;
            this.moshnost_label.Text = "Мощность";
            // 
            // cena_numericUpDown
            // 
            this.cena_numericUpDown.Location = new System.Drawing.Point(7, 162);
            this.cena_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cena_numericUpDown.Name = "cena_numericUpDown";
            this.cena_numericUpDown.Size = new System.Drawing.Size(126, 20);
            this.cena_numericUpDown.TabIndex = 7;
            this.cena_numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cena_label
            // 
            this.cena_label.AutoSize = true;
            this.cena_label.Location = new System.Drawing.Point(4, 146);
            this.cena_label.Name = "cena_label";
            this.cena_label.Size = new System.Drawing.Size(79, 13);
            this.cena_label.TabIndex = 6;
            this.cena_label.Text = "Цена за сутки";
            // 
            // tehosmotr_groupBox
            // 
            this.tehosmotr_groupBox.Controls.Add(this.tehosmotr_date);
            this.tehosmotr_groupBox.Controls.Add(this.date_label);
            this.tehosmotr_groupBox.Controls.Add(this.ispravnost_label);
            this.tehosmotr_groupBox.Controls.Add(this.ispravnost_comboBox);
            this.tehosmotr_groupBox.Location = new System.Drawing.Point(179, 63);
            this.tehosmotr_groupBox.Name = "tehosmotr_groupBox";
            this.tehosmotr_groupBox.Size = new System.Drawing.Size(162, 117);
            this.tehosmotr_groupBox.TabIndex = 7;
            this.tehosmotr_groupBox.TabStop = false;
            this.tehosmotr_groupBox.Text = "Техосмотр";
            // 
            // tehosmotr_date
            // 
            this.tehosmotr_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tehosmotr_date.FormattingEnabled = true;
            this.tehosmotr_date.Location = new System.Drawing.Point(7, 39);
            this.tehosmotr_date.Name = "tehosmotr_date";
            this.tehosmotr_date.Size = new System.Drawing.Size(71, 21);
            this.tehosmotr_date.TabIndex = 4;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(4, 20);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(25, 13);
            this.date_label.TabIndex = 0;
            this.date_label.Text = "Год";
            // 
            // ispravnost_label
            // 
            this.ispravnost_label.AutoSize = true;
            this.ispravnost_label.Location = new System.Drawing.Point(4, 63);
            this.ispravnost_label.Name = "ispravnost_label";
            this.ispravnost_label.Size = new System.Drawing.Size(74, 13);
            this.ispravnost_label.TabIndex = 2;
            this.ispravnost_label.Text = "Исправность";
            // 
            // ispravnost_comboBox
            // 
            this.ispravnost_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ispravnost_comboBox.FormattingEnabled = true;
            this.ispravnost_comboBox.Items.AddRange(new object[] {
            "Исправен",
            "Не исправен"});
            this.ispravnost_comboBox.Location = new System.Drawing.Point(7, 79);
            this.ispravnost_comboBox.Name = "ispravnost_comboBox";
            this.ispravnost_comboBox.Size = new System.Drawing.Size(139, 21);
            this.ispravnost_comboBox.TabIndex = 3;
            // 
            // strahovka_groupBox
            // 
            this.strahovka_groupBox.Controls.Add(this.srok_comboBox);
            this.strahovka_groupBox.Controls.Add(this.summa_numericUpDown);
            this.strahovka_groupBox.Controls.Add(this.summa_label);
            this.strahovka_groupBox.Controls.Add(this.kompaniya_comboBox);
            this.strahovka_groupBox.Controls.Add(this.kompaniya_label);
            this.strahovka_groupBox.Controls.Add(this.srok_label);
            this.strahovka_groupBox.Location = new System.Drawing.Point(179, 186);
            this.strahovka_groupBox.Name = "strahovka_groupBox";
            this.strahovka_groupBox.Size = new System.Drawing.Size(162, 153);
            this.strahovka_groupBox.TabIndex = 8;
            this.strahovka_groupBox.TabStop = false;
            this.strahovka_groupBox.Text = "Страховка";
            // 
            // srok_comboBox
            // 
            this.srok_comboBox.FormattingEnabled = true;
            this.srok_comboBox.Items.AddRange(new object[] {
            "6",
            "10",
            "12",
            "15",
            "18"});
            this.srok_comboBox.Location = new System.Drawing.Point(7, 79);
            this.srok_comboBox.Name = "srok_comboBox";
            this.srok_comboBox.Size = new System.Drawing.Size(114, 21);
            this.srok_comboBox.TabIndex = 10;
            // 
            // summa_numericUpDown
            // 
            this.summa_numericUpDown.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.summa_numericUpDown.Location = new System.Drawing.Point(7, 122);
            this.summa_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.summa_numericUpDown.Name = "summa_numericUpDown";
            this.summa_numericUpDown.Size = new System.Drawing.Size(114, 20);
            this.summa_numericUpDown.TabIndex = 9;
            this.summa_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // summa_label
            // 
            this.summa_label.AutoSize = true;
            this.summa_label.Location = new System.Drawing.Point(4, 106);
            this.summa_label.Name = "summa_label";
            this.summa_label.Size = new System.Drawing.Size(108, 13);
            this.summa_label.TabIndex = 8;
            this.summa_label.Text = "Сумма страхования";
            // 
            // kompaniya_comboBox
            // 
            this.kompaniya_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kompaniya_comboBox.FormattingEnabled = true;
            this.kompaniya_comboBox.Location = new System.Drawing.Point(7, 36);
            this.kompaniya_comboBox.Name = "kompaniya_comboBox";
            this.kompaniya_comboBox.Size = new System.Drawing.Size(114, 21);
            this.kompaniya_comboBox.TabIndex = 8;
            // 
            // kompaniya_label
            // 
            this.kompaniya_label.AutoSize = true;
            this.kompaniya_label.Location = new System.Drawing.Point(4, 20);
            this.kompaniya_label.Name = "kompaniya_label";
            this.kompaniya_label.Size = new System.Drawing.Size(58, 13);
            this.kompaniya_label.TabIndex = 0;
            this.kompaniya_label.Text = "Компания";
            // 
            // srok_label
            // 
            this.srok_label.AutoSize = true;
            this.srok_label.Location = new System.Drawing.Point(4, 63);
            this.srok_label.Name = "srok_label";
            this.srok_label.Size = new System.Drawing.Size(155, 13);
            this.srok_label.TabIndex = 2;
            this.srok_label.Text = "Срок страхования (месяцев) ";
            // 
            // addNewCar_button
            // 
            this.addNewCar_button.Location = new System.Drawing.Point(11, 298);
            this.addNewCar_button.Name = "addNewCar_button";
            this.addNewCar_button.Size = new System.Drawing.Size(162, 36);
            this.addNewCar_button.TabIndex = 9;
            this.addNewCar_button.Text = "Добавить";
            this.addNewCar_button.UseVisualStyleBackColor = true;
            this.addNewCar_button.Click += new System.EventHandler(this.addNewCar_button_Click);
            // 
            // addAvtomobil_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 350);
            this.Controls.Add(this.addNewCar_button);
            this.Controls.Add(this.strahovka_groupBox);
            this.Controls.Add(this.tehosmotr_groupBox);
            this.Controls.Add(this.avtomobil_groupBox);
            this.Name = "addAvtomobil_frm";
            this.Text = "Добавить автомобиль";
            this.Load += new System.EventHandler(this.addAvtomobil_frm_Load);
            this.avtomobil_groupBox.ResumeLayout(false);
            this.avtomobil_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moshnost_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena_numericUpDown)).EndInit();
            this.tehosmotr_groupBox.ResumeLayout(false);
            this.tehosmotr_groupBox.PerformLayout();
            this.strahovka_groupBox.ResumeLayout(false);
            this.strahovka_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summa_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label marka_label;
        private System.Windows.Forms.ComboBox marka_comboBox;
        private System.Windows.Forms.ComboBox kuzov_comboBox;
        private System.Windows.Forms.Label kuzov_label;
        private System.Windows.Forms.ComboBox model_comboBox;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.GroupBox avtomobil_groupBox;
        private System.Windows.Forms.GroupBox tehosmotr_groupBox;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label ispravnost_label;
        private System.Windows.Forms.ComboBox ispravnost_comboBox;
        private System.Windows.Forms.NumericUpDown cena_numericUpDown;
        private System.Windows.Forms.Label cena_label;
        private System.Windows.Forms.GroupBox strahovka_groupBox;
        private System.Windows.Forms.ComboBox kompaniya_comboBox;
        private System.Windows.Forms.Label kompaniya_label;
        private System.Windows.Forms.Label srok_label;
        private System.Windows.Forms.NumericUpDown summa_numericUpDown;
        private System.Windows.Forms.Label summa_label;
        private System.Windows.Forms.Button addNewCar_button;
        private System.Windows.Forms.ComboBox tehosmotr_date;
        private System.Windows.Forms.ComboBox srok_comboBox;
        private System.Windows.Forms.ComboBox nalichie_comboBox;
        private System.Windows.Forms.Label nalichie_label;
        private System.Windows.Forms.NumericUpDown moshnost_numericUpDown;
        private System.Windows.Forms.Label moshnost_label;
    }
}