using System;
using System.Collections.Generic;
using System.Linq;
using XConferenceApp.Models.Interfaces;

namespace XConferenceApp.Repositories
{
    public abstract class RepositoryBase<T, TKey>
        where TKey : IComparable
        where T : IModel<TKey>
    {
        protected abstract List<T> items { get; }

        public virtual List<T> GetAll()
        {
            return items.ToList();
        }

        public virtual T GetByKey(TKey key)
        {
            return items.SingleOrDefault(item => item.Id.Equals(key));
        }
    }
}