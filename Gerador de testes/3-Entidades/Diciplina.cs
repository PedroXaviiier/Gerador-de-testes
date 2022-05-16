namespace Gerador_de_testes._2_Repositorio
{
    public class Diciplina
    {
        public string Nome;

        public Diciplina(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
