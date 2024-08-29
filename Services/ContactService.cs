using JWT.Auth.BlazorUi.Models;
using System.Net.Http.Json;


namespace JWT.Auth.BlazorUi.Services
{
    public class ContactService : IContactService
    {
        private readonly HttpClient _httpClient;

        public ContactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Contact>> GetContacts()
        {
         var response= await _httpClient.GetFromJsonAsync<List<Contact>>("/contacts");
            return response;
        }
    }
}
