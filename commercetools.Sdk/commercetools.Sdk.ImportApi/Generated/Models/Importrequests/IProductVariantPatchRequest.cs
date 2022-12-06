using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantPatchRequest))]
    public partial interface IProductVariantPatchRequest : IImportRequest
    {
        IList<IProductVariantPatch> Patches { get; set; }
        IEnumerable<IProductVariantPatch> PatchesEnumerable { set => Patches = value.ToList(); }


    }
}
