using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace infoSys.Models
{
    public class Resume
    {

        [Key]
        [Display(Name = "Resume ID")]
        public int ResumeId { get; set; }

        #region Informação Pessoal

        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Display(Name = "Gender")]
        public String Gender { get; set; }

        [Display(Name = "Address")]
        public String Address { get; set; }

        [Display(Name = "Nationality")]
        public String Nationality { get; set; }

        [Display(Name = "Phone Number")]
        public String Phones { get; set; }

        [Display(Name = "Email Address")]
        public String Email { get; set; }

        [Display(Name = "WebPage")]
        public String Web { get; set; }

        [Display(Name = "Declaration")]
        public String Declaration { get; set; }

        #endregion

        #region Educação e Formação
        public List<Formation> Formations { get; set; }

        #endregion

        #region Experiencia  Profissional
        public List<ProfessionalExperience> Experiences { get; set; }
        #endregion

        #region Projetos
        public List<ProjectResume> Projetos { get; set; }

        #endregion

        #region  Image
        //<summary>Propriedade imageContent representa o conteudo da imagem do projeto</summary>
        //<value>Permite o get e o set desta propriedade.</value>
        [ScaffoldColumn(false)]
        public byte[] imageContent { get; set; }

        //<summary>Propriedade imageMimeType representa o tipo da imagem do projeto</summary>
        //<value>Permite o get e o set desta propriedade.</value>
        [StringLength(256)]
        [ScaffoldColumn(false)]
        public String imageMimeType { get; set; }

        //<summary>Propriedade imageFileName representa o nome da imagem do projeto.</summary>
        //<value>Permite o get e o set desta propriedade.</value>
        [StringLength(100, ErrorMessage = "O nome do ficheiro não pode ser mostrado")]
        [Display(Name = "Nome do Ficheiro")]
        [ScaffoldColumn(false)]
        public String imageFileName { get; set; }

        #endregion


        public Boolean Default { get; set; }


    }
}
