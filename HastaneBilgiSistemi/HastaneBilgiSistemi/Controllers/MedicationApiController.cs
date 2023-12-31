using HastaneBilgiSistemi.Data.Model;
using HastaneBilgiSistemi.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class MedicationApiController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public MedicationApiController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetMedications()
    {
        var medications = _context.Medication.ToList();
        return Ok(medications);
    }

    [HttpPost]
    public IActionResult CreateMedication([FromBody] Medication medication)
    {
        if (ModelState.IsValid)
        {
            _context.Add(medication);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMedications), new { id = medication.Id }, medication);
        }
        return BadRequest(ModelState);
    }

    // PUT: api/MedicationApi/5
    [HttpPut("{id}")]
    public IActionResult UpdateMedication(int id, [FromBody] Medication medication)
    {
        if (id != medication.Id)
        {
            return BadRequest();
        }

        _context.Entry(medication).State = EntityState.Modified;

        try
        {
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Medication.Any(e => e.Id == id))
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

    // DELETE: api/MedicationApi/5
    [HttpDelete("{id}")]
    public IActionResult DeleteMedication(int id)
    {
        var medication = _context.Medication.Find(id);
        if (medication == null)
        {
            return NotFound();
        }

        _context.Medication.Remove(medication);
        _context.SaveChanges();

        return NoContent();
    }
}
