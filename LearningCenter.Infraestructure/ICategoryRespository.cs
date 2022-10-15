namespace LearningCenter.Infraestructure;

public interface ICategoryRespository
{
    List<string> getAll();
    
    string getCategoryById(int id);
    
    bool createCategory(string name);
}