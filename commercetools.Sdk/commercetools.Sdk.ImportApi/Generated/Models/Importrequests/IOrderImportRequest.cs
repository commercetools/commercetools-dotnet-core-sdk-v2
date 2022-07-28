using commercetools.Sdk.ImportApi.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderImportRequest))]
    public partial interface IOrderImportRequest : IImportRequest
    {
        List<IOrderImport> Resources { get; set; }

    }
}
