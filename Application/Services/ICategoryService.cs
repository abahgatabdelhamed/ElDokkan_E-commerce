namespace ELDOKKAN.Application.Services;
public interface ICategoryService
{
    GetAllCategoryDTO GetCategoryById(int categoryId);
    IEnumerable<GetAllCategoryDTO> GetAllCategories();
    GetAllCategoryDTO AddCategory(CreateCategoryDTO createCategoryDto);
    bool UpdateCategory(int categoryId, UpdateCategoryDTO updateCategoryDto);
    bool DeleteCategory(int categoryId);
} 