using commercetools.Sdk.ImportApi.Models.ProductSelections;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductSelectionImportRequest))]
    public partial interface IProductSelectionImportRequest : IImportRequest
    {
        IList<IProductSelectionImport> Resources { get; set; }

        IEnumerable<IProductSelectionImport> ResourcesEnumerable { set => Resources = value.ToList(); }

    }
}
