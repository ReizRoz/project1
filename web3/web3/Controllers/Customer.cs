namespace web3.Controllers
{
    public class Customer
    {
        public int IdC { get; set; }
        public EForSelOrRent ForSellOrRent { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public int MaxPrice { get; set; }
        public int MinSize { get; set; }
        public string City { get; set; }
        public int MinFloor { get; set; }
        public int MaxFloor { get; set; }
        public bool MustHaveAnElevator { get; set; }
    }
}
