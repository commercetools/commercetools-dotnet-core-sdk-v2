using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace commercetools.Api.CheckoutApp.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IClient _client;
        protected readonly IAnonymousCredentialsStoreManager _anonymousStoreManager;

        public BaseController(IClient client, IConfiguration configuration)
        {
            this._client = client;
        }
    }
}