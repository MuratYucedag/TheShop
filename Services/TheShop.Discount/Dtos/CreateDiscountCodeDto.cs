namespace TheShop.Discount.Dtos
{
    public class CreateDiscountCodeDto
    {
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
    }
}
