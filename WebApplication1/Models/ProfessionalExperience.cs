using System;
using System.ComponentModel.DataAnnotations;

namespace infoSys.Models
{
    public class ProfessionalExperience
    {
        [Key]
        public int ProfessionalExperienceId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateBegin { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }
        public String Role { get; set; }
        public String Employer { get; set; }
        public String Activities_Responsibilities { get; set; }

        public int ResumeId { get; set; }
        public Resume Resume { get; set; }


    }
}
