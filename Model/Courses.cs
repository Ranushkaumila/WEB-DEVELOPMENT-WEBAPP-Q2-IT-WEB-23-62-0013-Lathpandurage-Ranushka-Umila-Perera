using System.ComponentModel.DataAnnotations;

namespace StudentManageApp.Model
{
    public class Courses
    {
        [Key]
        public int Course_ID { get; set; }

        public string Name { get; set; } = "";

        public string Lecturer_Name{ get; set; } ="";
    }
}
