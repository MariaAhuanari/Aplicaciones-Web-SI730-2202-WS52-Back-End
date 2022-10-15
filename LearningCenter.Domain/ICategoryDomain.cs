namespace LearningCenter.Domain;

public interface ICategoryDomain
{
    List<string> getAll();
    string getCategoryById(int id);
    Boolean updateCategory(string name);

    Boolean createCategory(string name);
    Boolean deleteCategoryById(int id);
}