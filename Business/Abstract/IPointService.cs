using Core.Utilities.Result;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPointService
    {
        IDataResult<List<Point>> GetAll();
        IDataResult<Point> GetById(int id);

        //IDataResult<Point> GetId(int id);

        IResult Add(Point point);

        IResult Update(Point point);

        IResult Delete(Point point);
    }
}
