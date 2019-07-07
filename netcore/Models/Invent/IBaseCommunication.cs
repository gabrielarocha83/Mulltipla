using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.Invent
{
    public interface IBaseCommunication
    {
        [Display(Name = "Celular")]
        [StringLength(20)]
        string mobilePhone { get; set; }

        [Display(Name = "Tel. Trabalho")]
        [StringLength(20)]
        string officePhone { get; set; }

        [Display(Name = "Fax")]
        [StringLength(20)]
        string fax { get; set; }

        [Display(Name = "Email Pessoal")]
        [StringLength(50)]
        string personalEmail { get; set; }

        [Display(Name = "Email Trabalho")]
        [StringLength(50)]
        string workEmail { get; set; }

    }
}
