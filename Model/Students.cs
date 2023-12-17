using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManageApp.Model
{
    public class Students
    {
        [Key]
        [Required]
        public int Student_ID { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public String City { get; set; } = "";

        [Required]
        [ForeignKey("Course")]
        public int Course_ID { get; set; }


    }
}
