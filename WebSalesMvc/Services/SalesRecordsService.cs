using WebSalesMvc.Data;
using WebSalesMvc.Models;

namespace WebSalesMvc.Services
{
    public class SalesRecordsService
    {
        private WebSalesMvcContext _context;

        public SalesRecordsService(WebSalesMvcContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(SalesRecord obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
