using Abstraction_Example.Model.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Example.Model.Entity.Concrete
{
    public class Estate:BaseEntity<int>
    {
        public override int Id { get; set; }

        public string PropertyRental { get; set; }

        public string Description { get; set; }

        public string Adress { get; set; }

        public int Price { get; set; }
    }
}
