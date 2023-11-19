using Microsoft.EntityFrameworkCore;
using VendasWebMVC.Data;
using VendasWebMVC.Models;

namespace VendasWebMVC.Services
{
    public class DepartamentService
    {
        private readonly VendasWebMVCContext _context;

        public DepartamentService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
