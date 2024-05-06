
using Core.Utilities.Result;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPolygonService
    {
        IDataResult<List<Polygon>> GetAll();
        IDataResult<Polygon> GetById(int id);

        IDataResult<Polygon> GetId(int id);

        IResult Add(Polygon polygon);

        IResult Update(Polygon polygon);

        IResult Delete(Polygon polygon);

        
        
    }
}
