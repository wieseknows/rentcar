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
using MetroFramework.Components;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;

//Начало с 300 200
namespace rentcar {
    public partial class admin_frm : MetroForm {
        public admin_frm() {
            InitializeComponent();
        }

        bool delete = false, change = false;
        Point dataGridDefPos =  new Point(444, 57);
        Point[] defaultButtonsPositions = new Point[16];
        public tableParams tabParams;
        string tableName = "";
        int speed = 1;
        authorize_frm authorize;
        public PictureBox movingPictureBox;
        PictureBox[] arrayOfPictureBox = new PictureBox[16];

        

        static void setDefaultButtons(PictureBox[] array, Point[] defaults) {
            for (int i = 0; i < array.Length; i++) {
                array[i].Location = defaults[i];
                array[i].Visible = true;
            }
                
        }


        private void admin_frm_Load(object sender, EventArgs e) {
            timer_showAdm.Start();
            authorize = this.Owner as authorize_frm;

            arrayOfPictureBox[0] = a1dr_pictureBox;
            arrayOfPictureBox[1] = a0vto_pictureBox;
            arrayOfPictureBox[2] = p2rav_pictureBox;
            arrayOfPictureBox[3] = d3olzhn_pictureBox;
            arrayOfPictureBox[4] = z1akaz_pictureBox;
            arrayOfPictureBox[5] = k2lient_pictureBox;
            arrayOfPictureBox[6] = k3uzov_pictureBox;
            arrayOfPictureBox[7] = m4arka_pictureBox;
            arrayOfPictureBox[8] = m2edSpr_pictureBox;
            arrayOfPictureBox[9] = m3edUchr_pictureBox;
            arrayOfPictureBox[10] = m4odel_pictureBox;
            arrayOfPictureBox[11] = p4asp_pictureBox;
            arrayOfPictureBox[12] = s3otr_pictureBox;
            arrayOfPictureBox[13] = s3trah_pictureBox;
            arrayOfPictureBox[14] = t4arif_pictureBox;
            arrayOfPictureBox[15] = t4ehosmtr_pictureBox;

            for (int i = 0; i < arrayOfPictureBox.Length; i++)
                defaultButtonsPositions[i] = arrayOfPictureBox[i].Location;
        }

        private void avto_pictureBox_MouseDown(object sender, MouseEventArgs e) {
            PictureBox pb = sender as PictureBox;
            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }

        private void avto_pictureBox_MouseUp(object sender, MouseEventArgs e) {
            PictureBox pb = sender as PictureBox;
            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
        }

        private void timer_showAdm_Tick(object sender, EventArgs e) {
            this.Location = new Point(this.Location.X - 10, this.Location.Y - 10);
            this.Opacity += 0.05;
            if (this.Opacity == 1)
                this.timer_showAdm.Stop();
        }

        private void admin_frm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Вы действительно хотите завершить работу ?", "Подтверждение действия", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
                Environment.Exit(0);
            else
                e.Cancel = true;
        }

        private void timer_hideAdm_Tick(object sender, EventArgs e) {
            this.Location = new Point(this.Location.X + 10, this.Location.Y + 10);
            this.Opacity -= 0.05;
            if (this.Opacity == 0)
                this.Close();
        }

        private void kuzov_pictureBox_Click(object sender, EventArgs e) {
            movingPictureBox = sender as PictureBox;
            functions.disableAllButtons(arrayOfPictureBox, movingPictureBox);
            speed = 12;

            tabParams = tableParams.getTableParams(movingPictureBox.Name);
            server.fillDataGridWithTable(tabParams.tableNameDB, dataGrid);
            tableName = tabParams.tableNameDB;
            timerGoButtonLeft.Start();
        }

        private void timerGoButtonLeft_Tick(object sender, EventArgs e) {
            
            if (movingPictureBox.Location.X <= 12) {
                timerGoButtonLeft.Stop();
                timerGoButtonUp.Start();
                timerDataGrid.Start();
            }
            else
                movingPictureBox.Location = new Point(movingPictureBox.Location.X - speed, movingPictureBox.Location.Y);

        }

        private void timerGoButtonUp_Tick(object sender, EventArgs e) {
            
            if (movingPictureBox.Location.Y <= 57) {
                timerGoButtonUp.Stop();
                timerAddDelButtons.Start();
                addItem_pictureBox.Visible = true;
                delItem_pictureBox.Visible = true;
                chngItem_pictureBox.Visible = true;
            }
            else
                movingPictureBox.Location = new Point(movingPictureBox.Location.X, movingPictureBox.Location.Y - speed);
        }

        private void timerDataGrid_Tick(object sender, EventArgs e) {
            if (dataGrid.Location.X >= 108) 
                dataGrid.Location = new Point(dataGrid.Location.X - speed, dataGrid.Location.Y);

            if (this.Width < tabParams.formWidt) 
                this.Width += 20;
            if (this.Height > tabParams.formHeig)
                this.Height -= 10;

            if ((dataGrid.Location.X <= 108) && (this.Width >= tabParams.formWidt)) {
                timerDataGrid.Stop();
                back_pictureBox.Visible = true;
            }   
        }

        private void back_pictureBox_Click(object sender, EventArgs e) {
            setDefaultButtons(arrayOfPictureBox, defaultButtonsPositions);
            dataGrid.Location = dataGridDefPos;
            back_pictureBox.Visible = false;
            addItem_pictureBox.Visible = false;
            delItem_pictureBox.Visible = false;
            chngItem_pictureBox.Visible = false;
            addItem_pictureBox.Location = new Point(12, 57);
            delItem_pictureBox.Location = new Point(12, 89);
            chngItem_pictureBox.Location = new Point(12, 122);
            this.Size = new Size(402, 447);

            delete = false;
            change = false;
            delItem_pictureBox.BackColor = Color.Transparent;
            chngItem_pictureBox.BackColor = Color.Transparent;
        }

        private void timerAddDelButtons_Tick(object sender, EventArgs e) {
            if (addItem_pictureBox.Location.Y < 153) {
                chngItem_pictureBox.Location = new Point(chngItem_pictureBox.Location.X, chngItem_pictureBox.Location.Y + 3);
                delItem_pictureBox.Location = new Point(delItem_pictureBox.Location.X, delItem_pictureBox.Location.Y + 3);
                addItem_pictureBox.Location = new Point(addItem_pictureBox.Location.X, addItem_pictureBox.Location.Y + 3);
            } else
                timerAddDelButtons.Stop();
        }

        private void addItem_pictureBox_Click(object sender, EventArgs e) {
            addItem_frm additem = new addItem_frm(); ;
            additem.tableName = this.tableName;
            additem.Text = additem.button.Text = "Добавить";
            additem.ShowDialog();
        }

        private void delItem_pictureBox_Click(object sender, EventArgs e) {
            if (change)
                MessageBox.Show("Выбрана функция изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else {
                delete = !delete;
                if (delete == false) 
                    delItem_pictureBox.BackColor = Color.Transparent;
                else {
                    delItem_pictureBox.BackColor = Color.Maroon;
                    MessageBox.Show("Кликните на запись из таблицы, которую нужно удалить", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            int neededID = 0; 
            try { 
                neededID = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value); 
            } 
            catch (Exception) { 
            } 
             
            if (delete) 
                server.deleteByID(tableName, neededID); 
             
            if (change) { 
                addItem_frm additem = new addItem_frm(); ; 
                additem.tableName = this.tableName; 
                additem.Text = additem.button.Text = "Изменить"; 
                additem.change = true; 
                additem.changeId = neededID; 
                additem.ShowDialog(); 
            }
            server.refreshDataGrid(tabParams, movingPictureBox, dataGrid);
        }

        private void chngItem_pictureBox_Click(object sender, EventArgs e) {
            if (delete) 
                MessageBox.Show("Выбрана функция удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else {
                change = !change;
                if (change == false) 
                    chngItem_pictureBox.BackColor = Color.Transparent;
                else {
                    chngItem_pictureBox.BackColor = Color.Aqua;
                    MessageBox.Show("Кликните на запись из таблицы, которую нужно изменить", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
