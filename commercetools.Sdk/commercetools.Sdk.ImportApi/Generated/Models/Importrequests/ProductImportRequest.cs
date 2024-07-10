using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductImportRequest : IProductImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductImport> Resources { get; set; }
        public IEnumerable<IProductImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public ProductImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product");
        }
    }
}
