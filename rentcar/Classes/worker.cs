using System;
using MySql.Data.MySqlClient;

namespace rentcar {
    class worker {
        public string imya, familiya, otchestvo, login, parol;
        int dolzhnost;

        public worker(string f, string i, string o, string l, string p, string d) {

            string sqlQuery = "SELECT id, nazvanie FROM dolzhnost"; // Строка запроса
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            connection.Open();
            MySqlDataReader reader = sqlCommmand.ExecuteReader();

            while (reader.Read())
                if (Convert.ToString(reader[1]) == d)
                    dolzhnost = Convert.ToInt32(reader[0]);

            reader.Close();
            connection.Close();

            this.imya = i;
            this.familiya = f;
            this.otchestvo = o;
            this.login = l;
            this.parol = p;
        }

        public void registerWorker() {
            string sqlQuery = "insert into sotrudnik (`imya`, `familiya`, `otchestvo`, `login`, `parol`, `id_dolzhnost`) values (\"" + imya + "\",\"" + familiya + "\",\"" + otchestvo + "\",\"" + login + "\",\"" + parol + "\"," + dolzhnost + ")"; // Строка запроса
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            connection.Open();

            sqlCommmand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
