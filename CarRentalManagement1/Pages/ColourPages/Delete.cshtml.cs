using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement1.Domain;
using CarRentalManagement1.Data;

namespace CarRentalManagement1.Pages.ColourPages;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Colour Colour { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var colour = await _context.Colour.FirstOrDefaultAsync(m => m.Id == id);
        if (colour is null)
        {
            return NotFound();
        }
        else
        {
            Colour = colour;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var colour = await _context.Colour.FindAsync(id);
        if (colour != null)
        {
            Colour = colour;
            _context.Colour.Remove(Colour);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
