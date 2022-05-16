using Gerador_de_testes._3_Entidades;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Gerador_de_testes._2_Repositorio
{
    public class RepositorioBase<T> where T : Entidade
    {
        public string PathJson = $@"C:\Users\phxav\Documents\{typeof(T).Name}.json";
        public List<T> Entidades;
        public int Indice = 0;

        public RepositorioBase()
        {
            if (File.Exists(PathJson))
            {
                string json = File.ReadAllText(PathJson);
                Entidades = JsonConvert.DeserializeObject<List<T>>(json)!;
            }

            else
            {
                Entidades = new List<T>();
            }
        }

        public void RemoverEntidade(T Entidade, int Id)
        {
            Entidades.Remove(Entidade);
        }

        public void AdicionarEntidade(T Entidade)
        {
            Entidades.Add(Entidade);

            Entidade.Id = ++Indice;
        }

        public void SalvarDados()
        {
            string json = JsonConvert.SerializeObject(Entidades, Formatting.Indented);
            File.WriteAllText(PathJson, json);
        }

    }
}
