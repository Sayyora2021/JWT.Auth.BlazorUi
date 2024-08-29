using JWT.Auth.BlazorUi.Models;

namespace JWT.Auth.BlazorUi.Services
{
    public interface IContactService
    {
        Task<List<Contact>> GetContacts();
    }
}
