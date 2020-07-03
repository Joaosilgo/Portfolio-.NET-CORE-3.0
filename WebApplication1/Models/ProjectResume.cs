using System;
using System.ComponentModel.DataAnnotations;

namespace infoSys.Models
{
    public class ProjectResume
    {
        [Key]
        [Display(Name = "Project ID")]
        public int ProjectResumeId { get; set; }

        [Display(Name = "Project Description")]
        public String description { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
