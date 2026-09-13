
using ETicaret8412Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize]
public class SaleController : Controller
{
    private readonly _8412dbContext _context;

    public SaleController(_8412dbContext context)
    {
        _context = context;
    }

    // GET: SALES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Sales.ToListAsync());
    }

    // GET: SALES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var sale = await _context.Sales
            .FirstOrDefaultAsync(m => m.SaleId == id);
        if (sale == null)
        {
            return NotFound();
        }

        return View(sale);
    }

    // GET: SALES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: SALES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("SaleId,SaleDate,CustomerId,Customer,SaleDetails")] Sale sale)
    {
        if (ModelState.IsValid)
        {
            _context.Add(sale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(sale);
    }

    // GET: SALES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var sale = await _context.Sales.FindAsync(id);
        if (sale == null)
        {
            return NotFound();
        }
        return View(sale);
    }

    // POST: SALES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("SaleId,SaleDate,CustomerId,Customer,SaleDetails")] Sale sale)
    {
        if (id != sale.SaleId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(sale);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleExists(sale.SaleId))
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
        return View(sale);
    }

    // GET: SALES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var sale = await _context.Sales
            .FirstOrDefaultAsync(m => m.SaleId == id);
        if (sale == null)
        {
            return NotFound();
        }

        return View(sale);
    }

    // POST: SALES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var sale = await _context.Sales.FindAsync(id);
        if (sale != null)
        {
            _context.Sales.Remove(sale);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool SaleExists(int? id)
    {
        return _context.Sales.Any(e => e.SaleId == id);
    }
}
