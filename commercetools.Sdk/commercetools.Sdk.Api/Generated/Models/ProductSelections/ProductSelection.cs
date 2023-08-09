using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelection : IProductSelection
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public int ProductCount { get; set; }

        public IProductSelectionMode Mode { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
