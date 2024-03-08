using Core.DataAccess.EntityFreamework;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPointDal : EfEntityRepositoryBase<Point, MapContext>, IPointDal
    {
        
    }
}
