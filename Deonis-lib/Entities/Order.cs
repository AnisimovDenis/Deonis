using Deonis_lib.Entities.Base;

namespace Deonis_lib.Entities
{
    /// <summary> Заказ </summary>
    public class Order : BaseEntitie
    {
        /// <summary> Артикл заказа </summary>
        public string Article { get; set; }
        /// <summary> Билет заказа </summary>
        public string Ticket { get; set; }
        /// <summary> Количство поездок заказа </summary>
        public int NumberOfTrips { get; set; }
        /// <summary> Сотрудник, который оформлял заказа </summary>
        public string Employee { get; set; }
        /// <summary> Цена заказа </summary>
        public decimal Price { get; set; }
    }
}
