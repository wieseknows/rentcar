using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace rentcar {
    public static class functions {
        public static void buttonDown(PictureBox pb) {
            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }
        //Прекращение нажатия кнопки
        public static void buttonUp(PictureBox pb) {
            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
        }
        //Нажатие на надпись
        public static void labelDown(Label lb) {
            lb.Location = new Point(lb.Location.X + 2, lb.Location.Y + 2);
        }
        //Прекращение нажатия надписи
        public static void labelUp(Label lb) {
            lb.Location = new Point(lb.Location.X - 2, lb.Location.Y - 2);
        }

        public static void disableAllButtons(PictureBox[] array, PictureBox pb) {
            for (int i = 0; i < array.Length; i++)
                if (array[i].Name != pb.Name)
                    array[i].Visible = false;
        }

        public static void showAllButtons(PictureBox[] array, PictureBox pb, tableParams tPar) {
            for (int i = 0; i < array.Length; i++)
                array[i].Visible = true;
        }

    }
}
