using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customers;
using commercetools.ImportApi.Models.Importrequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
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
