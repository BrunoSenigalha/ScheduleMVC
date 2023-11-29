namespace ScheduleMVC.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();

        public Address(string postalCode, string country, string state, string city, string neighborhood, string street, int number)
        {
            PostalCode = postalCode;
            Country = country;
            State = state;
            City = city;
            Neighborhood = neighborhood;
            Street = street;
            Number = number;
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
    }
}
