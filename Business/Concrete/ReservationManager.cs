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

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
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

            //var result1 = _reservationDal.GetAll();
            // var result2 = result1.Vagons.Select(x => x.Seat).Count();
            //var result3 = result1.Select(x => x.Vagons.Select(x => x.Seat).ToList().Count());

            //if (result3<5) 
            //{
            //    return new ErrorResult(Messages.NotRezervation);
            //}

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
