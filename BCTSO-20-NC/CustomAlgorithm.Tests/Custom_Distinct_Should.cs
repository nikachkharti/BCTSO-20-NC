
namespace CustomAlgorithm.Tests
{
    public class Custom_Distinct_Should
    {
        [Fact]
        public void Find_Unique_Elements_For_Ints()
        {
            //Arrange
            List<int> intList = new() { 22, 22, 22, 71, 4, 3, 2 };

            //Act
            List<int> expectedIntList = new() { 22, 71, 4, 3, 2 };
            var actualIntList = CustomAlgorithms.CustomDistinct(intList).ToList();

            //Assert
            Assert.Equal(expectedIntList, actualIntList);
        }


        [Fact]
        public void Find_Unique_Elements_For_Strings()
        {
            //Arrange
            List<string> stringList = new() { "nika", "nika", "giorgi", "daviti" };

            //Act
            List<string> expectedStringList = new() { "nika", "giorgi", "daviti" };
            var actualStringList = CustomAlgorithms.CustomDistinct(stringList);

            //Assert
            Assert.Equal(expectedStringList, actualStringList);
        }


        [Fact]
        public void Find_Unique_Elements_For_CustomTypes()
        {
            //Arrange
            List<Student> studentList = new()
            {
                new Student("Nika"),
                new Student("Nika"),
                new Student("Nika"),
                new Student("Giorgi"),
                new Student("Daviti")
            };

            //Act
            List<Student> expectedStudentList = new()
            {
                new Student("Nika"),
                new Student("Giorgi"),
                new Student("Daviti")
            };

            var actualStudentList = CustomAlgorithms.CustomDistinct(studentList, new StudentEquilityComparer());

            //Assert
            Assert.Equal(expectedStudentList, actualStudentList, new StudentEquilityComparer());
        }
    }
}
