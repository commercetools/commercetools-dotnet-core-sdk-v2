using commercetools.Sdk.ImportApi.Models.StandalonePrices;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.StandalonePriceImportRequest))]
    public partial interface IStandalonePriceImportRequest : IImportRequest
    {
        List<IStandalonePriceImport> Resources { get; set; }

    }
}
