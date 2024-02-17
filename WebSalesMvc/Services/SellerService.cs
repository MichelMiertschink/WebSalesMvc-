using WebSalesMvc.Models;
using WebSalesMvc.Data;
namespace WebSalesMvc.Services
{
    public class SellerService
    {
        private WebSalesMvcContext _context;

        public SellerService(WebSalesMvcContext context)
        {
            _context = context;
        }

    }
}
