using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Vagon : IEntity
    {
        public int Id { get; set; }
        public string VagonName { get; set; }
        public int Capacity { get; set; }
        public int Seat { get; set; }
        public int TrainId { get; set; }

        public Train Train { get; set; }
        public Reservation Reservations { get; set; }
    }
}
