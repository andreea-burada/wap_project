using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap_Project.Entities
{
    [Serializable]
    public class Room
    {
        public int room_id { get; set; }
        public string room_name { get; set; }
        public int capacity { get; set; }
        public string description { get; set; }
        public string picture_name { get; set; }
        public int price { get; set; }

        public Room()
        {

        }

        public Room(int id, string name, int capacity, string desc, string picName, int price)
        {
            room_id = id;
            room_name = name;
            this.capacity = capacity;
            description = desc;
            picture_name = picName;
            this.price = price;
        }
    }
}
