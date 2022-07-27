using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Producttypes;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
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
