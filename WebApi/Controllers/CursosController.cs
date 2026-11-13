using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

[Route("api/[controller]")]
[ApiController]
public class CursosController : ControllerBase
{
    private readonly WebApiContext _context;
    public CursosController(WebApiContext context)
    {
        _context = context;
    }

    // GET: api/Curso
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Curso>>> GetCurso()
    {
        return await _context.Curso.ToListAsync();
    }

    // GET: api/Curso/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Curso>> GetCurso(int id)
    {
        var curso = await _context.Curso.FindAsync(id);

        if (curso == null)
        {
            return NotFound();
        }

        return curso;
    }

    // PUT: api/Curso/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCurso(int? id, Curso curso)
    {
        if (id != curso.Id)
        {
            return BadRequest();
        }

        _context.Entry(curso).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CursoExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Curso
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Curso>> PostCurso(Curso curso)
    {
        _context.Curso.Add(curso);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetCurso", new { id = curso.Id }, curso);
    }

    // DELETE: api/Curso/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCurso(int? id)
    {
        var curso = await _context.Curso.FindAsync(id);
        if (curso == null)
        {
            return NotFound();
        }

        _context.Curso.Remove(curso);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool CursoExists(int? id)
    {
        return _context.Curso.Any(e => e.Id == id);
    }
}
