using LearningCenter.Infraestructure;

namespace LearningCenter.Domain;


public class CategoryDomain : ICategoryDomain
{
    private ICategoryRespository _categoryRespository;

    public CategoryDomain(ICategoryRespository categoryRepository)
    {
        _categoryRespository = categoryRepository;
    }
    public List<string> getAll()
    {
        //logica del negocio
        return _categoryRespository.getAll();
    }
    
    public string getCategoryById(int id)
    {
        return "body from Domain v2 " + id.ToString();
    }

    public bool updateCategory(string name)
    {
        return true;
    }
    
    public bool createCategory(string name)
    {
        return true ;
    }
    public bool deleteCategoryById(int id)
    {
        return true;
    }


}