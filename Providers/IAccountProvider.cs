using Microsoft.AspNetCore.Mvc;

namespace TCC.Providers
{
    public interface IAccountProvider
    {
        string GetAccountName(int id);
    }
}
