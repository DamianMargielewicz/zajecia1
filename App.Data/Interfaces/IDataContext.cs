namespace App.Data.Interfaces
{
    public interface IDataContext
    {
        T Find<T>(object id) where T : class;
        T Add<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
    }
}
