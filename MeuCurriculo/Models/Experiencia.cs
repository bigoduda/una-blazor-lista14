using System.Net.Security;
using System.Security.AccessControl;

namespace MeuCurriculo.Models
{
    

    public class Experiencia
    {
        public string Empresa { get; set;}
        public string Cargo { get; set;}
        public string Descricao { get; set;}
        public string Fim { get; set; }
        public string Inicio { get; set;} = "Atual";

    }
}