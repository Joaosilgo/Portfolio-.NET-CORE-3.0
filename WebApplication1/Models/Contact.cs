using System.ComponentModel.DataAnnotations;

namespace infoSys.Models
{
    public class Contact
    {

        /// <summary>Propriedade Name representa o nome do remetente do email.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required(ErrorMessage = "Por Favor insira o seu Nome")]
        [StringLength(20, MinimumLength = 0)]
        public string Name { get; set; }

        /// <summary>Propriedade Email representa o email do remetente.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required(ErrorMessage = "Por Favor insira um Email válido")]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>Propriedade Subject representa o assunto do email.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required(ErrorMessage = "Selecione um assunto")]
        public string Subject { get; set; }

        /// <summary>Propriedade Message representa a menssagem do email.</summary>
        /// <value>Permite o get e o set desta propriedade. Não poderá ser null na base de dados.</value>
        [Required(ErrorMessage = "Say Something")]
        public string Message { get; set; }
    }
}
