using commercetools.Sdk.ImportApi.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductImportRequest))]
    public partial interface IProductImportRequest : IImportRequest
    {
        IList<IProductImport> Resources { get; set; }
        IEnumerable<IProductImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
