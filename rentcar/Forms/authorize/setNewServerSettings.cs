using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace rentcar.forms.authorize {
    public partial class setNewServerSettings : MetroFramework.Forms.MetroForm {
        public setNewServerSettings() {
            InitializeComponent();
        }

        private void set_button_Click(object sender, EventArgs e) {
            server.serverName = serverName_textBox.Text;
            server.dbName = dbName_textBox.Text;
            server.password = password_textBox.Text;
            server.port = port_textBox.Text;
            server.userName = userName_textBox.Text;

            server.connectionStr = "server=" + server.serverName + ";user=" + server.userName + ";database=" + server.dbName + ";port=" + server.port + ";password=" + server.password + ";";
            MySqlConnection connection = new MySqlConnection(server.connectionStr);

            try {
                connection.Open();
                this.Close();
                foreach (Form f in Application.OpenForms)
                    if (f.Name == "authorize_frm")
                        f.Show();
                connection.Close();
                MessageBox.Show(this, "Подключение совершено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) {
                MessageBox.Show(this, "Проверьте правильность заполнения полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
