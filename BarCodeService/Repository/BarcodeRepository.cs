using BarCodeService.DataContext;
using BarCodeService.Dtos;
using BarCodeService.Entities;

namespace BarCodeService.Repository
{
    public class BarcodeRepository : IBarcodeRepository
    {
        private readonly BarcodeContext _context;

        public BarcodeRepository(BarcodeContext context)
        {
            _context = context;
        }

        public void AddBarcode(ProductItemDto model)
        {
            var hash = model.GetHashCode().ToString();
            var item = _context.Barcodes.FirstOrDefault(b => b.Code == hash);
            if (item == null)
            {

            var data = new Barcode
            {
                Code = hash,
                ProductName = model.ProductName,
                TotalPrice = model.Volume * model.Price,
                Volume = model.Volume,
            };
            _context.Barcodes.Add(data);
            _context.SaveChanges();
            }
        }
    }
}
