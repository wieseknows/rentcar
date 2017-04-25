using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace rentcar {
    public partial class addZakaz_frm : MetroFramework.Forms.MetroForm {
        public addZakaz_frm() {
            InitializeComponent();
        }

        public int sotrudnikId = 0;

        private void addZakaz_button_Click(object sender, EventArgs e) {
            if ((avtomobil_comboBox.Text != "") && (klient_comboBox.Text != "")) {
                string klient = klient_comboBox.Text.Substring(0, klient_comboBox.Text.IndexOf('.'));
                string avtomobil = avtomobil_comboBox.Text.Substring(0, avtomobil_comboBox.Text.IndexOf('.'));
                string data = dataZakaza_dateTime.Value.Date.ToString("yyyy-MM-dd");
                server.insertIntoTable("zakaz", new string[] {klient, avtomobil, Convert.ToString(sotrudnikId), data, srok_numericUpDown.Value.ToString()});
                
                MySqlConnection connection = new MySqlConnection(server.connectionStr);
                connection.Open();
                string zakazIDQuery = "SELECT LAST_INSERT_ID();";
                MySqlCommand command = new MySqlCommand(zakazIDQuery, connection);
                int zakazID = Convert.ToInt32(command.ExecuteScalar());

                string query = "call avtoprokat.setStoimost(" + zakazID.ToString() + ");";
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                query = "call avtoprokat.rentAuto(" + avtomobil + ");" ;
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show(this, "Заказ успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Проверьте правильность заполнения полей!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void addZakaz_frm_Load(object sender, EventArgs e) {
            server.fillFieldsForAddZakaz(avtomobil_comboBox, klient_comboBox);
        }
    }
}
