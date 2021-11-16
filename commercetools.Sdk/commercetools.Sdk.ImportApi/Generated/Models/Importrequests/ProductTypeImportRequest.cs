using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Producttypes;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class ProductTypeImportRequest : IProductTypeImportRequest
    {
        public IImportResourceType Type { get; set;}
        
        public List<IProductTypeImport> Resources { get; set;}
        public ProductTypeImportRequest()
        { 
           this.Type = IImportResourceType.FindEnum("product-type");
        }
    }
}
