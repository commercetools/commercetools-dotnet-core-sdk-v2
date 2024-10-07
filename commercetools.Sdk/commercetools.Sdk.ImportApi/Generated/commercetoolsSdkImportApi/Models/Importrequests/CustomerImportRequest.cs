using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customers;
using System.Collections.Generic;
using System.Linq;

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
