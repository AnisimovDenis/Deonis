using Deonis_lib.Entities.Base;

namespace Deonis_lib.Entities
{
    /// <summary> Билет </summary>
    public class Ticket : NamedEntity
    {
        /// <summary> Артикл билета </summary>
        public string Article { get; set; }
        /// <summary> Тип билета </summary>
        public string TypeOfTicket { get; set; }
        /// <summary> Артикл транспорта </summary>
        public string TypeOfTransport { get; set; }
        /// <summary> Цена за одну поездку </summary>
        public decimal PricePerTrip { get; set; }
    }
}
