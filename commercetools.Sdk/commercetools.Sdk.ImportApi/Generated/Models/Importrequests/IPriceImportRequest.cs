using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.PriceImportRequest))]
    public partial interface IPriceImportRequest : IImportRequest
    {
        IList<IPriceImport> Resources { get; set; }
        IEnumerable<IPriceImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
