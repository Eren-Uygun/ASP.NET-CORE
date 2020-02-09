using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCRUD_Operation.DAL.ORM.Entity
{
    public enum Status
    {
        None=0,
        Active = 1,
        Modified = 2,
        Passive = 3
    }
    public class BaseEntity
    {
        public int ID { get; set; }
        private DateTime _addedDate = DateTime.Now;

        public DateTime AddedDate
        {
            get { return _addedDate; }
            set { _addedDate = value; }
        }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? RemovedDate { get; set; }
        private Status _status = Status.Active;

        public Status Status 
        {
            get {return _status; }
            set {_status = value; } 
        }
    }
}
