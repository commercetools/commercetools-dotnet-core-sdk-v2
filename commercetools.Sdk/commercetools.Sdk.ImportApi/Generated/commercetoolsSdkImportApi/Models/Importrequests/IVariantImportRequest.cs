using commercetools.Sdk.ImportApi.Models.Variants;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.VariantImportRequest))]
    public partial interface IVariantImportRequest : IImportRequest
    {
        IList<IVariantImport> Resources { get; set; }

        IEnumerable<IVariantImport> ResourcesEnumerable { set => Resources = value.ToList(); }

    }
}
