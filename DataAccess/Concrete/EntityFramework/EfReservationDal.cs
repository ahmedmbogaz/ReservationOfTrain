using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfReservationDal : EfEntityRepositoryBase<Reservation, TrainContext>, IReservationDal
    {

        //public List<ReservationDetailDto> ReservationDetails()
        //{
        //    using (TrainContext trainContext = new())
        //    {
        //        var result = from r in trainContext.Reservations
        //                     join v in trainContext.Vagons
        //                     on r.VagonId equals v.Id
        //                     join t in trainContext.Trains
        //                     on r.TrainId equals t.Id
        //                     select new ReservationDetailDto
        //                     {
        //                         Id = r.Id,
        //                         TrainName=t.TrainName,
        //                         VagonName=v.VagonName,
        //                         NumberOfPersonsToReservation=r.NumberOfPersonsToReservation,
        //                         PersonsCanBePlacedOnDifferentWagons=r.PersonsCanBePlacedOnDifferentWagons,
        //                     };
        //        return result.ToList();
        //    }
        //}
    }
}
