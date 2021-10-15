using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.DiscountCodes
{
    public partial class ByProjectKeyDiscountCodesByIDDelete : ApiMethod<ByProjectKeyDiscountCodesByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyDiscountCodesByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/discount-codes/{ID}";
        }

        public List<string> GetDataErasure()
        {
            return this.GetQueryParam("dataErasure");
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyDiscountCodesByIDDelete WithDataErasure(bool dataErasure)
        {
            return this.AddQueryParam("dataErasure", dataErasure.ToString());
        }

        public ByProjectKeyDiscountCodesByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyDiscountCodesByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Api.Models.DiscountCodes.IDiscountCode> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.DiscountCodes.IDiscountCode>(requestMessage);
        }

    }
}
