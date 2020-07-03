using System;
using System.ComponentModel.DataAnnotations;

namespace infoSys.Models
{
    public class Formation
    {
        [Key]
        public int FormationId { get; set; }


        [Display(Name = "Begin Date")]
        [DataType(DataType.Date)]
        public DateTime DateBegin { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }

        [Display(Name = "Formation")]
        public String FormationDesig { get; set; }

        [Display(Name = "Organization")]
        public String FormationOrganization { get; set; }

        [Display(Name = "Skills Acquired")]
        public String FormationSkills { get; set; }


        public int ResumeId { get; set; }
        public Resume Resume { get; set; }



    }
}
