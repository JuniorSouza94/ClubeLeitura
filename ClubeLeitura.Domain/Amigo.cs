namespace ClubeLeitura.ConsoleApp
{
    public class Amigo
    {
        private static int _proximoId = 1;
        public int IdAmigo { get; private set; }
        public string Nome { get; set; }
        public string NomeResponsavel { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public Amigo()
        {
            IdAmigo = _proximoId;
            _proximoId++;
        }
    }

}
