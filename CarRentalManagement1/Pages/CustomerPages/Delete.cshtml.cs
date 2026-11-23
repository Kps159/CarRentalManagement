using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement1.Domain;
using CarRentalManagement1.Data;

namespace CarRentalManagement1.Pages.CustomerPages;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Customer Customer { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var customer = await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);
        if (customer is null)
        {
            return NotFound();
        }
        else
        {
            Customer = customer;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var customer = await _context.Customer.FindAsync(id);
        if (customer != null)
        {
            Customer = customer;
            _context.Customer.Remove(Customer);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
