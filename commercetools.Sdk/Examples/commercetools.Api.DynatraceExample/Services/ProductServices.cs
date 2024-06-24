using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Extensions;

namespace commercetools.Api.DynatraceExample.Services
{
    public class ProductServices
    {
        private readonly IClient _client;

        public ProductServices(IClient client)
        {
            _client = client;
        }

        public async Task<List<IProductProjection>> GetAllPublishedProducts()
        {
            var response = await _client
                .WithApi().WithProjectKey(Settings.ProjectKey)
                .ProductProjections()
                .Get()
                .ExecuteAsync();
            return (List<IProductProjection>)response.Results;
        }
    }
}