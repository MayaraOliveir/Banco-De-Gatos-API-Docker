using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BancoDeGatos.Dados.Models
{

    [Table("Gatos")] //Mapeia a classe para tabela Gatos no banco de dados
    public class Gato
    {
        [Key] // define a propriedade id como chave primaria 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }
        public string Dono { get; set; }
        public string Sexo { get; set; }

    }
}