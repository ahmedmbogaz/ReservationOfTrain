using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Train : IEntity
    {
        public int Id { get; set; }
        public int VagonId { get; set; }
        public string TrainName { get; set; }
        public ICollection<Vagon> Vagons { get; set; }
        public Reservation Reservations { get; set; }
    }
}
