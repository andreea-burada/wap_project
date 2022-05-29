using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap_Project.Entities
{
    [Serializable]
    public class Booking : IComparable<Booking>
    {
        public Guid id { get; set; }
        public Guid client_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; } 
        public int room_id { get; set; }

        public Booking() { }

        public Booking(Guid cid, DateTime startd, DateTime endd, int rid)
        {
            id = Guid.NewGuid();
            client_id = cid;
            start_date = startd;
            end_date = endd;
            room_id = rid;
        }

        public int CompareTo(Booking other)
        {
            return start_date.CompareTo(other.start_date);
        }
    }
}
