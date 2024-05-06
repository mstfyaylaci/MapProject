using Core.Entities.Abstract;


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entites.Concrete
{
   
    public class Polygon : IEntity
    {
        public int Id { get; set; }
        public string PolygonName { get; set; }
        

        public string Wkt { get; set; }

       
    }

}
