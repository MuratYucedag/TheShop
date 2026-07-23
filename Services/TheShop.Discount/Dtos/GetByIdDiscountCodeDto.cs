namespace TheShop.Discount.Dtos
{
    public class GetByIdDiscountCodeDto
    {
        public int DiscountCodeId { get; set; }
        public string DiscountCode { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
    }
}
