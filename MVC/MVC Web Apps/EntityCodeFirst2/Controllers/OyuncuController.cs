
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityCodeFirst2.Models;

public class OyuncuController : Controller
{
    private readonly OyunDBContext _context;

    public OyuncuController(OyunDBContext context)
    {
        _context = context;
    }

    // GET: OYUNCUS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Oyuncular.ToListAsync());
    }

    // GET: OYUNCUS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var oyuncu = await _context.Oyuncular
            .FirstOrDefaultAsync(m => m.OyuncuID == id);
        if (oyuncu == null)
        {
            return NotFound();
        }

        return View(oyuncu);
    }

    // GET: OYUNCUS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: OYUNCUS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("OyuncuID,OyuncuName,KayitTarihi,NickName,Email,XP")] Oyuncu oyuncu)
    {
        if (ModelState.IsValid)
        {
            _context.Add(oyuncu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(oyuncu);
    }

    // GET: OYUNCUS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var oyuncu = await _context.Oyuncular.FindAsync(id);
        if (oyuncu == null)
        {
            return NotFound();
        }
        return View(oyuncu);
    }

    // POST: OYUNCUS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("OyuncuID,OyuncuName,KayitTarihi,NickName,Email,XP")] Oyuncu oyuncu)
    {
        if (id != oyuncu.OyuncuID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(oyuncu);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OyuncuExists(oyuncu.OyuncuID))
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
        return View(oyuncu);
    }

    // GET: OYUNCUS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var oyuncu = await _context.Oyuncular
            .FirstOrDefaultAsync(m => m.OyuncuID == id);
        if (oyuncu == null)
        {
            return NotFound();
        }

        return View(oyuncu);
    }

    // POST: OYUNCUS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var oyuncu = await _context.Oyuncular.FindAsync(id);
        if (oyuncu != null)
        {
            _context.Oyuncular.Remove(oyuncu);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool OyuncuExists(int? id)
    {
        return _context.Oyuncular.Any(e => e.OyuncuID == id);
    }
}
