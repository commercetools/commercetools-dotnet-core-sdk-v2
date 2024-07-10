using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Productdrafts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductDraftImportRequest : IProductDraftImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductDraftImport> Resources { get; set; }
        public IEnumerable<IProductDraftImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public ProductDraftImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-draft");
        }
    }
}
