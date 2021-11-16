using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Products;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class ProductImportRequest : IProductImportRequest
    {
        public IImportResourceType Type { get; set;}
        
        public List<IProductImport> Resources { get; set;}
        public ProductImportRequest()
        { 
           this.Type = IImportResourceType.FindEnum("product");
        }
    }
}
