using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductVariantImportRequest : IProductVariantImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductVariantImport> Resources { get; set; }
        public IEnumerable<IProductVariantImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public ProductVariantImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-variant");
        }
    }
}
