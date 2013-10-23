namespace Impacta.Dominio
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }

        public Veiculo this[string placa]
        {
            get { return placa == Placa ? this : null; }
        }
    }
}