namespace web3.Controllers
{
    public class Apartment
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int NumberOfRooms { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public ECondition Condition { get; set; }
        public bool Elevator { get; set; }
        public int Floor { get; set; }
        public int IdSOR { get; set; }
        public bool Relevant { get; set; }
        public EForSelOrRent ForSellOrRent { get; set; }
    }

}
