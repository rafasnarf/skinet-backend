namespace API.DTOs
{
    public class OrderDTO
    {
        public string BasketId { get; set; }   
        public int DeliveryMethodID { get; set; }
        public AddressDTO ShipToAddress { get; set; }
    }
}