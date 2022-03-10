using Abstraction_Example.Model.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstraction_Example.Model.Entity.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
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
