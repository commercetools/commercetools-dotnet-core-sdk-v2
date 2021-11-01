using System.Threading.Tasks;
using commercetools.Api.CheckoutApp.Models;
using commercetools.Api.CheckoutApp.Services;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Mvc;

namespace commercetools.Api.CheckoutApp.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IClient _client;
        protected readonly IUserCredentialsStoreManager _userCredentialsStore;
        protected readonly MeServices _meServices;
        protected readonly CartServices _cartServices;

        public BaseController(IClient client,
            IUserCredentialsStoreManager userCredentialsStore, 
            MeServices meServices,
            CartServices cartServices)
        {
            this._client = client;
            this._userCredentialsStore = userCredentialsStore;
            this._meServices = meServices;
            this._cartServices = cartServices;
        }

        public async Task<CustomerProfileViewModel> GetCurrentCustomerProfile()
        {
            var profileViewModel = new CustomerProfileViewModel();
            var tokenFlow = GetCurrentTokenFlow();
            profileViewModel.ActiveCart = await _cartServices.GetActiveCartViewModel();
            if (tokenFlow == TokenFlow.Password)
            {
                var meProfile = await _meServices.GetMyProfile();
                var baseInfo = new BaseCustomer(meProfile);
                profileViewModel.Customer = baseInfo;
            }

            return profileViewModel;
        }

        /// <summary>
        /// User authenticated if there is username in the cookie
        /// </summary>
        public bool IsUserAuthenticated => GetCurrentTokenFlow() == TokenFlow.Password;
        protected TokenFlow GetCurrentTokenFlow()
        {
            var tokenFlow = TokenFlow.AnonymousSession;
            if (_userCredentialsStore != null && !string.IsNullOrEmpty(_userCredentialsStore.Username))
            {
                tokenFlow = TokenFlow.Password;
            }
            return tokenFlow;
        }
    }
}