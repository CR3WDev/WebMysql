using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMysql.Models
{
    public class UsuarioCustomizado
    {
        [Key]
        [Display(Name = "Código ")]
        public int Id { get; set; }

        [Display(Name = "Nome Usuário")]
        public string NomeUsuario { get; set; }

        [Display(Name = "Data Atual")]
        public string DataAtual { get; set; }
    }
}
