using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.Products;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api.Extensions;

namespace commercetools.Api.CheckoutApp.Services
{
    public class ProductServices
    {
        private readonly IClient _client;

        public ProductServices(IClient client)
        {
            _client = client;
        }

        public async Task<List<IProduct>> GetAllProducts()
        {
            var response = await _client
                .WithApi().WithProjectKey(Settings.ProjectKey)
                .Products()
                .Get()
                .ExecuteAsync();
            return response.Results;
        }
    }
}