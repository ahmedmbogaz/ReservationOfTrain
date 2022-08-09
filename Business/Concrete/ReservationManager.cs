using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;
        IVagonDal _vagonDal;

        public ReservationManager(IReservationDal reservationDal, IVagonDal vagonDal)
        {
            _reservationDal = reservationDal;
            _vagonDal = vagonDal;
        }

        public IResult Add(ReservationAddDto reservationAddDto)
        {
            

            Reservation reservation = new Reservation()
            {
                TrainId = reservationAddDto.TrainId,
                VagonId = reservationAddDto.VagonId,
                NumberOfPersonsToReservation = reservationAddDto.NumberOfPersonsToReservation,
                PersonsCanBePlacedOnDifferentWagons = reservationAddDto.PersonsCanBePlacedOnDifferentWagons,
            };


            var result1 = _reservationDal.GetAll();
            var result11 = _vagonDal.GetAll();
            var result5 = result11.Select(x => x.Seat).ToList().Count();
            var result2 = result1.Select(x => x.NumberOfPersonsToReservation).ToList().Count();
            var resultEnd = result5.Equals(result2);


            if (result2 == result5)
            {
                return new ErrorResult(Messages.NotRezervation);
            }
            
            _reservationDal.Add(reservation);
            return new SuccessResult(Messages.ReservationAdded);


        }






        //public IResult Add(Reservation reservation)
        //{
        //    _reservationDal.Add(reservation);
        //    return new SuccessResult(Messages.ReservationAdded);
        //}

        //public IResult AddDetail(ReservationDetailDto reservationDetailDto)
        //{
        //    _reservationDal.Add(reservationDetailDto);
        //    return new SuccessResult(Messages.ReservationAdded);
        //}

        public IDataResult<List<Reservation>> GetAll()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<Reservation>>(Messages.ReservationListed);
            }
            return new SuccessDataResult<List<Reservation>>(_reservationDal.GetAll(), Messages.NotReservationListed);
        }

        //public IDataResult<List<ReservationDetailDto>> ReservationDetails()
        //{
        //    return new SuccessDataResult<List<ReservationDetailDto>>(_reservationDal.ReservationDetails(), Messages.ReservationListed);
        //}
    }
}
