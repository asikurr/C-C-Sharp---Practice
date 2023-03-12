using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractAndInheritanceExample
{
    internal class Product
    {
        private string Title { get; set; }
        public uint Price { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public Product(string   title) 
        {
            Title = title;
        }
        public virtual string ShortendDescription()
        {
            if(Description.Length > 30)
                return Description.Substring(0, 30);
            else return Description;
        }
    }
}
