
using Business.Abstract;
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
    public class TrainManager:ITrainService
    {
        ITrainDal _trainDal;

        public TrainManager(ITrainDal trainDal)
        {
            _trainDal = trainDal;
        }

        public IDataResult<List<Train>> GetAll()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<Train>>(Messages.ReservationListed);
            }
            return new SuccessDataResult<List<Train>>(_trainDal.GetAll(), Messages.NotReservationListed);
        }
    }
}
