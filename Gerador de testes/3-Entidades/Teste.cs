using Gerador_de_testes._2_Repositorio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_testes._3_Entidades
{
    public class Teste
    {
        public string Titulo;
        public Diciplina Diciplina;
        public Materia Materia;
        public List<Questão> Questões;

        public Teste(string titulo, Diciplina diciplina, Materia materia, List<Questão> questões)
        {
            Titulo = titulo;
            Diciplina = diciplina;
            Materia = materia;
            Questões = questões;
        }


    }
}
