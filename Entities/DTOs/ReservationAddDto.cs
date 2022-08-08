using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ReservationAddDto : IEntity
    {
        public int TrainId { get; set; }
        public int VagonId { get; set; }
        public int NumberOfPersonsToReservation { get; set; }
        public bool PersonsCanBePlacedOnDifferentWagons { get; set; }
    }
}
