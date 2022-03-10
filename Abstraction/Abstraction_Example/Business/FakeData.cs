using Abstraction_Example.Model.Entity.Concrete;
using Abstraction_Example.Model.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Example.Business
{
    public static class FakeData
    {
        public static List<Estate> estates = new List<Estate>()
        {
            new Estate {Id = 1, PropertyRental = "Home", Description = "2+1", Adress = "Beylikdüzü",Price = 2500, UpdateDate = null, DeleteDate = null},
            new Estate {Id = 2, PropertyRental = "Home", Description = "3+1", Adress = "Beylikdüzü", Price =3500, UpdateDate = null, DeleteDate = null},
            new Estate {Id = 3, PropertyRental = "Shop", Description = "100 m2", Adress = "Beylikdüzü", Price = 5000, UpdateDate = null, DeleteDate = null},
            new Estate {Id = 4, PropertyRental = "Shop", Description = "250 m2", Adress = "Beylikdüzü", Price = 10000, UpdateDate = null, DeleteDate =null}
        };
    }
}
