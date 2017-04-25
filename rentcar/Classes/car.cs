namespace rentcar {
    public class car {
        public int id, moshnost, cena;
        public string marka, kuzov, ispravnost;
        public bool podhodit;

        public car(int id, int moshnost, int cena, string marka, string kuzov, string ispravnost) {
            this.id = id;
            this.moshnost = moshnost;
            this.cena = cena;
            this.marka = marka;
            this.kuzov = kuzov;
            this.ispravnost = ispravnost;
        }
    }
}
