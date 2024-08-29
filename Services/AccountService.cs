using JWT.Auth.BlazorUi.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http.Json;


namespace JWT.Auth.BlazorUi.Services
{
    public class AccountService : IAccountService
    {
        
        private readonly HttpClient _httpClient;
       
              
       

        public async Task<Account> UpdateAccount(Account updatedAccount)
        {
            Guid accountId = updatedAccount.accountid;

            HttpResponseMessage response = await _httpClient.PatchAsJsonAsync<Account>($"updateaccount/{accountId}", updatedAccount);
            if (response.IsSuccessStatusCode)
            {
                // Lire et retourner le compte mis à jour depuis la réponse HTTP
                return await response.Content.ReadFromJsonAsync<Account>();
            }
            else
            {
                throw new Exception($"Failed to update account. Status code: {response.StatusCode}");
            }
        }
   
    }
     
    }

