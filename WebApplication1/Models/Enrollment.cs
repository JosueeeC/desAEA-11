namespace WebApplication1.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public DateTime DateTime { get; set; }


        //Student
        public int StudentID { get; set; }
        public Student? Student { get; set; }

        //Course
        public int CourseID { get; set; }
        public Course? Course { get; set;}
    }
}
