using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Producttypes;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ProductTypeImportRequest : IProductTypeImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IProductTypeImport> Resources { get; set; }
        public IEnumerable<IProductTypeImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public ProductTypeImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("product-type");
        }
    }
}
