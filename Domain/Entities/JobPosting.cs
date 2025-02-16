using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobPosting : BaseEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        [Required(ErrorMessage ="El campo de descripción es requerido")]
        public string Description { get; set; }
        [Required(ErrorMessage = "El campo de Como aplicar es requerido")]
        public string HowToApply { get; set; }
        public string Location { get; set; }
        public ExperienceLevel Level { get; set; }
        public ContractType Type { get; set; }
        public CommuteType Commute { get; set; }
        public Currency Currency { get; set; }
        public SalaryType SalaryType { get; set; }
        public Decimal? Salary { get; set; }
        public bool IsSalaryRanged { get;set; }
        public bool PostAsAnonymous { get; set; }
        public Decimal? MinSalary { get; set; }
        public Decimal? MaxSalary { get; set; }
        public virtual Company Company { get; set; }
    }

    public enum SalaryType
    {
        Monthly = 0,
        Hourly,
        Yearly
    }

    public enum CommuteType
    {
        Remote = 0,
        Onsite,
        Hybrid,
    }

    public enum ContractType
    {
        FullTime = 0,
        PartTime,
        Contract,
        Internship,
    }
    public enum ExperienceLevel
    {
        Senior = 0,
        Mid,
        Junior,
    }

    public enum Currency
    {
        USD = 0,
        EUR,
        DOP
    }
}
