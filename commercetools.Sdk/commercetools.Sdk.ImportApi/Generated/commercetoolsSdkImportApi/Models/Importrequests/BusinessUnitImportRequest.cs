using commercetools.Sdk.ImportApi.Models.BusinessUnits;
using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class BusinessUnitImportRequest : IBusinessUnitImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IBusinessUnitImport> Resources { get; set; }

        public IEnumerable<IBusinessUnitImport> ResourcesEnumerable { set => Resources = value.ToList(); }
        public BusinessUnitImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("business-unit");
        }
    }
}
