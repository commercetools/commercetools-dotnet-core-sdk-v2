using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Prices;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class PriceImportRequest : IPriceImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<IPriceImport> Resources { get; set; }
        public PriceImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("price");
        }
    }
}
