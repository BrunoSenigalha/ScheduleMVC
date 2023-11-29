namespace ScheduleMVC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }

        public Contact()
        {
        }

        public Contact(string name, string email, string cellphone)
        {
            Name = name;
            Email = email;
            Cellphone = cellphone;
        }
        public Contact(string name, string email, string cellphone, Address address)
        {
            Name = name;
            Email = email;
            Cellphone = cellphone;
            Address = address;
        }
    }
}
