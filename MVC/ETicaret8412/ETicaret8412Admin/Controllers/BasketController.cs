
using ETicaret8412Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize]
public class BasketController : Controller
{
    private readonly _8412dbContext _context;

    public BasketController(_8412dbContext context)
    {
        _context = context;
    }

    // GET: BASKETS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Baskets.ToListAsync());
    }

    // GET: BASKETS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var basket = await _context.Baskets
            .FirstOrDefaultAsync(m => m.BasketId == id);
        if (basket == null)
        {
            return NotFound();
        }

        return View(basket);
    }

    // GET: BASKETS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: BASKETS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("BasketId,CustomerId,CreateDate,ProductId,UnitPrice,Quantity,Customer,Product")] Basket basket)
    {
        if (ModelState.IsValid)
        {
            _context.Add(basket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(basket);
    }

    // GET: BASKETS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var basket = await _context.Baskets.FindAsync(id);
        if (basket == null)
        {
            return NotFound();
        }
        return View(basket);
    }

    // POST: BASKETS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("BasketId,CustomerId,CreateDate,ProductId,UnitPrice,Quantity,Customer,Product")] Basket basket)
    {
        if (id != basket.BasketId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(basket);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BasketExists(basket.BasketId))
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
        return View(basket);
    }

    // GET: BASKETS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var basket = await _context.Baskets
            .FirstOrDefaultAsync(m => m.BasketId == id);
        if (basket == null)
        {
            return NotFound();
        }

        return View(basket);
    }

    // POST: BASKETS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var basket = await _context.Baskets.FindAsync(id);
        if (basket != null)
        {
            _context.Baskets.Remove(basket);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool BasketExists(int? id)
    {
        return _context.Baskets.Any(e => e.BasketId == id);
    }
}
