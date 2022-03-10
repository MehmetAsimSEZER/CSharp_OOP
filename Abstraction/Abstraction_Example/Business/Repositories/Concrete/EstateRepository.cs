using Abstraction_Example.Business.Repositories.Abstract;
using Abstraction_Example.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction_Example.Model.Entity.Enums;
using System.Windows.Forms;

namespace Abstraction_Example.Business.Repositories.Concrete
{
    public class EstateRepository : BaseRepository<Estate>
    {
        public override void Create(Estate entity)
        {
            FakeData.estates.Add(entity);
        }

        public override void Delete(Estate entity)
        {
            entity.DeleteDate = DateTime.Now;
            entity.Status = Status.Passive;
            //FakeData.estates.Remove(entity);
        }

        public override List<Estate> GetAll()
        {
            var estateList = FakeData.estates.ToList();
            return estateList;
        }

        public override Estate GetById(int id)
        {
            Estate estate = new Estate();

            foreach (Estate estate1 in FakeData.estates)
            {
                if (estate1.Id == id)
                {
                    estate = estate1;
                }
            }
            return estate;
        }


        public override void Update(Estate entity)
        {
            Estate estate = GetById(entity.Id);

            estate.PropertyRental = entity.PropertyRental;
            estate.Description = entity.Description;
            estate.Adress = entity.Adress;
            estate.Price = entity.Price;
            estate.Status = Status.Modified;
            estate.UpdateDate = DateTime.Now;
       

        }

        public void GetByRental(ComboBox comboBox)
        {
            comboBox.Items.AddRange(Enum.GetNames(typeof(PropertyRental)));
            comboBox.SelectedIndex = -1;
        }


        public override List<Estate> GetByDescription(string desc)
        {
            List<Estate> estates = new List<Estate>();

            foreach (Estate estate in FakeData.estates)
            {
                if (estate.Description == desc)
                {
                    estates.Add(estate);
                }
            }
            return estates;

        }

        public override List<Estate> GetByProperty(string comboBox)
        {
            List<Estate> estates = new List<Estate>();

            foreach (Estate estate in FakeData.estates)
            {
                if (estate.PropertyRental == comboBox)
                {
                    estates.Add(estate);
                }
            }
            return estates;
        }


        public override Estate GetByPrice(int id)
        {
            Estate estate = FakeData.estates.FirstOrDefault(p => p.Price == id);
            return estate;
        }
    }
}
