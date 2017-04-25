using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace rentcar.forms.manager {
    public partial class addAvtomobil_frm : MetroForm {
        public addAvtomobil_frm() {
            InitializeComponent();
        }

        private void addAvtomobil_frm_Load(object sender, EventArgs e) {
            server.fillSearchFieldsForAvtomobil(marka_comboBox, kuzov_comboBox, model_comboBox, kompaniya_comboBox);
            for (int i = 1996; i < DateTime.Now.Year; i++)
                tehosmotr_date.Items.Add(i + 1);
            tehosmotr_date.SelectedIndex = tehosmotr_date.Items.IndexOf(DateTime.Now.Year);
        }

        private void addNewCar_button_Click(object sender, EventArgs e) {
            if ((marka_comboBox.Text.Length >= 3) && (kuzov_comboBox.Text.Length >= 3) &&
                    (model_comboBox.Text.Length >= 1) && (kompaniya_comboBox.Text.Length >= 1)) {
                string marka = server.getIdByValues("marka", new string[] { marka_comboBox.Text });
                string model = server.getIdByValues("model", new string[] { model_comboBox.Text });
                string kuzov = server.getIdByValues("kuzov", new string[] { kuzov_comboBox.Text });
                string strahovka = server.getIdByValues("strahovanie", new string[] { kompaniya_comboBox.Text, srok_comboBox.Text, Convert.ToString(summa_numericUpDown.Value) });
                string moshnost = Convert.ToString(moshnost_numericUpDown.Value);
                string tehosmotr = server.getIdByValues("tehosmotr", new string[] { tehosmotr_date.Text, ispravnost_comboBox.Text});
                string tarif = server.getIdByValues("tarif", new string[] { Convert.ToString(cena_numericUpDown.Value) });
                string nalichie = nalichie_comboBox.Text;
                server.insertIntoTable("avtomobil", new string[] {marka, model, kuzov,strahovka, moshnost, tehosmotr, tarif, nalichie});
                MessageBox.Show(this, "Автомобиль успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Проверьте правильность заполнения полей!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
    }
}
