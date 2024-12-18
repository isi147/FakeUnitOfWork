using ConsoleApp9.Models;

namespace ConsoleApp9.Repository.Abstract;

public interface ICategoryRepository
{

    public void Add(Category product);
    public void Update(int id);
    public void Delete(int id);
    public Category GetById(int id);
    public List<Category> GetAll();
}
