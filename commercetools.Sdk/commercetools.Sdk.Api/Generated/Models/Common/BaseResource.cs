using System;


namespace commercetools.Api.Models.Common
{
    public partial class BaseResource : IBaseResource
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}
