using Microsoft.AspNetCore.Mvc;
using TP1_.Net.Repositories;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TP1_.Net.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _unitOfWork.Students.GetAllAsync();
            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] Student student)
        {
            await _unitOfWork.Students.AddAsync(student);
            await _unitOfWork.CompleteAsync();
            return Ok(student);
        }
    }
}
