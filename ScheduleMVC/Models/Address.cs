namespace ScheduleMVC.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();

        public Address()
        {
        }

        public Address(int postalCode, string country, string state, string city, string street, int number)
        {
            PostalCode = postalCode;
            Country = country;
            State = state;
            City = city;
            Street = street;
            Number = number;
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
    }
}
