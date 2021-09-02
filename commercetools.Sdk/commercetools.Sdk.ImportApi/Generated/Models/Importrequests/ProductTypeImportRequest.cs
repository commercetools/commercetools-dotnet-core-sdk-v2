using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importrequests;
using commercetools.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class ProductTypeImportRequest : IProductTypeImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<IProductTypeImport> Resources { get; set; }
        public ProductTypeImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-type");
        }
    }
}
