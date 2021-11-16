using commercetools.ImportApi.Models.Prices;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.PriceImportRequest))]
    public partial interface IPriceImportRequest : IImportRequest
    {
        List<IPriceImport> Resources { get; set; }
    }
}
