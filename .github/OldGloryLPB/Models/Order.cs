namespace OldGloryLPB.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string OrderName { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string OrderStatus { get; set; }

        public double OrderTotal { get; set; }
    }
}
