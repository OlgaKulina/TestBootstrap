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
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        //редактирование
        Task EditAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> spec);



    }
}