using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace infoSys.Models
{
    public class ProjectThumbnails
    {
        [Key]
        [Display(Name = "Thumbnail ID")]
        public int ProjectThumbnailId { get; set; }

        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "Project Thumbnail Description")]
        public String Description { get; set; }

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

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
