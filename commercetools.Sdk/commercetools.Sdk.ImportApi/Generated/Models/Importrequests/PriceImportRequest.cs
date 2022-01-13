using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Prices;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importrequests
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
