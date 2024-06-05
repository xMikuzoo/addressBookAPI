using addressBookAPI.Entities;

namespace addressBookAPI.Services
{
    public class EntryService
    {

        public Entry GetEntry()
        {
            Entry entry = new Entry();

            entry.Id = 1;
            entry.FirstName = "Dominik";
            entry.LastName = "Podraza";
            entry.Email = "onimod07@gmail.com";
            entry.Telephone = "123 456 789";
            entry.Address = "Boya 17";
            entry.City = "Tarnow";
            entry.PostalCode = "33-100";

            return entry; 
        }
    }
}
