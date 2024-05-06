using Business.Abstract;
using Business.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PointManager : IPointService
    {
        IPointDal _pointDal;

        public PointManager(IPointDal pointDal)
        {
            _pointDal = pointDal;
        }


        public IResult Add(Point point)
        {
            //kurAL

            _pointDal.Add(point);
            return new SuccessResult(Message.AddedPoint);
        }

        public IResult Delete(Point point)
        {
            _pointDal.Delete(point);
            return new SuccessResult(Message.DeletedPoint);
        }


        public IDataResult<List<Point>> GetAll()
        {
            return new SuccessDataResult<List<Point>>(_pointDal.GetAll(),Message.ListedPoints);
        }

        public IDataResult<Point> GetById(int id)
        {
            return new SuccessDataResult<Point>(_pointDal.Get(p=>p.Id==id),Message.MadePoint);
        }

        public IDataResult<Point> GetId(int id)
        {
            return new SuccessDataResult<Point>(_pointDal.Get(id), Message.MadePoint);
        }

        public IResult Update(Point point)
        {
            _pointDal.Update(point);
            return new SuccessResult(Message.UpdatedPoint);
        }
    }
}
