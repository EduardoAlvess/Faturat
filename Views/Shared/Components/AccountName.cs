using Microsoft.AspNetCore.Mvc;
using TCC.Controllers;
using TCC.Providers;

namespace TCC.Views.Shared.Components
{
    [ViewComponent]
    public class AccountName : ViewComponent
    {
        private readonly IAccountProvider _accountProvider;

        public AccountName(IAccountProvider accountProvider)
        {
            _accountProvider = accountProvider;
        }

        public string Invoke(int id)
        {
            return _accountProvider.GetAccountName(id);
        }
    }
}
