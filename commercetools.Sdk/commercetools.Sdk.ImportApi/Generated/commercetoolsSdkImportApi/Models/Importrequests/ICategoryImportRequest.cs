using commercetools.Sdk.ImportApi.Models.Categories;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CategoryImportRequest))]
    public partial interface ICategoryImportRequest : IImportRequest
    {
        IList<ICategoryImport> Resources { get; set; }

        IEnumerable<ICategoryImport> ResourcesEnumerable { set => Resources = value.ToList(); }

    }
}
