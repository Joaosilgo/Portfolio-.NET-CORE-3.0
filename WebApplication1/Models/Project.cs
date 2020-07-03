using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace infoSys.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        //public int ProjectId { get; set; }

        [Required(ErrorMessage = "Por Favor insira o Nome do Projeto")]
        [StringLength(20, MinimumLength = 0)]
        public string Name { get; set; }

        // [Required(ErrorMessage = "Por Favor insira uma breve descrição do Projeto")]
        //  [StringLength(100, MinimumLength = 0)]
        public string SmallDescription { get; set; }

        // [Required(ErrorMessage = "Por Favor insira uma descrição do Projeto")]
        //  [StringLength(100000, MinimumLength = 0)]
        public string Description { get; set; }

        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime pushed_at { get; set; }

        [JsonProperty("size")]
        public long size_kb { get; set; }

        // [Required(ErrorMessage = "Por Favor insira uma linguagem do Projeto")]
        [StringLength(100, MinimumLength = 0)]
        public string Language { get; set; }


        [JsonProperty("languages_url")]
        public string Languages { get; set; }

        [JsonProperty("html_url")]
        [Required(ErrorMessage = "Por Favor insira um Link do Projeto")]
        [StringLength(200, MinimumLength = 0)]
        public string Link { get; set; }

        /// <summary>Propriedade imageContent representa o conteudo da imagem do projeto</summary>
        /// <value>Permite o get e o set desta propriedade.</value>
        [ScaffoldColumn(false)]
        public byte[] imageContent { get; set; }

        // <summary>Propriedade imageMimeType representa o tipo da imagem do projeto </summary>
        /// <value>Permite o get e o set desta propriedade.</value>
        [StringLength(256)]
        [ScaffoldColumn(false)]
        public String imageMimeType { get; set; }

        /// <summary>Propriedade imageFileName representa o nome da imagem do projeto.</summary>
        /// <value>Permite o get e o set desta propriedade.</value>
        [StringLength(100, ErrorMessage = "O nome do ficheiro não pode ser mostrado")]
        [Display(Name = "Nome do Ficheiro")]
        [ScaffoldColumn(false)]
        public String imageFileName { get; set; }

        [Display(Name = "Features")]
        public String Features { get; set; }

        [Display(Name = "Project Intent")]
        public String Intent { get; set; }

        [Display(Name = "Project Difficulties")]
        public String Difficulties { get; set; }

        [Display(Name = "Project Solution")]
        public String Solution { get; set; }


        public List<ProjectThumbnails> ProjectThumbnails { get; set; }

        //[BindProperty]
        //public List<String> languageProgramming { get; set; }


        //public void OnGet()
        //{
        //    languageProgramming = new List<String> {
        //"java",
        //".NET"
        //};
        //}







    }
}
