namespace MyErp.Business.Interfaces;

public interface IGenericRepository<T> where T : class
{
    List<T> GetAll();
    void Create(T obj);
}
