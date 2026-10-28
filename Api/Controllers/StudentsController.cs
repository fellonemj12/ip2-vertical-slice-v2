using Microsoft.AspNetCore.Mvc;
using Application.Common;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IAppDbContext _context;

    public StudentsController(IAppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var students = await _context.Students.ToListAsync();
        return Ok(students);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Domain.Entities.Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync(default);
        return CreatedAtAction(nameof(GetAll), new { id = student.Id }, student);
    }
}