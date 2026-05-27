using commercetools.Sdk.ImportApi.Models.ProductTailorings;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductTailoringImportRequest))]
    public partial interface IProductTailoringImportRequest : IImportRequest
    {
        IList<IProductTailoringImport> Resources { get; set; }

        IEnumerable<IProductTailoringImport> ResourcesEnumerable { set => Resources = value.ToList(); }

    }
}
