using Core.DataAccess;
using Core.DataAccess.Json;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Json
{
    public class JsPoint : JsonEntityBaseRepository<Point>, IPointDal
    {
       
    }
}
