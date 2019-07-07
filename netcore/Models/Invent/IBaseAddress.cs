using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.Invent
{
    public interface IBaseAddress
    {
        [Display(Name = "Endereco Rua 1")]
        [Required]
        [StringLength(50)]
        string street1 { get; set; }

        [Display(Name = "Endereco Rua 2")]
        [StringLength(50)]
        string street2 { get; set; }

        [Display(Name = "Cidade")]
        [StringLength(30)]
        string city { get; set; }

        [Display(Name = "Estado")]
        [StringLength(30)]
        string province { get; set; }

        [Display(Name = "País")]
        [StringLength(30)]
        string country { get; set; }
    }
}
