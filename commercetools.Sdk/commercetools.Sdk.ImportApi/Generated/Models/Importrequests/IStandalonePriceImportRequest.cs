using commercetools.Sdk.ImportApi.Models.StandalonePrices;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.StandalonePriceImportRequest))]
    public partial interface IStandalonePriceImportRequest : IImportRequest
    {
        IList<IStandalonePriceImport> Resources { get; set; }
        IEnumerable<IStandalonePriceImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
