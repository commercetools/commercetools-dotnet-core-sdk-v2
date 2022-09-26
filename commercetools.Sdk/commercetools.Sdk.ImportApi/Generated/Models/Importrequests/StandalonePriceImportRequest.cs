using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.StandalonePrices;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class StandalonePriceImportRequest : IStandalonePriceImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<IStandalonePriceImport> Resources { get; set; }
        public StandalonePriceImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("standalone-price");
        }
    }
}
