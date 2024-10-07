using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Warnings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoring : IProductTailoring
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public IStoreKeyReference Store { get; set; }

        public IProductReference Product { get; set; }

        public bool Published { get; set; }

        public IProductTailoringData Current { get; set; }

        public IProductTailoringData Staged { get; set; }

        public bool HasStagedChanges { get; set; }

        public IList<IWarningObject> Warnings { get; set; }

        public IEnumerable<IWarningObject> WarningsEnumerable { set => Warnings = value.ToList(); }
    }
}
