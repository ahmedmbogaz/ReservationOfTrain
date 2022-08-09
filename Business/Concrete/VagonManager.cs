using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VagonManager
    {
        IVagonDal _vagonDal;

        public VagonManager(IVagonDal vagonDal)
        {
            _vagonDal = vagonDal;
        }

        public IDataResult<List<Vagon>> GetAll()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<Vagon>>(Messages.ReservationListed);
            }
            return new SuccessDataResult<List<Vagon>>(_vagonDal.GetAll(), Messages.NotReservationListed);
        }
    }
}
