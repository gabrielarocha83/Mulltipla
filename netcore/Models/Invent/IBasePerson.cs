using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.Invent
{
    public interface IBasePerson
    {
        [Display(Name = "Primeiro Nome")]
        [Required]
        [StringLength(20)]
        string firstName { get; set; }

        [Display(Name = "Segundo Nome")]
        [Required]
        [StringLength(20)]
        string lastName { get; set; }

        [Display(Name = "Nome do Meio")]
        [StringLength(20)]
        string middleName { get; set; }

        [Display(Name = "Apelido")]
        [StringLength(20)]
        string nickName { get; set; }

        [Display(Name = "Sexo")]
        Gender gender { get; set; }

        [Display(Name = "Salutation")]
        Salutation salutation { get; set; }
    }


}
