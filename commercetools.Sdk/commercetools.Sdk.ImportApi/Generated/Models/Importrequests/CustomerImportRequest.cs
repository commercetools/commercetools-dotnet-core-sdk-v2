using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customers;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class CustomerImportRequest : ICustomerImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<ICustomerImport> Resources { get; set; }
        public IEnumerable<ICustomerImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public CustomerImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("customer");
        }
    }
}
