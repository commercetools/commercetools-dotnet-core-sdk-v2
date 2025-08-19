using commercetools.Sdk.ImportApi.Models.BusinessUnits;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.BusinessUnitImportRequest))]
    public partial interface IBusinessUnitImportRequest : IImportRequest
    {
        IList<IBusinessUnitImport> Resources { get; set; }

        IEnumerable<IBusinessUnitImport> ResourcesEnumerable { set => Resources = value.ToList(); }

    }
}
