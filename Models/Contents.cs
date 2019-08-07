using System.Collections.Generic;

namespace Restaraunt.Models
{
    public class Contents
    {
        public Contents()
        {
            this.Cuisine = new HashSet<Item>();
        }

        public int ContentsId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Item> Items { get; set; }//Possibly replace Item with cuisine
        public int CuisineId { get; set; }
    }
}
//Item will be cuisine