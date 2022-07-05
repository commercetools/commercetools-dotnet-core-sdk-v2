using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customers;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class CustomerImportRequest : ICustomerImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<ICustomerImport> Resources { get; set; }
        public CustomerImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("customer");
        }
    }
}
