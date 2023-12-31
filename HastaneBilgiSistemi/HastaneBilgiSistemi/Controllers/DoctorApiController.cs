using Microsoft.AspNetCore.Mvc;
using HastaneBilgiSistemi.Data;
using HastaneBilgiSistemi.Data.Model;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class DoctorApiController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public DoctorApiController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/DoctorApi
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctors()
    {
        return await _context.Doctor.ToListAsync();
    }

    // GET: api/DoctorApi/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Doctor>> GetDoctor(int id)
    {
        var doctor = await _context.Doctor.FindAsync(id);

        if (doctor == null)
        {
            return NotFound();
        }

        return doctor;
    }

    // POST: api/DoctorApi
    [HttpPost]
    public async Task<ActionResult<Doctor>> PostDoctor(Doctor doctor)
    {
        _context.Doctor.Add(doctor);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetDoctor), new { id = doctor.Id }, doctor);
    }

    // PUT: api/DoctorApi/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDoctor(int id, Doctor doctor)
    {
        if (id != doctor.Id)
        {
            return BadRequest();
        }

        _context.Entry(doctor).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DoctorExists(id))
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

    // DELETE: api/DoctorApi/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDoctor(int id)
    {
        var doctor = await _context.Doctor.FindAsync(id);
        if (doctor == null)
        {
            return NotFound();
        }

        _context.Doctor.Remove(doctor);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DoctorExists(int id)
    {
        return _context.Doctor.Any(e => e.Id == id);
    }
}