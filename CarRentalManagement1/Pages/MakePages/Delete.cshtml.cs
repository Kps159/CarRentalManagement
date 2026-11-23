using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement1.Domain;
using CarRentalManagement1.Data;

namespace CarRentalManagement1.Pages.MakePages;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Make Make { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var make = await _context.Make.FirstOrDefaultAsync(m => m.Id == id);
        if (make is null)
        {
            return NotFound();
        }
        else
        {
            Make = make;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var make = await _context.Make.FindAsync(id);
        if (make != null)
        {
            Make = make;
            _context.Make.Remove(Make);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
