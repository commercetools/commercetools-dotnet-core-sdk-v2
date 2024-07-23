using commercetools.Sdk.Api.Models.Common;
using System;


namespace commercetools.Sdk.Api.Models.CustomObjects
{

    public partial class CustomObject : ICustomObject
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Container { get; set; }

        public string Key { get; set; }

        public Object Value { get; set; }
    }
}
