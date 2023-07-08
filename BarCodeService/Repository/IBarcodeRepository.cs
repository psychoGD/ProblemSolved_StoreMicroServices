using BarCodeService.Dtos;

namespace BarCodeService.Repository
{
    public interface IBarcodeRepository
    {
        void AddBarcode(ProductItemDto model);
    }
}
