using commercetools.Sdk.ImportApi.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CustomerImportRequest))]
    public partial interface ICustomerImportRequest : IImportRequest
    {
        IList<ICustomerImport> Resources { get; set; }

        IEnumerable<ICustomerImport> ResourcesEnumerable { set => Resources = value.ToList(); }

    }
}
