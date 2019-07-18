using System;
using System.Collections.Generic;
using System.Linq;
using XConferenceApp.Models.Interfaces;

namespace XConferenceApp.Repositories
{
    public abstract class OrderableRepositoryBase<T, TKey> : RepositoryBase<T, TKey>
        where TKey : IComparable
        where T : IOrderable, IModel<TKey>
    {
        public override List<T> GetAll()
        {
            return base.GetAll().OrderBy(item => item.Order).ToList();
        }
    }
}