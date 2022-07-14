namespace ExBanco
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }
        public void Give(double aux)
        {
            Saldo += aux;
        }
        public void Take(double aux)
        {
            if ((Saldo - aux) < 0)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= aux;
        }
    }
}
