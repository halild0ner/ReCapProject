using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _icolordal;

        public ColorManager(IColorDal icolordal)
        {
            this._icolordal = icolordal;
        }

        public List<Color> GetAll()
        {
            return _icolordal.GetAll();
        }
    }
}
