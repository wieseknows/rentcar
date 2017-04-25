using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace rentcar {
    public partial class view_form : MetroForm {
        public view_form() {
            InitializeComponent();
        }

        Panel movingPanel = new Panel();
        private tableParams tabParams;
        public string tableName;
        bool search = false;

        private void view_form_Load(object sender, EventArgs e) {
            tabParams = tableParams.getTableParams(tableName);
            server.fillDataGridWithTable(tabParams.tableNameDB, dataGrid, tabParams.tableNameDB);
            this.Width = tabParams.formWidt - 100;

            string caption = "";
            switch (tabParams.tableNameDB) {
                case "avtomobil": {
                    caption = "Все автомобили";
                    break;
                }
                case "klient": {
                    nalichie_checkBox.Visible = false;
                    caption = "Все клиенты";
                    search_pictureBox.Visible = false;
                    break;
                }
                case "zakaz": {
                    nalichie_checkBox.Visible = false;
                    caption = "Все заказы";
                    break;
                }
            }
            this.Text = caption;

            server.fillSearchFieldsForAvtomobil(marka_comboBox, kuzov_comboBox, null);
            server.fillSearchFieldsForAvtomobil(markaSearchZakazi_comboBox, null, sotrudnikSearchZakaz_comboBox);
        }

        private void view_form_FormClosing(object sender, FormClosingEventArgs e) {
            foreach (Form form in Application.OpenForms)
                if (form.Name == "manager_frm")
                    form.Show();
        }
        


        private void nalichie_checkBox_CheckedChanged(object sender, EventArgs e) {
            if (nalichie_checkBox.Checked)
                server.highlightNalichieIspravnost(dataGrid);
            else 
                for (int i = 0; i < dataGrid.RowCount; i++) 
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
        }

        private void search_pictureBox_MouseDown(object sender, MouseEventArgs e) {
            functions.buttonDown(search_pictureBox);
        }

        private void search_pictureBox_MouseUp(object sender, MouseEventArgs e) {
            functions.buttonUp(search_pictureBox);
        }
        

        private void search_timer_Tick(object sender, EventArgs e) {
            int needLocation = movingPanel == searchZakazi_panel ? 115 : 85;
            if (movingPanel.Location.Y <= needLocation) 
                search_timer.Stop();
            else 
                movingPanel.Location = new Point(movingPanel.Location.X, movingPanel.Location.Y - 10);
        }

        private void search_pictureBox_Click(object sender, EventArgs e) {
            int sizeX = 0;
            search = !search;
            switch (tabParams.tableNameDB) {
                case "zakaz": {
                    movingPanel = searchZakazi_panel;
                    sizeX = 250;
                    break;
                }
                case "avtomobil": {
                    movingPanel = searchAvtomobili_panel;
                    sizeX = 163;
                    break;
                }
            }
            if (search) {
                this.Width = this.Width + sizeX;
                dataGrid.Location = new Point(dataGrid.Location.X + sizeX, dataGrid.Location.Y);
                search_timer.Start();
                nalichie_checkBox.Visible = false;
                nalichie_checkBox.Checked = false;
            }
            else {
                this.Width = this.Width - sizeX;
                dataGrid.Location = new Point(dataGrid.Location.X - sizeX, dataGrid.Location.Y);
                movingPanel.Location = new Point(5, 385);
                nalichie_checkBox.Visible = tabParams.tableNameDB == "avtomobil";
            }
        }




        private void search_button_Click(object sender, EventArgs e) {
            for (int i = 0; i < dataGrid.RowCount; i++)
                dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;


            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();
            string sqlQuery = "";
            bool polyaNePustie = false;

            switch (tabParams.tableNameDB) {
                case "avtomobil": {
                    sqlQuery = File.ReadAllText(Application.StartupPath + @"..\..\..\Queries\searchAvtomobil.sql");
                    polyaNePustie = moshnost_textBox.Text != "" || cena_textBox.Text != "" || marka_comboBox.Text != "" || kuzov_comboBox.Text != "";
                    if (polyaNePustie)
                        sqlQuery += " where ";  

                    if (moshnost_textBox.Text != "") {
                        string znak = moshnostMore_radioButton.Checked ? ">=" : "<=";
                        sqlQuery += " moshnost" + znak + moshnost_textBox.Text;
                    }

                    if (cena_textBox.Text != "") {
                        if (moshnost_textBox.Text != "")
                            sqlQuery += " and ";

                        string znak = cenaMore_radioButton.Checked ? ">=" : "<=";
                        sqlQuery += " cena_za_sutki" + znak + cena_textBox.Text;
                    }

                    if (marka_comboBox.Text != "") {
                        if (cena_textBox.Text != "" || moshnost_textBox.Text != "")
                            sqlQuery += " and ";
                        
                        sqlQuery += " marka.nazvanie='" + marka_comboBox.Text + "'";
                    }

                    if (kuzov_comboBox.Text != "") {
                        if (cena_textBox.Text != "" || moshnost_textBox.Text != "" || marka_comboBox.Text != "")
                            sqlQuery += " and ";

                        sqlQuery += " kuzov.nazvanie='" + kuzov_comboBox.Text + "'";
                    }

                    break;
                }
                case "zakaz": {
                    sqlQuery = File.ReadAllText(Application.StartupPath + @"..\..\..\Queries\searchZakazi.sql");
                    polyaNePustie = sotrudnikSearchZakaz_comboBox.Text != "" || data_checkBox.Checked || markaSearchZakazi_comboBox.Text != "";
                    if (polyaNePustie)
                        sqlQuery += " where ";

                    if (sotrudnikSearchZakaz_comboBox.Text != "")
                        sqlQuery += " concat(sotrudnik.familiya, ' ', sotrudnik.imya, ' ', sotrudnik.otchestvo)='" + sotrudnikSearchZakaz_comboBox.Text + "'";

                    if (data_checkBox.Checked) {
                        if (sotrudnikSearchZakaz_comboBox.Text != "")
                            sqlQuery += " and ";

                        string znak = "='";
                        if (ransheDataZakaz_radioButton.Checked) znak = "<'";
                        else if (pozheDataZakaz_radioButton.Checked) znak = ">'";
                        string dt = dataSearchZakaz_dateTime.Value.Date.ToString("yyyy-MM-dd");
                        sqlQuery += " zakaz.data" + znak + dt + "'";
                    }

                    if (markaSearchZakazi_comboBox.Text != "") {
                        if (sotrudnikSearchZakaz_comboBox.Text != "" || data_checkBox.Checked)
                            sqlQuery += " and ";
                        sqlQuery += " marka.nazvanie='" + markaSearchZakazi_comboBox.Text + "'";
                    }
                    break;
                }
            }

            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            if (!reader.HasRows || !polyaNePustie) {
                MessageBox.Show(this, "Совпадений не найдено!", "Потрачено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tabParams.tableNameDB == "avtomobil" && otchet_checkBox.Checked) {
                string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
                BaseFont baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLD);

                using (Document document = new Document())
                using (FileStream stream = new FileStream("Otchet.pdf", FileMode.Create)) {
                    document.SetPageSize(PageSize.LETTER.Rotate());
                    PdfWriter.GetInstance(document, stream);
                    document.Open();

                    document.Add(new Paragraph("Отчет", font));

                    PdfPTable table = new PdfPTable(9);
                    PdfPCell cell = new PdfPCell(new Phrase("Имеющиеся автомобили", font));
                    cell.Colspan = 9;
                    cell.HorizontalAlignment = 0;
                    table.AddCell(cell);

                    table.AddCell(new Phrase("id", font));
                    table.AddCell(new Phrase("Наличие", font));
                    table.AddCell(new Phrase("Марка", font));
                    table.AddCell(new Phrase("Модель", font));
                    table.AddCell(new Phrase("Кузов", font));
                    table.AddCell(new Phrase("Мощность", font));
                    table.AddCell(new Phrase("Исправность", font));
                    table.AddCell(new Phrase("Страховка", font));
                    table.AddCell(new Phrase("Цена за сутки", font));

                    while (reader.Read()) {
                        table.AddCell(new Phrase(reader.GetString("id"), font));
                        table.AddCell(new Phrase(reader.GetString("Наличие"), boldFont));
                        table.AddCell(new Phrase(reader.GetString("Марка"), font));
                        table.AddCell(new Phrase(reader.GetString("Модель"), font));
                        table.AddCell(new Phrase(reader.GetString("Кузов"), font));
                        table.AddCell(new Phrase(reader.GetString("Мощность"), font));
                        table.AddCell(new Phrase(reader.GetString("Исправность"), boldFont));
                        table.AddCell(new Phrase(reader.GetString("Страховка"), font));
                        table.AddCell(new Phrase(reader.GetString("Цена за сутки"), font));
                    }
                    document.Add(table);
                    document.Close();
                }
                System.Diagnostics.Process.Start("Otchet.pdf");

                connection.Close();
                connection.Open();
                reader = sqlCommand.ExecuteReader();
            }
            
            while (reader.Read()) {
                string id = reader.GetString("id");
                for (int i = 0; i < dataGrid.RowCount; i++) 
                    if (Convert.ToString(dataGrid.Rows[i].Cells[0].Value) == id)
                        dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.SpringGreen;
            }

            connection.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            bool val = data_checkBox.Checked? true: false;

            dataSearchZakaz_dateTime.Enabled = val;
            dataSearchZakaziRadiobuttons_panel.Enabled = val;
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            PictureBox pb = sender as PictureBox;
            ComboBox cb = new ComboBox();
            switch (pb.Name) {
                case "pictureBox1": {
                    cb = marka_comboBox;
                    break;
                }
                case "pictureBox2": {
                    cb = kuzov_comboBox;
                    break;
                }
                case "pictureBox3": {
                    cb = sotrudnikSearchZakaz_comboBox;
                    break;
                }
                case "pictureBox4": {
                    cb = markaSearchZakazi_comboBox;
                    break;
                }
            }
            cb.SelectedIndex = -1;
        }
        
    }
}
