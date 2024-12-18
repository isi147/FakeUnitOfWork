using ConsoleApp9.Models;

namespace ConsoleApp9.Repository.Abstract;

public interface IProductRepository
{
    public void Add(Product product);
    public void Update(int id);
    public void Delete(int id);
    public Product GetById(int id);
    public List<Product> GetAll();
}
