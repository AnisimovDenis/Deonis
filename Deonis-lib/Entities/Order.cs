namespace Deonis_lib.Entities
{
    /// <summary> Заказ </summary>
    public class Order
    {
        public int Id { get; set; }

        public string Article { get; set; }

        public string Ticket { get; set; }

        public int NumberOfTrips { get; set; }

        public string Employee { get; set; }

        public decimal Price { get; set; }
    }
}
