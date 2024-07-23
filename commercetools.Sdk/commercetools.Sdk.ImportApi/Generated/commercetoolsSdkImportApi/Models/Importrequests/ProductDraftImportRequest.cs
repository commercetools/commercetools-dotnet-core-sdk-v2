using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productdrafts;
using System.Collections.Generic;
using System.Linq;


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
