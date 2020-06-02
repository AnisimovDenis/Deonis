using Deonis_lib.Entities.Base;

namespace Deonis_lib.Entities
{
    /// <summary> Билет </summary>
    public class Ticket : NamedEntitie
    {
        public string Article { get; set; }

        public string TypeOfTicket { get; set; }

        public string TypeOfTransport { get; set; }

        public decimal PricePerTrip { get; set; }
    }
}
