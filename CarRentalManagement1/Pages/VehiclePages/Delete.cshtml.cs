using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement1.Domain;
using CarRentalManagement1.Data;

namespace CarRentalManagement1.Pages.VehiclePages;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Vehicle Vehicle { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var vehicle = await _context.Vehicle.FirstOrDefaultAsync(m => m.Id == id);
        if (vehicle is null)
        {
            return NotFound();
        }
        else
        {
            Vehicle = vehicle;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var vehicle = await _context.Vehicle.FindAsync(id);
        if (vehicle != null)
        {
            Vehicle = vehicle;
            _context.Vehicle.Remove(Vehicle);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
