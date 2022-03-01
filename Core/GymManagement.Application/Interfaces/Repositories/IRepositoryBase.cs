﻿using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T :BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);

    }
}