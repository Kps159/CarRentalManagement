using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement1.Domain;
using CarRentalManagement1.Data;

namespace CarRentalManagement1.Pages.ModelPages;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Model Model { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var model = await _context.Model.FirstOrDefaultAsync(m => m.Id == id);
        if (model is null)
        {
            return NotFound();
        }
        else
        {
            Model = model;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var model = await _context.Model.FindAsync(id);
        if (model != null)
        {
            Model = model;
            _context.Model.Remove(Model);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
