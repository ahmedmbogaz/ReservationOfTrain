using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public int VagonId { get; set; }
        public int TrainId { get; set; }
        public int? NumberOfPersonsToReservation { get; set; }
        public bool PersonsCanBePlacedOnDifferentWagons { get; set; }

        public ICollection<Vagon> Vagons { get; set; }
        public ICollection<Train> Trains { get; set; }
    }
}
