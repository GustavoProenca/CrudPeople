using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StefaniniCRUDsln.Models
{
    [Table("Pessoa")]
    public class Pessoa
{       
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }        
        public int Id_Cidade { get; set; }
        [ForeignKey("Id_Cidade")]
        [JsonIgnore]
        public Cidade? Cidade { get; set; }

        public int Idade { get; set; }

      

        
    }
}
