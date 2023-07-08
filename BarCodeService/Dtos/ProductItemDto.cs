namespace BarCodeService.Dtos
{
    public class ProductItemDto
    {
        public int ProductId { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public string? ProductName { get; set; }

        public override int GetHashCode()
        {
            return $"{ProductId}-{Volume}-{ProductName}-{Price}".GetHashCode();
        }
    }//1234567890
}
