using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ProductVariantImportRequest))]
    public partial interface IProductVariantImportRequest : IImportRequest
    {
        IList<IProductVariantImport> Resources { get; set; }
        IEnumerable<IProductVariantImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
