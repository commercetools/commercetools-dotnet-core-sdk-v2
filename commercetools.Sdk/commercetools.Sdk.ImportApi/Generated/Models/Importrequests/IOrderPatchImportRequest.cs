using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderPatchImportRequest))]
    public partial interface IOrderPatchImportRequest : IImportRequest
    {
        IList<IOrderPatchImport> Patches { get; set; }
        IEnumerable<IOrderPatchImport> PatchesEnumerable { set => Patches = value.ToList(); }


    }
}
