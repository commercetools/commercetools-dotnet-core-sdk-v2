

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreFaqUrlSetMessagePayload : IStoreFaqUrlSetMessagePayload
    {
        public string Type { get; set; }

        public string FaqUrl { get; set; }
        public StoreFaqUrlSetMessagePayload()
        {
            this.Type = "StoreFaqUrlSet";
        }
    }
}
