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
    public class EfTrainDal : EfEntityRepositoryBase<Train, TrainContext>, ITrainDal
    {
        //public List<TrainDetailDto> GetTrainDetails()
        //{
        //    using (TrainContext trainContext = new())
        //    {
        //        var result = from t in trainContext.Trains
        //                     join v in trainContext.Vagons
        //                     on t.VagonId equals v.Id
        //                     select new TrainDetailDto
        //                     {
        //                         Id = t.Id,
        //                         TrainName = t.TrainName,
        //                         VagonName = v.VagonName,
        //                         Capacity = v.Capacity,
        //                         Seat = v.Seat
        //                     };
        //        return result.ToList();

        //        //var result = trainContext.Trains.Join
        //        //    (trainContext.Vagons, t => t.VagonId, v => v.Id,
        //        //    (t, v) => new TrainDetailDto
        //        //    {
        //        //        Id = t.Id,
        //        //        TrainName = t.TrainName,
        //        //        VagonName = v.VagonName,
        //        //        Capacity = v.Capacity,
        //        //        Seat = v.Seat
        //        //    });
        //        //return result.ToList();
        //    }
        //}
    }
}
