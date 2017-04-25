using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace rentcar {
    public partial class manager_frm : MetroForm {
        public manager_frm() {
            InitializeComponent();
        }
        
        PictureBox curPictureBox;
        bool show = false;
        public int sotrudnikId = 0;
        

        private void view_pictureBox_Click(object sender, EventArgs e) {
            show = !show;
            if (show) {
                curPictureBox = sender as PictureBox;
                if (curPictureBox.Name == "view_pictureBox")
                    timerView.Start();
                else
                    timerAdd.Start();

                curPictureBox.Enabled = false;
            } else {
                panelAdd.Location = new Point(-136, 59);
                panelView.Location = new Point(280, 59);
            }
        }

        private void timerView_Tick(object sender, EventArgs e) {
            if (panelView.Location.X > 140)
                panelView.Location = new Point(panelView.Location.X - 10, panelView.Location.Y);
            else {
                timerView.Stop();
                curPictureBox.Enabled = true;
            }
        }

        private void timerAdd_Tick(object sender, EventArgs e) {
            if (panelAdd.Location.X < 4)
                panelAdd.Location = new Point(panelAdd.Location.X + 10, panelAdd.Location.Y);
            else {
                timerAdd.Stop();
                curPictureBox.Enabled = true;
            }
        }

        private void avtomobil_label_MouseMove(object sender, MouseEventArgs e) {
            Label lab = sender as Label;
            lab.BackColor = Color.FromArgb(66,40,209);
            lab.ForeColor = Color.White;
        }

        private void avtomobil_label_MouseLeave(object sender, EventArgs e) {
            Label lab = sender as Label;
            lab.BackColor = Color.Transparent;
            lab.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void avtomobilAdd_labe_MouseMove(object sender, MouseEventArgs e) {
            Label lab = sender as Label;
            lab.BackColor = Color.FromArgb(241, 84, 51);
            lab.ForeColor = Color.White;
        }

        private void avtomobilAdd_labe_MouseLeave(object sender, EventArgs e) {
            Label lab = sender as Label;
            lab.BackColor = Color.Transparent;
            lab.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void manager_frm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Вы действительно хотите завершить работу ?", "Подтверждение действия", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Environment.Exit(0);
            else e.Cancel = true;
        }

        
        private void a0vto_pictureBox_Click(object sender, EventArgs e) {
            Label label = sender as Label;
            view_form viewform = new view_form();
            
            viewform.tableName = label.Name;
            viewform.Show();

            this.Hide();
        }

        private void avtomobilAdd_label_Click(object sender, EventArgs e) {
            forms.manager.addAvtomobil_frm addAvto = new forms.manager.addAvtomobil_frm();
            addAvto.ShowDialog();
        }

        private void klientAdd_label_Click(object sender, EventArgs e) {
            addKlient_frm addKlient = new addKlient_frm();
            addKlient.ShowDialog();
        }

        private void zakazAdd_label_Click(object sender, EventArgs e) {
            addZakaz_frm frm = new addZakaz_frm();
            frm.sotrudnikId = this.sotrudnikId;
            frm.ShowDialog();
        }
    }
}
