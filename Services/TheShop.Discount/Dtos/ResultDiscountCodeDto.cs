namespace TheShop.Discount.Dtos
{
    public class ResultDiscountCodeDto
    {
        public int DiscountCodeId { get; set; }
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
    }
}