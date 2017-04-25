using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace rentcar {

    public partial class authorize_frm : MetroForm {

        public authorize_frm() {
            InitializeComponent();
        }
        
        public void closeWindow_pictureBox_MouseMove(object sender, MouseEventArgs e) {
            PictureBox pb = sender as PictureBox;
            pb.Image = Properties.Resources.btn_close_act;
        }

        public void closeWindow_pictureBox_MouseLeave(object sender, EventArgs e) {
            PictureBox pb = sender as PictureBox;
            pb.Image = Properties.Resources.btn_close_pas;
        }

        public void closeWindow_pictureBox_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void btn_login_pictureBox_MouseDown(object sender, MouseEventArgs e) {
            functions.buttonDown(sender as PictureBox);
        }

        public void btn_login_pictureBox_MouseUp(object sender, MouseEventArgs e) {
            functions.buttonUp(sender as PictureBox);
        }


        //АВТОРИЗОВАТЬ ПОЛЬЗОВАТЕЛЯ
        private void btn_login_pictureBox_Click(object sender, EventArgs e) {
            string sql = "SELECT * FROM sotrudnik"; // Строка запроса
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            MySqlCommand sqlCom = new MySqlCommand(sql, connection);
            try {
                connection.Open();
            }
            catch (Exception) {
                MessageBox.Show(this, "Ошибка подключения к серверу, задайте новые параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                forms.authorize.setNewServerSettings setNew = new forms.authorize.setNewServerSettings();
                this.Hide();
                setNew.ShowDialog();
                password_textBox.Clear();
                login_textBox.Clear();
                return;
            }

            MySqlDataReader reader = sqlCom.ExecuteReader();

            string login = login_textBox.Text;
            string parol = password_textBox.Text;
            string username = "";
            bool foundUser = false;
            int foundUserId = 0;
            int counter = 0;


            if (reader.HasRows)
                while (reader.Read()) {
                    counter++;
                    if ((reader.GetString("login") == login) && (reader.GetString("parol") == parol)) {
                        username = reader.GetString("familiya") + " " + reader.GetString("imya")[0] + ". " + reader.GetString("otchestvo")[0] + ".";
                        foundUser = true;
                        foundUserId = reader.GetInt32("id");
                        break;
                    }
                }
            else
                MessageBox.Show("Нет совпадений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            reader.Close();


            if (foundUser) {
                if (password_textBox.Text == "admin") {
                    //MessageBox.Show("Здравствуйте " + username, "Добро пожаловать!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    admin_frm adminForm = new admin_frm();
                    this.Hide();
                    adminForm.Show();
                } else {
                    manager_frm managerForm = new manager_frm();
                    managerForm.sotrudnikId = foundUserId;
                    this.Hide();
                    managerForm.Show();
                }
            }
            else {
                MessageBox.Show("Неверная комбинация логина и пароля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login_textBox.Text = "";
                password_textBox.Text = "";
            }

            connection.Close();
        }
        

        private void registration_label_Click(object sender, EventArgs e) {
            registration_frm registration = new registration_frm();
            this.Hide();
            registration.Show();
        }

        private void registration_label_MouseDown(object sender, MouseEventArgs e) {
            functions.labelDown(sender as Label);
        }

        private void registration_label_MouseUp(object sender, MouseEventArgs e) {
            functions.labelUp(sender as Label);
        }

    }
}
