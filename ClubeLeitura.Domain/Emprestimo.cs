namespace ClubeLeitura.ConsoleApp
{
    public class Emprestimo
    {
        private static int _proximoId = 1;
        public int IdEmprestimo { get; private set; }
        public Amigo Amigo { get; set; }
        public Revista Revista { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public bool Devolvido { get; set; }
        public Emprestimo()
        {
            IdEmprestimo = _proximoId;
            _proximoId++;
        }
        public void Devolver()
        {
            Devolvido = true;
            DataDevolucao = DateTime.Now;
            Console.WriteLine("Revista devolvida com sucesso!");
        }
    }

}
