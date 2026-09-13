
using ETicaret8412Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize]
public class SaleDetailController : Controller
{
    private readonly _8412dbContext _context;

    public SaleDetailController(_8412dbContext context)
    {
        _context = context;
    }

    // GET: SALEDETAILS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.SaleDetails.ToListAsync());
    }

    // GET: SALEDETAILS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var saledetail = await _context.SaleDetails
            .FirstOrDefaultAsync(m => m.SaleDetailId == id);
        if (saledetail == null)
        {
            return NotFound();
        }

        return View(saledetail);
    }

    // GET: SALEDETAILS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: SALEDETAILS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("SaleDetailId,SaleId,ProductId,Quantity,UnitPrice,Product,Sale")] SaleDetail saledetail)
    {
        if (ModelState.IsValid)
        {
            _context.Add(saledetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(saledetail);
    }

    // GET: SALEDETAILS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var saledetail = await _context.SaleDetails.FindAsync(id);
        if (saledetail == null)
        {
            return NotFound();
        }
        return View(saledetail);
    }

    // POST: SALEDETAILS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("SaleDetailId,SaleId,ProductId,Quantity,UnitPrice,Product,Sale")] SaleDetail saledetail)
    {
        if (id != saledetail.SaleDetailId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(saledetail);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleDetailExists(saledetail.SaleDetailId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(saledetail);
    }

    // GET: SALEDETAILS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var saledetail = await _context.SaleDetails
            .FirstOrDefaultAsync(m => m.SaleDetailId == id);
        if (saledetail == null)
        {
            return NotFound();
        }

        return View(saledetail);
    }

    // POST: SALEDETAILS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var saledetail = await _context.SaleDetails.FindAsync(id);
        if (saledetail != null)
        {
            _context.SaleDetails.Remove(saledetail);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool SaleDetailExists(int? id)
    {
        return _context.SaleDetails.Any(e => e.SaleDetailId == id);
    }
}
