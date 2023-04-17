namespace ClubeLeitura.ConsoleApp
{
    public class Caixa
    {
        private static int _proximoId = 1;
        public int IdCaixa { get; set; }
        public string Cor { get; set; }
        public string Etiqueta { get; set; }
        public Caixa()
        {
            IdCaixa = _proximoId;
            _proximoId++;
        }        
    }

}
