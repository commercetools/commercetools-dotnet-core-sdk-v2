using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionPagedQueryResponse : IExtensionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IExtension> Results { get; set; }
    }
}
