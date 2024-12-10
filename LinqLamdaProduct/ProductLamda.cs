using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .Threading .Tasks;

namespace LinqLamdaProduct
    {
    internal class ProductLamda
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string CompanyName { get; set; }

        public override string ToString ()
            {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Company: {CompanyName}";
            }
        }
    }
