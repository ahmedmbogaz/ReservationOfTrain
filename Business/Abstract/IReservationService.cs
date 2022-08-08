using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReservationService
    {
        //IResult AddDetail(ReservationDetailDto reservationDetailDto);
        //IDataResult<List<ReservationDetailDto>> ReservationDetails();
        IResult Add(ReservationAddDto reservationAddDto);
        IDataResult<List<Reservation>> GetAll();
        //IResult Add(Reservation reservation);
    }
}
