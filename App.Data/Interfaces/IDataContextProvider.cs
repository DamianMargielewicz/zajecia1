namespace App.Data.Interfaces
{
    public interface IDataContextProvider
    {
        DataContext GetContext();
    }
}