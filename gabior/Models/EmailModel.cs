using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormularioContato.Models
{
    public class EmailModel
    {
        [Required(ErrorMessage = "Digite seu nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite seu e-mail.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "E-mail inválido.")]
        public string De { get; set; }

		public string Para { get; set; }

		public string Assunto { get; set; }

		public string Mensagem { get; set; }
	}
}
