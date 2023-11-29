using ScheduleMVC.Context;

namespace ScheduleMVC.Models.Services
{
    public class ContactService
    {
        private readonly ScheduleMvcContext _context;
        public ContactService(ScheduleMvcContext context)
        {
            _context = context;
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.ToList();
        }
    }
}
