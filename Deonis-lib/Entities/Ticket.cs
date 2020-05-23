namespace Deonis_lib.Entities
{
    /// <summary> Билет </summary>
    public class Ticket
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Article { get; set; }

        public string TypeOfTicket { get; set; }

        public string TypeOfTransport { get; set; }

        public decimal PricePerTrip { get; set; }
    }
}
