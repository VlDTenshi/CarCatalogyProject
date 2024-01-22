namespace CarCatalogyProject.Models
{
    public class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>() 
        {
        new Category{ CategoryId = 1, CategoryName = "Passenger_car", Description = "Passenger car"},
        new Category{ CategoryId = 1, CategoryName = "Trucks_and_SUVs", Description = "Trucks and SUV"},
        new Category{ CategoryId = 1, CategoryName = "Sports_Car", Description = "Sport Car"},
        };
        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(c => c.CategoryId);
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        }
        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                };
            }
            return null;
        }
        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId) return;
            var categoryToUpdate = _categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
                categoryToUpdate.Description = category.Description;
            }
        }
        public static void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if(category != null)
            {
                _categories.Remove(category);
            }
        }
    } 
}
