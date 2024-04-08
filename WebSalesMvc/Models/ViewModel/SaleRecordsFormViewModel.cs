using WebSalesMvc.Models.Enums;

namespace WebSalesMvc.Models.ViewModel
{
    public class SaleRecordsFormViewModel
    {
        public SalesRecord SalesRecord { get; set; }
        public ICollection<Seller> Sellers { get; set; }
    }
}
