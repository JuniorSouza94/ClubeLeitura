namespace ClubeLeitura.ConsoleApp
{
    public class Revista
    {
        private static int _proximoId = 1;
        public int IdRevista { get; set; }
        public string Titulo { get; set; }
        public string TipoColecao { get; set; }
        public int NumeroEdicao { get; set; }
        public int Ano { get; set; }
        public Caixa CaixaId { get; set; }
        public Revista()
        {
            IdRevista = _proximoId;
            _proximoId++;
        }
    }

}
