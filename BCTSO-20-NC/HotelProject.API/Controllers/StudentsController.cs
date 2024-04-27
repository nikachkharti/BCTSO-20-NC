using Microsoft.AspNetCore.Mvc;

namespace HotelProject.API.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        public static List<Student> _students = new List<Student>()
        {
            new Student { Id = 1, FirstName = "ზურაბ", LastName = "დარსაძე"},
            new Student { Id = 2, FirstName = "ლუკა", LastName = "გვაზავა"},
            new Student { Id = 3, FirstName = "ოთარ", LastName = "თაგვიაშვილი"},
            new Student { Id = 4, FirstName = "ნატალია", LastName = "გიორგობიანი"}
        };


        //https://localhost:7194/api/students
        [HttpGet]
        public ActionResult<List<Student>> GetStudents()
        {
            return Ok(_students);
        }


        //https://localhost:7194/api/students

        [HttpPost]
        public ActionResult AddNewStudent([FromBody] Student model)
        {
            if (model is null)
            {
                return BadRequest("Invalid parameter passed");
            }

            var newId = _students.Max(x => x.Id) + 1;
            model.Id = newId;

            _students.Add(model);
            return Created();
        }




        //https://localhost:7194/api/students/1
        [HttpGet("{id:int}")]
        public ActionResult<Student> GetStudentById([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid parameter passed");
            }

            var result = _students.FirstOrDefault(x => x.Id == id);

            if (result == null)
            {
                return NotFound("Data not found");
            }

            return Ok(result);
        }



        //https://localhost:7194/api/students/1
        [HttpDelete("{id:int}")]
        public ActionResult<Student> DeleteStudent([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid parameter passed");
            }

            var result = _students.FirstOrDefault(x => x.Id == id);

            if (result == null)
            {
                return NotFound("Data not found");
            }

            _students.Remove(result);
            return NoContent();
        }



    }




}
