using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model
{
    public class BaseEntity
    {
        public Guid Id { get => Guid.NewGuid(); }
        private DateTime _createDate = DateTime.Now;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value;}
        }

        public DateTime? UpdateDate { get; set; } 
        public DateTime? DeleteDate { get; set; }


        private Status _status = Status.Active;

        public Status Status
        {
            get => _status;
            set => _status = value;
        }
    }
}
