using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importrequests;
using commercetools.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


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
