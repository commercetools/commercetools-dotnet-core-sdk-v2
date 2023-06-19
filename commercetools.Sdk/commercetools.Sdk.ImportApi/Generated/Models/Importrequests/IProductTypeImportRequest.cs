using commercetools.Sdk.ImportApi.Models.Producttypes;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductTypeImportRequest))]
    public partial interface IProductTypeImportRequest : IImportRequest
    {
        IList<IProductTypeImport> Resources { get; set; }
        IEnumerable<IProductTypeImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
