using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.PriceImportRequest))]
    public partial interface IPriceImportRequest : IImportRequest
    {
        List<IPriceImport> Resources { get; set; }
    }
}
