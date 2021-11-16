using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class ProductVariantImportRequest : IProductVariantImportRequest
    {
        public IImportResourceType Type { get; set;}
        
        public List<IProductVariantImport> Resources { get; set;}
        public ProductVariantImportRequest()
        { 
           this.Type = IImportResourceType.FindEnum("product-variant");
        }
    }
}
