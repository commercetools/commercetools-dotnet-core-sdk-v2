

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreCookiePolicyUrlSetMessagePayload : IStoreCookiePolicyUrlSetMessagePayload
    {
        public string Type { get; set; }

        public string CookiePolicyUrl { get; set; }
        public StoreCookiePolicyUrlSetMessagePayload()
        {
            this.Type = "StoreCookiePolicyUrlSet";
        }
    }
}
