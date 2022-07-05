using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{

    public partial class CustomerGroup : ICustomerGroup
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
