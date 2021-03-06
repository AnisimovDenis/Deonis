﻿using Deonis_lib.Entities.Base;
using Deonis_lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services.InMemory
{
    public abstract class DataStoreInMemory<T> : IDataStore<T> where T : BaseEntity
    {
        private readonly List<T> _Items;

        protected DataStoreInMemory(List<T> Items = null) => _Items = Items ?? new List<T>();

        public IEnumerable<T> GetAll() => _Items;

        public T GetById(int id) => _Items.FirstOrDefault(item => item.Id == id);

        public int Create(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            if (_Items.Contains(item)) return item.Id;
            item.Id = _Items.Count == 0
                ? 1
                : _Items.Max(r => r.Id) + 1;
            _Items.Add(item);
            return item.Id;
        }

        public abstract void Edit(int id, T item);

        public T Remove(int id)
        {
            var item = GetById(id);
            if (item != null)
                _Items.Remove(item);
            return item;
        }

        public void SaveChanges()
        {
            System.Diagnostics.Debug.WriteLine("Сохранение изменений в хранилище {0}.", typeof(T));
        }
    }
}