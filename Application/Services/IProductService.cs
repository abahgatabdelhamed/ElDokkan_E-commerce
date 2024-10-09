namespace ELDOKKAN.Application.Services;
public interface IProductService
{
    GetAllProductDTO GetProductById(int ProductId);
    IQueryable<GetAllProductDTO> GetProductByName(string ProductName);
    IEnumerable<GetAllProductDTO> GetAllProducts();
    GetAllProductDTO AddProduct(CreateProductDTO createProductDto);
    bool UpdateProduct(int ProductId, UpdateProductDTO updateProductDto);
    bool DeleteProduct(int ProductId);
} 