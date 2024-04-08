using WebSalesMvc.Models.Enums;

namespace WebSalesMvc.Models.ViewModel
{
    public class SalesRecordsFormViewModel
    {
        public SalesRecord SalesRecord { get; set; }
        public ICollection<Seller> Sellers { get; set; }
        public SaleStatus SaleStatus { get; set; }
    }
}
