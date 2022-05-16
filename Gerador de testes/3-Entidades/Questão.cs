using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_testes._3_Entidades
{
    public class Questão : Entidade
    {
        public string Enunciado;
        public List<Alternativa> Alternativas;
        public Materia Materia;
        public Serie Serie;

        public Questão(int id, string enunciado, List<Alternativa> alternativas, Materia materia, Serie serie) : base(id)
        {
            Enunciado = enunciado;
            Alternativas = alternativas;
            Materia = materia;
            Serie = serie;
        }
    }
}
