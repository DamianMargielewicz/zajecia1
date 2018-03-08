using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Data.Interfaces;

namespace App.Data
{
    using System;

    public abstract class ActiveRecord<TEntity, TKey> : IDisposable where TEntity : class, new()
    {
        protected readonly IDataContextProvider ContextProvider;
        protected readonly DataContext Context;
        protected TEntity Entity;

        protected ActiveRecord(IDataContextProvider contextProvider)
        {
            ContextProvider = contextProvider;
            Context = contextProvider.GetContext();
        }

        public TKey Id
        {
            get;
            private set;
        }

        public virtual void Delete()
        {
            if (Entity == null)
            {
                throw new InvalidOperationException();
            }

            Context.Remove(Entity);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Load(TKey id)
        {
            Entity = Context.Find<TEntity>(id);

            if (Entity == null)
            {
                throw new InvalidOperationException($"Entity type {typeof(TEntity).FullName} with key {Id} does not exist.");
            }

            Id = id;
        }

        public virtual void Save()
        {
            OnSaving();

            Context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context?.Dispose();
            }
        }

        protected abstract TKey OnCreateKey(TEntity entity);

        protected virtual void OnSaving()
        {
            if (Entity == null)
            {
                Entity = new TEntity();

                Id = OnCreateKey(Entity);

                Context.Add(Entity);
            }
        }
    }
}

