using App.Data.Interfaces;
using App.Data.Models;

namespace App.Data
{
using System.Data.Entity;
    public class DataContext : DbContext, IDataContext
    {
        public DataContext()
        {
            
        }

        public DataContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public virtual DbSet<Place> Places{ get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceType> DeviceTypes { get; set; }

        public T Find<T> (object id) where T : class
        {
            return Set<T>().Find(id);
        }

        public T Add<T>(T entity) where T : class
        {
            return Set<T>().Add(entity);
        }

        public void Remove<T>(T entity) where T : class
        {
            Set<T>().Remove(entity);
        }

    }
}
