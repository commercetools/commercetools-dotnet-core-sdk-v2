using commercetools.Sdk.ImportApi.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderImportRequest))]
    public partial interface IOrderImportRequest : IImportRequest
    {
        IList<IOrderImport> Resources { get; set; }

        IEnumerable<IOrderImport> ResourcesEnumerable { set => Resources = value.ToList(); }

    }
}
