using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.CustomObjects
{

    public partial class CustomObjectPagedQueryResponse : ICustomObjectPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<ICustomObject> Results { get; set; }
    }
}
