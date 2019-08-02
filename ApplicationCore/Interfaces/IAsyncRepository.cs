﻿using Microsoft.DiaryAppOlga.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Microsoft.DiaryAppOlga.ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T:BaseEntity, IAggregateRoot
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        //создание
        Task<T> CreateAsync(T entity);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);        
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> spec);
        //сохранение
        Task SaveAsync(T entity);



    }
}
