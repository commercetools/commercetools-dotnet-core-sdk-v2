using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Products;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
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
