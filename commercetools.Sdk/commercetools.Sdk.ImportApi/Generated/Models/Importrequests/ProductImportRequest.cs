using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importrequests;
using commercetools.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class ProductImportRequest : IProductImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<IProductImport> Resources { get; set; }
        public ProductImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product");
        }
    }
}
