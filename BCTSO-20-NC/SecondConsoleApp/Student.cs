using SecondConsoleApp.CustomAttributes;
using System.ComponentModel.DataAnnotations;

namespace SecondConsoleApp
{
    public class Student
    {
        [MaxLength(5, ErrorMessage = "Test Error Message")]
        public string FirsName { get; set; }

        public DateTime StartClasses { get; set; }

        [ValidDates(nameof(StartClasses))]
        public DateTime EndClasses { get; set; }
    }
}
