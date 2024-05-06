using Business.Abstract;
using Business.Constant;

using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PolygonManager : IPolygonService
    {
        IPolygonDal _polygonDal;

        public PolygonManager(IPolygonDal polygonDal)
        {
            _polygonDal = polygonDal;
        }


        public IResult Add(Polygon customPolygon)
        {

           
            _polygonDal.Add(customPolygon);
            return new SuccessResult(Message.AddedPolygon);
        }

        public IResult Delete(Polygon polygon)
        {
            _polygonDal.Delete(polygon);
            return new SuccessResult(Message.DeletedPolygon);
        }

        public IDataResult<List<Polygon>> GetAll()
        {
            return new SuccessDataResult<List<Polygon>>(_polygonDal.GetAll(), Message.ListedPolygon);
        }

        

        public IDataResult<Polygon> GetById(int id)
        {
            return new SuccessDataResult<Polygon>(_polygonDal.Get(p => p.Id == id), Message.MadePolygon);
        }

        public IDataResult<Polygon> GetId(int id)
        {
            return new SuccessDataResult<Polygon>(_polygonDal.Get(id), Message.MadePolygon);
        }

        public IResult Update(Polygon polygon)
        {
            _polygonDal.Update(polygon);
            return new SuccessResult(Message.UpdatedPolygon);
        }
    }
}
