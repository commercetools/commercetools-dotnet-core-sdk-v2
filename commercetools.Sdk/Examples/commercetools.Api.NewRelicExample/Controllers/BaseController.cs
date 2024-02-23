using System.Threading.Tasks;
using commercetools.Api.NewRelicExample.Models;
using commercetools.Api.NewRelicExample.Services;
using commercetools.Base.Client;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Mvc;

namespace commercetools.Api.NewRelicExample.Controllers
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
            var meProfile = await _meServices.GetMyProfile();
            profileViewModel.ActiveCart = await _cartServices.GetActiveCartViewModel();
            if (meProfile != null)
            {
                var baseInfo = new BaseCustomer(meProfile);
                profileViewModel.Customer = baseInfo;
            }

            return profileViewModel;
        }
    }
}