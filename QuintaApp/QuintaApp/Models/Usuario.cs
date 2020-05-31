using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace QuintaApp.Models
{
    public class Usuario
    {
        //Como o id não é preenchido, ele é considerado 0
        [Range(1,200,ErrorMessage ="O Id deve ser entre 1 e 200")]
        public int UsuId { get; set; }

        [Display(Name ="Nome")]
        [Required (ErrorMessage ="O nome deve ser preenchido")]
        public string UsuNome { get; set; }

        [Display(Name = "Observação")]
        [StringLength(50,MinimumLength =5, ErrorMessage ="O campo deve ter entre 5 e 50 caracteres")]
        public string UsuObs { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "A data deve ser preenchida")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime UsuNasc { get; set; }

        [Display(Name = "E-mail")]
        [RegularExpression(@"^[a-zA-Z] + (([\'\,\.\-][a-zA-Z])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage ="Digite um e-mail válido")]
        public string UsuEmail { get; set; }

        [Display(Name = "Login")]
        [Remote ("ValidaLogin", "Usuario", ErrorMessage ="Este login já existe")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras, entre 5 e 15 caracteres")]
        [Required(ErrorMessage = "O login é obrigatório")]
        public string UsuLogin { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string UsuSenha { get; set; }

        [Display(Name = "Confirme a senha")]
        [Compare("UsuSenha", ErrorMessage ="As senhas são diferentes")]
        public string UsuConfirmaSenha { get; set; }
    }
}