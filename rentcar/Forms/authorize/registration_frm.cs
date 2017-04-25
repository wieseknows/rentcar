using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace rentcar {
    public partial class registration_frm : MetroForm {
        public registration_frm() {
            InitializeComponent();
        }

        bool uniqueLogin = false;
        MySqlDataReader reader;
        string sqlQuery;
        List<string> usedLogins = new List<string>();


        private void registration_frm_Load(object sender, EventArgs e) {

            this.Location = new Point(633, 239);
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();

            sqlQuery = "SELECT * FROM sotrudnik";
            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            reader = sqlCommmand.ExecuteReader();

            if (reader.HasRows)
                while (reader.Read())
                    usedLogins.Add(reader.GetString("login"));

            connection.Close();
        }
        

        private void login_textBox_TextChanged(object sender, EventArgs e) {
            string currentLogin = login_textBox.Text;

            if (currentLogin.Length < 4) {
                loginMessage_label.ForeColor = Color.Black;
                loginMessage_label.Text = "*Не менее 4 символов";
                loginStatus_pictureBox.Image = Properties.Resources.delete26;
                uniqueLogin = false;
            }
            else {
                if (usedLogins.Contains(currentLogin)) {
                    loginMessage_label.ForeColor = Color.Red;
                    loginStatus_pictureBox.Image = Properties.Resources.delete26;
                    loginMessage_label.Text = "Данный логин занят";
                    uniqueLogin = false;
                }
                else {
                    loginMessage_label.ForeColor = Color.Green;
                    loginMessage_label.Text = "Данный логин свободен!";
                    loginStatus_pictureBox.Image = Properties.Resources.apply26;
                    uniqueLogin = true;
                }
            }
        }

        private void register_pictureBox_Click(object sender, EventArgs e) {
            bool error = false;
            
            if ((!uniqueLogin) || (parol_textBox.Text.Length < 5) || (familiya_textBox.Text.Length < 2) || (imya_textBox.Text.Length < 2) || (otchestvo_textBox.Text.Length < 2))
                error = true;

            if (!agreement_checkBox.Checked) {
                MessageBox.Show("Вы должны принять корпоративное соглашение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!error) {
                worker currentWorker = new worker(imya_textBox.Text, familiya_textBox.Text, otchestvo_textBox.Text, login_textBox.Text, parol_textBox.Text, 1.ToString());
                currentWorker.registerWorker();
                MessageBox.Show("Пользователь успешно зарегистрирован", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
                MessageBox.Show("Ошибка, проверьте правильность заполнения полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void parol_textBox_TextChanged(object sender, EventArgs e) {
            if (parol_textBox.Text.Length >= 5) parol_pictureBox.Image = Properties.Resources.apply26;
            else parol_pictureBox.Image = Properties.Resources.delete26;
        }

        private void familiya_textBox_TextChanged(object sender, EventArgs e) {
            //текстбокс в котором пишутся буквы
            TextBox tb = sender as TextBox;
            PictureBox pb = new PictureBox();

            switch (tb.Name) {
                case "familiya_textBox":
                    pb = familiya_pictureBox;
                    break;
                case "imya_textBox":
                    pb = imya_pictureBox;
                    break;
                case "otchestvo_textBox":
                    pb = otchestvo_pictureBox;
                    break;
            }
            if (tb.Text.Length >= 3) pb.Image = Properties.Resources.apply26; 
            else pb.Image = Properties.Resources.delete26; 
        }

        private void registration_frm_FormClosing(object sender, FormClosingEventArgs e) {
            foreach (Form form in Application.OpenForms) {
                if (form.Name == "authorize_frm")
                    form.Show();
            }
        }
    }
}
