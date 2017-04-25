using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Drawing;
using System.Data;
using System.IO;

namespace rentcar {
    public static class server {
        public static string serverName = "localhost", userName = "root",
            dbName = "avtoprokat", port = "3306", password = "admin";

        public static string connectionStr = "server=" + server.serverName +
                ";user=" + server.userName +
                ";database=" + server.dbName +
                ";port=" + server.port +
                ";password=" + server.password + ";";


        public static void fillFieldsForAddZakaz(ComboBox avtomobil_comboBox, ComboBox klient_comboBox) {
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();
            string sqlQuery = "SELECT concat(avtomobil.id,'. ',marka.nazvanie, ' ', model.nazvanie, ', ', kuzov.nazvanie) as value FROM avtomobil join marka on avtomobil.id_marka = marka.id join model on avtomobil.id_model = model.id join kuzov on avtomobil.id_kuzov = kuzov.id order by value; ";
            MySqlCommand msc = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = msc.ExecuteReader();

            while (reader.Read()) 
                avtomobil_comboBox.Items.Add(reader.GetString("value"));

            connection.Close();

            connection = new MySqlConnection(server.connectionStr);
            connection.Open();
            sqlQuery = "SELECT concat(klient.id,'. ', klient.familiya,', ', klient.imya,' ', klient.otchestvo) as value FROM klient order by klient.familiya;";
            msc = new MySqlCommand(sqlQuery, connection);
            reader = msc.ExecuteReader();

            while (reader.Read())
                klient_comboBox.Items.Add(reader.GetString("value"));

            connection.Close();
        }

        public static void insertIntoTable(string tableName, string[] values) {
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();
            string sqlView = "select * from " + tableName;
            MySqlCommand commandView = new MySqlCommand(sqlView, connection);
            MySqlDataReader readerFields = commandView.ExecuteReader();

            string sqlQuery = "insert into " + tableName + " (`";
            for (int i = 1; i < values.Length + 1; i++)
                sqlQuery += i == values.Length? readerFields.GetName(i) + "`) " : readerFields.GetName(i) + "`,`";

            readerFields.Close();

            sqlQuery += "values ('";
            for (int i = 0; i < values.Length; i++) 
                sqlQuery += i == values.Length - 1? values[i] + "')" : values[i] + "','";

            MySqlCommand msc = new MySqlCommand(sqlQuery, connection);
            msc.ExecuteNonQuery();
            connection.Close();
        }
        

        //Получаем название таблицы и массив значений которые нужно найти
        public static string getIdByValues(string table, string[] currentValues) {
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();
            string SQLcheck = "select * from " + table;

            MySqlCommand msc = new MySqlCommand(SQLcheck, connection);
            MySqlDataReader readerFields = msc.ExecuteReader();

            //Считываем в отдельный массив имена полей нужной таблицы
            string[] fieldNames = new string[currentValues.Length];
            for (int i = 1; i < readerFields.FieldCount; i++)
                fieldNames[i-1] = readerFields.GetName(i);
            readerFields.Close();

            MySqlDataReader reader = msc.ExecuteReader();
            

            string id = null;
            while (reader.Read()) {
                bool found = true;
                for (int i = 0; i < fieldNames.Length; i++) {
                    string got = reader.GetString(fieldNames[i]);
                    string cur = currentValues[i];
                    if (got != cur) {
                        found = false;
                        break;
                    }  
                }

                if (found) {
                    id = reader.GetString("id");
                    break;
                }
            }
            if (id == null) {
                string dateNewFormat = "";
                //Ввод даты. МАЙСКЛ принимает формат 2016-10-31, а выдаёт почему то 31.10.2016 00:00:00
                if (table == "voditelskie_prava") {
                    dateNewFormat = currentValues[0].Substring(6, 4) + "-" + currentValues[0].Substring(3, 2) + "-" + currentValues[0].Substring(0, 2);
                    insertIntoTable(table, new string[] { dateNewFormat, currentValues[1]});
                    id = getIdByValues(table, currentValues);
                } else {
                    insertIntoTable(table, currentValues);
                    id = getIdByValues(table, currentValues);
                }
            }
            
            connection.Close();
            return id;
        }
        

        public static void fillSearchFieldsForAvtomobil(ComboBox marka_comboBox, ComboBox kuzov_comboBox, ComboBox sotrudnik_comboBox) {
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();
            string sqlQuery;
            MySqlCommand sqlCommand;
            MySqlDataReader reader;

            if (marka_comboBox != null) {
                sqlQuery = "SELECT * FROM marka;";
                sqlCommand = new MySqlCommand(sqlQuery, connection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                    marka_comboBox.Items.Add(reader.GetString("nazvanie"));
                reader.Close();
            }

            if (kuzov_comboBox != null) {
                sqlQuery = "SELECT * FROM kuzov;";
                sqlCommand = new MySqlCommand(sqlQuery, connection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                    kuzov_comboBox.Items.Add(reader.GetString("nazvanie"));
                reader.Close();
            }

            if (sotrudnik_comboBox != null) {
                sqlQuery = "SELECT concat(familiya, ' ', imya, ' ', otchestvo) as fio FROM sotrudnik;";
                sqlCommand = new MySqlCommand(sqlQuery, connection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                    sotrudnik_comboBox.Items.Add(reader.GetString("fio"));
                reader.Close();
            }

            connection.Close();
        }
        
        public static void fillSearchFieldsForAvtomobil(ComboBox marka_comboBox, ComboBox kuzov_comboBox, ComboBox model_comboBox, ComboBox kompaniya_comboBox) {
            fillSearchFieldsForAvtomobil(marka_comboBox, kuzov_comboBox, null);
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();

            string sqlQuery = "SELECT * FROM model";
            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
                model_comboBox.Items.Add(reader.GetString("nazvanie"));
            reader.Close();

            sqlQuery = "SELECT * FROM strahovanie";
            sqlCommand = new MySqlCommand(sqlQuery, connection);
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
                kompaniya_comboBox.Items.Add(reader.GetString("kompaniya"));
            reader.Close();

            connection.Close();
        }

        public static void highlightNalichieIspravnost(MetroGrid dataGrid) {
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();

            string sqlQuery = File.ReadAllText(Application.StartupPath + @"..\..\..\Queries\highlightNalichie.sql");
            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read()) {
                string id = reader.GetString("id");
                for (int i = 0; i < dataGrid.RowCount; i++)
                    if (Convert.ToString(dataGrid.Rows[i].Cells[0].Value) == id)
                        dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.SpringGreen;
            }

            reader.Close();
            connection.Close();
        }

        public static void fillDataGridWithTable(string tableName, MetroGrid grid) {
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            string sqlQuery = "";
            switch (tableName) {
                case "avtomobil": {
                    sqlQuery = File.ReadAllText(Application.StartupPath + @"..\..\..\Queries\viewAvtomobili.sql");
                    break;
                }
                case "zakaz": {
                    sqlQuery = File.ReadAllText(Application.StartupPath + @"..\..\..\Queries\viewZakazi.sql");
                    break;
                }
                case "klient": {
                    sqlQuery = File.ReadAllText(Application.StartupPath + @"..\..\..\Queries\viewKlienti.sql");
                    break;
                }
                default: {
                    sqlQuery = File.ReadAllText(Application.StartupPath + @"..\..\..\Queries\selectAllFrom.sql") + tableName;
                    break;
                }
                
            }
            dataAdapter.SelectCommand = new MySqlCommand(sqlQuery, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            grid.DataSource = table;
            connection.Close();
        }


        public static void deleteByID(string tableName, int neededID) {
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            connection.Open();

            string sqlQuery = "DELETE FROM " + tableName + " WHERE `id`=" + neededID.ToString();
            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, connection);
            try {
                if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно удалены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex) {
                MessageBox.Show("Ошибка! Невозможно удалить запись. Сообщение MySQL:\n\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }


        public static void refreshDataGrid(tableParams tabParams, PictureBox movingPictureBox, MetroGrid dataGrid) {
            tabParams = tableParams.getTableParams(movingPictureBox.Name);
            server.fillDataGridWithTable(tabParams.tableNameDB, dataGrid);
        }


        


        public static void setTableFields(addItem_frm form, string tableName, ref int totalFieldCount, ref List<string> fieldNames, ref TextBox[] textboxes, bool change, int findId) {
            string sqlQuery = "select * from " + tableName;
            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, connection);
            connection.Open();

            MySqlDataReader readerFields = sqlCommand.ExecuteReader();
            totalFieldCount = readerFields.FieldCount;
            if (tableName == "zakaz")
                totalFieldCount--;

            Label[] labels = new Label[totalFieldCount];
            textboxes = new TextBox[totalFieldCount - 1];

            Size textBoxSize = new Size(132, 20);
            int X = 23, lastLabelY = 58;
            int lastTextBoxY = 75;
            //Динамически со3даем лэйблы и текстбоксы для каждого и3 поелй
            for (int i = 1; i < totalFieldCount; i++) {
                labels[i - 1] = new Label();
                labels[i - 1].Text = readerFields.GetName(i);
                fieldNames.Add(readerFields.GetName(i));
                labels[i - 1].Location = new Point(X, lastLabelY);
                labels[i - 1].Size = new Size(132, 12);
                lastLabelY += 40;

                textboxes[i - 1] = new TextBox();
                textboxes[i - 1].Location = new Point(X, lastTextBoxY);
                textboxes[i - 1].Size = textBoxSize;
                lastTextBoxY += 40;

                form.Size = new Size(form.Size.Width, form.Size.Height + 40);
            }
            readerFields.Close();

            if (change) {
                string sql1 = "select * from " + tableName + " where id=" + findId;
                MySqlCommand sqlCommand1 = new MySqlCommand(sql1, connection);
                MySqlDataReader readerValues = sqlCommand1.ExecuteReader();

                readerValues.Read();
                for (int i = 1; i < totalFieldCount; i++)
                    textboxes[i - 1].Text = readerValues.GetString(fieldNames[i - 1]);

                readerValues.Close();
            }

            //Добавляем готовые контролы на нашу форму
            for (int j = 0; j < totalFieldCount - 1; j++) {
                form.Controls.Add(textboxes[j]);
                form.Controls.Add(labels[j]);
            }
            connection.Close();
        }

        public static void updateByID(string tableName, int changeId, List<string> fieldNames, string[] values) {
            string sqlQuery = "UPDATE " + tableName + " SET";
            for (int i = 0; i < fieldNames.Count; i++)
                if (i == fieldNames.Count - 1)
                    sqlQuery += " `" + fieldNames[i] + "`='" + values[i] + "'";
                else
                    sqlQuery += " `" + fieldNames[i] + "`='" + values[i] + "',";
            sqlQuery += " WHERE `id`=" + changeId;

            MySqlConnection connection = new MySqlConnection(server.connectionStr);
            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, connection);
            connection.Open();
            try {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Данные были успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception) {
                MessageBox.Show("Проверьте правильность заполнения полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
        }
        
    }
}
