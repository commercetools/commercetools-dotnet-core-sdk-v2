using commercetools.Sdk.ImportApi.Models.Customers;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CustomerImportRequest))]
    public partial interface ICustomerImportRequest : IImportRequest
    {
        List<ICustomerImport> Resources { get; set; }

    }
}
