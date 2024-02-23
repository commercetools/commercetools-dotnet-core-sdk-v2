using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.StandalonePrices;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class StandalonePriceImportRequest : IStandalonePriceImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IStandalonePriceImport> Resources { get; set; }
        public IEnumerable<IStandalonePriceImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public StandalonePriceImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("standalone-price");
        }
    }
}
