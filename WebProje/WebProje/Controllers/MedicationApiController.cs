using HastaneBilgiSistemi.Data.Model;
using HastaneBilgiSistemi.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

    // Diğer CRUD metodlarını ekleyebilirsiniz...
}
