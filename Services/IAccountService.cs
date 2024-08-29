using JWT.Auth.BlazorUi.Models;

namespace JWT.Auth.BlazorUi.Services
{
    public interface IAccountService
    {
        //Task<Account> GetAccountById(Guid id);
        //Task<Account> CreateAccountAsync(Account newAccount);
        Task<Account> UpdateAccount( Account updAccount);
    }
}
