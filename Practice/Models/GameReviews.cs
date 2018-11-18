using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace Practice.Models
{
    public class GameReview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public List<string> Pictures { get; set; }
        public int Stars { get; set; }
        public string MainPicture
        {
            get
            {
                return Name.ToLower().Replace(" ", "").Replace("'", "").Replace(".", "") + ".jpg";
            }
        }
    }
}
