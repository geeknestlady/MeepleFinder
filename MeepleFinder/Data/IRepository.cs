﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeepleFinder.Data
{    
   public interface IRepository<T>
   {
      T GetById(int id);
      List<T> GetModels();
      int Save(T model);
      void Delete(int id);
      void Update(T model);
      void DeleteMany(T model);

   }
    
}
