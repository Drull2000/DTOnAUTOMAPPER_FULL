using AutoMapper;
using DTOnAUTOMAPPER.DataBase;
using DTOnAUTOMAPPER.DTO;
using DTOnAUTOMAPPER.Services.Abstract;

namespace DTOnAUTOMAPPER.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private static readonly List<Product> _database = new();

        public ProductService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ProductDTO Create(CreateProductDTO product)
        {
            var newProduct = _mapper.Map<Product>(product);
            _database.Add(newProduct);
            return _mapper.Map<ProductDTO>(newProduct);
        }

        public List<ProductDTO> GetProducts()
        {
            var activeProducts = _database.Where(p => !p.IsDeleted);
            return _mapper.Map<List<ProductDTO>>(activeProducts);
        }
    }
}