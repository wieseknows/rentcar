using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace rentcar {
    public partial class addItem_frm : MetroForm {
        public addItem_frm() {
            InitializeComponent();
        }

        int totalFieldCount = 0;
        List<string> fieldNames = new List<string>();
        admin_frm admin;
        public bool change = false;
        public int changeId = 0;

        Label[] labels = new Label[10];
        TextBox[] textboxes = new TextBox[10];
        string[] values = new string[10];
        public string tableName = "";

        private void addItem_frm_Load(object sender, EventArgs e) {

            server.setTableFields(this, tableName, ref totalFieldCount, ref fieldNames, ref textboxes, change, changeId);
            Array.Resize(ref values, textboxes.Length);
            for (int i = 0; i < textboxes.Length; i++)
                values[i] = textboxes[i].Text;
            foreach (Form f in Application.OpenForms) 
                if (f.Name == "admin_frm")
                    admin = f as admin_frm;
        }

        private void button1_Click(object sender, EventArgs e) {
            for (int i = 0; i < textboxes.Length; i++)
                values[i] = textboxes[i].Text;
            if (change) server.updateByID(tableName, changeId, fieldNames, values);
            else server.insertIntoTable(tableName, values);
                

            server.refreshDataGrid(admin.tabParams, admin.movingPictureBox, admin.dataGrid);
            this.Close();
        }
    }
}
