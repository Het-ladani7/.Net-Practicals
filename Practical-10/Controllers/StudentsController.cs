using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Rahul",
                Course = "Computer Engineering",
                Age = 20
            },
            new Student
            {
                Id = 2,
                Name = "Priya",
                Course = "IT",
                Age = 21
            }
        };

        [HttpGet]
        public ActionResult<List<Student>> GetStudents()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            student.Id = students.Count == 0
                ? 1
                : students.Max(s => s.Id) + 1;

            students.Add(student);

            return CreatedAtAction(
                nameof(GetStudent),
                new { id = student.Id },
                student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            student.Name = updatedStudent.Name;
            student.Course = updatedStudent.Course;
            student.Age = updatedStudent.Age;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            students.Remove(student);

            return NoContent();
        }
    }
}
