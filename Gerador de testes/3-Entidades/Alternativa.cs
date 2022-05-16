namespace Gerador_de_testes._3_Entidades
{
    public class Alternativa
    {
        public bool Correta;
        public string Descricao;
        public string Letra;

        public Alternativa(bool correta, string descricao, string letra)
        {
            Correta = correta;
            Descricao = descricao;
            Letra = letra;
        }

        public override string ToString()
        {
            return $"Alternativa: {Correta}" +
                $"\n{Letra}) {Descricao}";
        }
    }
}
