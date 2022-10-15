namespace LearningCenter.Infraestructure;

public class CategoryRepository :ICategoryRespository
{
    public List<string> getAll()
    {
        //conectar a la base de datos o api o file donde se encuentren los datos
        return new List<string>(){ "value1 repository", "value2 repository" };

       // new Tutorial().;
    }

    public string getCategoryById(int id)
    {
        throw new NotImplementedException();
    }

    public bool createCategory(string name)
    {
        throw new NotImplementedException();
    }
}