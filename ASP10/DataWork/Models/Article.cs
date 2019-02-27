using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataWork.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Teg> Tegs { get; set; }
        public Article()
        {
            Tegs = new List<Teg>();
        }
    }
}
