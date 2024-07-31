using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class PriceImportRequest : IPriceImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IPriceImport> Resources { get; set; }

        public IEnumerable<IPriceImport> ResourcesEnumerable { set => Resources = value.ToList(); }
        public PriceImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("price");
        }
    }
}
