using commercetools.ImportApi.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.OrderImportRequest))]
    public partial interface IOrderImportRequest : IImportRequest
    {
        List<IOrderImport> Resources { get; set;}
    }
}
