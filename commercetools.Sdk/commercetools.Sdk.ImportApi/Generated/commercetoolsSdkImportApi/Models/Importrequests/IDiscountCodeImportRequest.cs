using commercetools.Sdk.ImportApi.Models.DiscountCodes;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.DiscountCodeImportRequest))]
    public partial interface IDiscountCodeImportRequest : IImportRequest
    {
        IList<IDiscountCodeImport> Resources { get; set; }
        IEnumerable<IDiscountCodeImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
