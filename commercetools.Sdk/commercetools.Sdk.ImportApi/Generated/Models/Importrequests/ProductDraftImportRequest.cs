using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productdrafts;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class ProductDraftImportRequest : IProductDraftImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<IProductDraftImport> Resources { get; set; }
        public ProductDraftImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-draft");
        }
    }
}
