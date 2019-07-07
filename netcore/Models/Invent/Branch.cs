using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.Invent
{
    public class Branch: INetcoreBasic, IBaseAddress
    {
        public Branch()
        {
            this.createdAt = DateTime.UtcNow;
            this.isDefaultBranch = false;
        }

        [StringLength(38)]
        [Display(Name = "Filial")]
        public string branchId { get; set; }

        [StringLength(50)]
        [Display(Name = "Filial")]
        [Required]
        public string branchName { get; set; }

        [StringLength(50)]
        [Display(Name = "Descrição")]
        public string description { get; set; }

        [Display(Name = "É Padrão ?")]
        public bool isDefaultBranch { get; set; } = false;

        //IBaseAddress
        [Display(Name = "Endereço 1")]
        [Required]
        [StringLength(50)]
        public string street1 { get; set; }

        [Display(Name = "Endereço 2")]
        [StringLength(50)]
        public string street2 { get; set; }

        [Display(Name = "Cidade")]
        [StringLength(30)]
        public string city { get; set; }

        [Display(Name = "Estado")]
        [StringLength(30)]
        public string province { get; set; }

        [Display(Name = "País")]
        [StringLength(30)]
        public string country { get; set; }

        [Display(Name = "Cnpj")]
        [StringLength(30)]
        public string cnpj { get; set; }


        [Display(Name = "Inscricao Estadual")]
        [StringLength(30)]
        public string inscricaoestadual { get; set; }

        [Display(Name = "Certificado")]
        [StringLength(30)]
        public string patchcertificado { get; set; }

        [Display(Name = "Senha Certificado")]
        [StringLength(30)]
        public string pwcertificado { get; set; }

        

        //IBaseAddress
    }
}
