using System.ComponentModel.DataAnnotations;
using WebSalesMvc.Models.Enums;

namespace WebSalesMvc.Models
{
    public class SalesRecord
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} Required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "{0} Required")]
        [Range(0.1, 9999999.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Ammount")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Ammount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
        public int SellerId { get; set; }
        

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double ammount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Ammount = ammount;
            Status = status;
            Seller = seller;
        }
    }
}
