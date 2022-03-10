using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction_Example.Business.Repositories.Abstract
{
    public abstract class BaseRepository<T>
    {
        public abstract void Create(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
        public abstract T GetById (int id);
        public abstract List<T> GetAll();
        public abstract List<T> GetByDescription(string desc);

        public abstract List<T> GetByProperty(string comboBox);

        public abstract T GetByPrice(int id);


    }
}
