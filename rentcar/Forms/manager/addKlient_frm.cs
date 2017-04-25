using System;
using System.Windows.Forms;

namespace rentcar {
    public partial class addKlient_frm : MetroFramework.Forms.MetroForm {
        public addKlient_frm() {
            InitializeComponent();
        }

        private void addKlient_button_Click(object sender, EventArgs e) {
            if ((familiya_textBox.Text.Length >= 3) && (imya_textBox.Text.Length >= 3) &&
                    (otchestvo_textBox.Text.Length >= 1) && (seriya_textBox.Text.Length >= 1) && (nomer_textBox.Text.Length >= 1) && 
                    (gorod_textBox.Text.Length >= 1) && (ulica_textBox.Text.Length >= 1) &&
                    (dom_textBox.Text.Length >= 1) && (kvartira_textBox.Text.Length >= 1)) {
                string dataVoditeskiePrava = dataVodPrav_dateTime.Value.Year + "-" + dataVodPrav_dateTime.Value.Month + "-" + dataVodPrav_dateTime.Value.Day;
                string voditelskiePrava = server.getIdByValues("voditelskie_prava", new string[] { Convert.ToString(dataVodPrav_dateTime.Value.Date), kategoriya_comboBox.Text});

                string pasport = server.getIdByValues("pasport", new string[] { seriya_textBox.Text, nomer_textBox.Text });

                string medicUchrezhden = server.getIdByValues("medic_uchrezhdenie", new string[] { nazvanieUchrezhdenie_omboBox.Text, adresUchrezhden_textBox.Text, tipUchrezhdeniya_comboBox.Text});
                string medicSpravka = server.getIdByValues("medic_spravka", new string[] { medicUchrezhden, zdorovie_comboBox.Text });

                string adres = server.getIdByValues("adres", new string[] {strana_comboBox.Text, gorod_textBox.Text, ulica_textBox.Text, dom_textBox.Text, kvartira_textBox.Text });
                server.insertIntoTable("klient", new string[] { familiya_textBox.Text, imya_textBox.Text, otchestvo_textBox.Text, voditelskiePrava, pasport, medicSpravka, adres});
                
                MessageBox.Show(this, "Клиент успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Проверьте правильность заполнения полей!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void addKlient_frm_Load(object sender, EventArgs e) {
            strana_comboBox.SelectedIndex = kategoriya_comboBox.SelectedIndex = tipUchrezhdeniya_comboBox.SelectedIndex = nazvanieUchrezhdenie_omboBox.SelectedIndex = zdorovie_comboBox.SelectedIndex =  0;
        }
    }
}
