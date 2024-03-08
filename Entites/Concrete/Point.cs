using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
    public class Point:IEntity
    {
        public int Id { get; set; }
        public string PointName { get; set; }
        public int PointNumber { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
