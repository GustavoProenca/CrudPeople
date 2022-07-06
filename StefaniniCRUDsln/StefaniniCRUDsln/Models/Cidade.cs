using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StefaniniCRUDsln.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Key]
        public int Id{ get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }


    }
}
