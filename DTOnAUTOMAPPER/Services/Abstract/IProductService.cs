using DTOnAUTOMAPPER.DTO;
using System.Security.Cryptography.Xml;

namespace DTOnAUTOMAPPER.Services.Abstract;

public interface IProductService
{
    ProductDTO Create(CreateProductDTO product);
    List<ProductDTO> GetProducts();
}