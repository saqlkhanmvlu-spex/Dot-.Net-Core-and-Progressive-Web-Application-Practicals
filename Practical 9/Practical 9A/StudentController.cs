using Microsoft.AspNetCore.Mvc;
using Practical_9A.Data;
using Practical_9A.Models;

namespace Practical_9A.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL
        [HttpGet]
        public IActionResult GetResult()
        {
            return Ok(_context.Students.ToList());
        }

        // GET BY ID
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        // INSERT
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return Ok(student);
        }

        // UPDATE
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            var data = _context.Students.Find(id);

            if (data == null)
                return NotFound();

            data.Name = student.Name;
            data.Age = student.Age;
            data.Course = student.Course;

            _context.SaveChanges();

            return Ok(data);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                return NotFound();

            _context.Students.Remove(student);
            _context.SaveChanges();

            return Ok();
        }
    }
}
