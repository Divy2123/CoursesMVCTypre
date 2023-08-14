using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CoursesMVCTypre.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public String? Title { get; set; }

        [DataType(DataType.Date)]
        [Display (Name = "Join Date")]
        public DateTime JoinDate { get; set; }
        public String? Gender { get; set; }

        public decimal Rating { get; set; }
    }
}
