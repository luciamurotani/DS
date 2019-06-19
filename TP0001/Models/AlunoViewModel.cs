using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TP0001.Models
{
    public class AlunoViewModel
    {

        [Required(ErrorMessage = "O nome do aluno é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preenchimento da lista de aluno é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Lista De Amigos")]
        public List<String> Nomes { get; set; }


    }
}
