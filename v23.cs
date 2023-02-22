namespace v23
{

    class Kalkulator
    {
        public double kali(double a, double b){
            return a * b;
        }

    }

    class Rumus:Kalkulator
    {
        public double persegipanjang(double p, double l){
            return kali(p,l);
        }
    }
}