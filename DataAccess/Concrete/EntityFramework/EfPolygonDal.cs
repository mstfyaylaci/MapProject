using Core.DataAccess.EntityFreamework;

using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPolygonDal : EfEntityRepositoryBase<Polygon, MapContext>, IPolygonDal
    {

      
    }
}
