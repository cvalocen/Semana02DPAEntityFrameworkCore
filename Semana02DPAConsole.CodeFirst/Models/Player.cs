using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semana02DPAConsole.CodeFirst.Models
{
    [Table ("Player")]
    public class Player //clase con dos atributos
    {
        [Key]
        //prop tab tab
        public int Id { get; set; }
        [Column (TypeName = "nvarchar(100)")]
        public string FullName { get; set; }



    }
}
