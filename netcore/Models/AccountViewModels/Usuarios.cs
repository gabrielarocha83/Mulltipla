using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MulltiplaJML.Models.AccountViewModels
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Usuario")]
        public string Login { get; set; }
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Display(Name = "Empresa")]
        public int CodMatriz { get; set; }
        [Display(Name = "Filial")]
        public int CodFilial { get; set; }
        public int Ativo { get; set; }
     
    }

    public class UsuariosERP
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int CodMatriz { get; set; }
        public int CodFilial { get; set; }
        public int Ativo { get; set; }

    }
}
