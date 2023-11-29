using ScheduleMVC.Context;
using ScheduleMVC.Models;

namespace ScheduleMVC.Data
{
    public class SeedingService
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ScheduleMvcContext>();
                context.Database.EnsureCreated();

                if (context.Contacts.Any()
                    || context.Addresses.Any())
                {
                    return; // Db has been seeded
                }

                Address a1 = new Address(18220000, "Brasil", "SP", "Alambari", "Rua das Flores", 14);
                Address a2 = new Address(19852000, "Brasil", "SP", "Monte Azul", "Avida Hill", 357);
                Address a3 = new Address(15589000, "Brasil", "SP", "Campinas", "Parque dos Ipês", 567);
                Address a4 = new Address(17068000, "Brasil", "SP", "Alambari", "Marechal Deodoro", 1010);
                Address a5 = new Address(49856000, "Brasil", "SE", "Campo do Brito", "Mario Alvares", 60);
                Address a6 = new Address(69985000, "Brasil", "RO", "Iracema", "Rua dos Lirios", 95);

                Contact c1 = new Contact("Mario Santos", "msantos@outlook.com", "1699875-8878", a4);
                Contact c2 = new Contact("Julia Santos", "juju@gmail.com", "1698878-79887", a4);
                Contact c3 = new Contact("Jheniffer Mantovanni", "jhennifer@gmail.com", "1985459-3546", a5);
                Contact c4 = new Contact("Marcio Freitas", "mfreitas@gmail.com", "1898254-7895", a1);
                Contact c5 = new Contact("Bruno Dias", "diasb@gmail.com", "1499885-8988", a3);
                Contact c6 = new Contact("Moacir Salgado", "moacir@gmail.com", "2098987-2134", a6);
                Contact c7 = new Contact("Juliana Janin", "jaki@gmail.com", "169885-2544", a2);

                context.Addresses.AddRangeAsync(a1, a2, a3, a4, a5, a6);

                context.Contacts.AddRangeAsync(c1, c2, c3, c4, c5, c6, c7);

                context.SaveChanges();
            }
        }
    }
}