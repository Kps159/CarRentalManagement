using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement1.Domain;
using CarRentalManagement1.Data;

namespace CarRentalManagement1.Pages.BookingPages;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Booking Booking { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var booking = await _context.Booking.FirstOrDefaultAsync(m => m.Id == id);
        if (booking is null)
        {
            return NotFound();
        }
        else
        {
            Booking = booking;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var booking = await _context.Booking.FindAsync(id);
        if (booking != null)
        {
            Booking = booking;
            _context.Booking.Remove(Booking);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
