namespace web3.Controllers
{
    public class Data
    {

        public static List<sellAndRent> sellAndRentList = new List<sellAndRent>
{
    new sellAndRent
    {
        IdSOR = 200,
        Name = "Shalom Sharabi",
        Phone = "050-1234567",
        Email = "shalom@example.com",
        IdentityNumber = "123456789",
        OwnedApartments = new int[] { 1, 2, 3 } // דוגמה לרשימת דירות
    },
    new sellAndRent
    {
        IdSOR = 201,
        Name = "Shlomo Choen",
        Phone = "050-2345678",
        Email = "shlomo@example.com",
        IdentityNumber = "234567890",
        OwnedApartments = new int[] { 4, 5 } // דוגמה לרשימת דירות
    },
    new sellAndRent
    {
        IdSOR = 202,
        Name = "Chana Brisk",
        Phone = "050-3456789",
        Email = "chana@example.com",
        IdentityNumber = "345678901",
        OwnedApartments = new int[] { 6 } // דוגמה לרשימת דירות
    },
    new sellAndRent
    {
        IdSOR = 203,
        Name = "Yeuda Shteren",
        Phone = "050-4567890",
        Email = "yeuda@example.com",
        IdentityNumber = "456789012",
        OwnedApartments = new int[] { 7, 8, 9 } // דוגמה לרשימת דירות
    }
};
        public static List<Customer> customerList = new List<Customer>
{
    new Customer
    {
        IdC = 100,
        ForSellOrRent = EForSelOrRent.ForSale,
        Name = "Shalom Levi",
        Phone = "0548428236",
        Email = "a@a.com",
        IdentityNumber = "207143214",
        MaxPrice = 2300000,
        MinSize = 60,
        City = "Jerusalem",
        MinFloor = 2,
        MaxFloor = 10,
        MustHaveAnElevator = true
    },
    new Customer
    {
        IdC = 101,
        ForSellOrRent = EForSelOrRent.ForSale,
        Name = "Shlomo Rot",
        Phone = "0548428111",
        Email = "b@b.com",
        IdentityNumber = "207141111",
        MaxPrice = 2300000,
        MinSize = 70,
        City = "Beitar",
        MinFloor = 0,
        MaxFloor = 5,
        MustHaveAnElevator = true
    },
    new Customer
    {
        IdC = 102,
        ForSellOrRent = EForSelOrRent.ForRent,
        Name = "Rachel Bar",
        Phone = "0548428222",
        Email = "c@c.com",
        IdentityNumber = "207144444",
        MaxPrice = 2300,
        MinSize = 30,
        City = "Elad",
        MinFloor = 0,
        MaxFloor = 7,
        MustHaveAnElevator = false
    }
};
        public static List<Apartment> apartmentList = new List<Apartment>
{
    new Apartment
    {
        Id = 300,
        City = "Bneybrak",
        Adress = "A",
        NumberOfRooms = 3,
        Size = 75,
        Price = 1500000,
        Condition = ECondition.Good,
        Elevator = true,
        Floor = 4,
        IdSOR = 200,
        Relevant = true,
        ForSellOrRent = EForSelOrRent.ForRent
    },
    new Apartment
    {
        Id = 301,
        City = "Beitar",
        Adress = "B",
        NumberOfRooms = 4,
        Size = 85,
        Price = 1900000,
        Condition = ECondition.New,
        Elevator = true,
        Floor = 3,
        IdSOR = 202,
        Relevant = true,
        ForSellOrRent = EForSelOrRent.ForRent
    },
    new Apartment
    {
        Id = 302,
        City = "Jerusalem",
        Adress = "C",
        NumberOfRooms = 5,
        Size = 80,
        Price = 3500000,
        Condition = ECondition.Used,
        Elevator = false,
        Floor = 4,
        IdSOR = 200,
        Relevant = true,
        ForSellOrRent = EForSelOrRent.ForRent
    },
    new Apartment
    {
        Id = 303,
        City = "Elad",
        Adress = "D",
        NumberOfRooms = 3,
        Size = 95,
        Price = 1500000,
        Condition = ECondition.Good,
        Elevator = true,
        Floor = 7,
        IdSOR = 201,
        Relevant = false,
        ForSellOrRent = EForSelOrRent.ForSale
    }
};

    }
}
