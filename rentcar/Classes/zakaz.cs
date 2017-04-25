using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentcar {
    public class zakaz {
        public int id;
        public string marka, sotrudnik;
        public DateTime dataZakaza;
        public bool podhodit;

        public zakaz(int id, string marka, string sotrudnik, DateTime dataZakaza) {
            this.id = id;
            this.marka = marka;
            this.sotrudnik = sotrudnik;
            this.dataZakaza = dataZakaza;
        }
    }
}
