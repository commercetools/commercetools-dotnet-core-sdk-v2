using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductTypeImportRequest : IProductTypeImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductTypeImport> Resources { get; set; }
        public IEnumerable<IProductTypeImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public ProductTypeImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-type");
        }
    }
}
