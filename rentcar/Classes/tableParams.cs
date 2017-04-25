using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar {
    public class tableParams {
        public int formWidt = 300, formHeig = 330;
        public string tableNameDB = "Translitom";

        public static tableParams getTableParams(string pictureBoxName) {
            tableParams tem = new tableParams();
            switch (pictureBoxName) {
                case "a0vto_pictureBox": {
                    tem.tableNameDB = "avtomobil";
                    tem.formWidt = 900;
                    break;
                }
                case "a1dr_pictureBox": {
                    tem.tableNameDB = "adres";
                    tem.formWidt = 540;
                    break;
                }
                case "p2rav_pictureBox": {
                    tem.tableNameDB = "voditelskie_prava";
                    break;
                }
                case "d3olzhn_pictureBox": {
                    tem.tableNameDB = "dolzhnost";
                    break;
                }
                case "z1akaz_pictureBox": {
                    tem.tableNameDB = "zakaz";
                    tem.formWidt = 750;
                    break;
                }
                case "k2lient_pictureBox": {
                    tem.tableNameDB = "klient";
                    tem.formWidt = 820;
                    break;
                }
                case "k3uzov_pictureBox": {
                    tem.tableNameDB = "kuzov";
                    break;
                }
                case "m4arka_pictureBox": {
                    tem.tableNameDB = "marka";
                    break;
                }
                case "m2edSpr_pictureBox": {
                    tem.tableNameDB = "medic_spravka";
                    tem.formWidt = 410;
                    break;
                }
                case "m3edUchr_pictureBox": {
                    tem.tableNameDB = "medic_uchrezhdenie";
                    tem.formWidt = 510;
                    break;
                }
                case "m4odel_pictureBox": {
                    tem.tableNameDB = "model";
                    break;
                }
                case "p4asp_pictureBox": {
                    tem.tableNameDB = "pasport";
                    break;
                }
                case "s3otr_pictureBox": {
                    tem.tableNameDB = "sotrudnik";
                    tem.formWidt = 620;
                    break;
                }
                case "s3trah_pictureBox": {
                    tem.tableNameDB = "strahovanie";
                    tem.formWidt = 430;
                    break;
                }
                case "t4arif_pictureBox": {
                    tem.tableNameDB = "tarif";
                    break;
                }
                case "t4ehosmtr_pictureBox": {
                    tem.tableNameDB = "tehosmotr";
                    break;
                }
            }
            return tem;
        }
    }
}
