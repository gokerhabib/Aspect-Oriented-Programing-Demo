using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace AOP.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
