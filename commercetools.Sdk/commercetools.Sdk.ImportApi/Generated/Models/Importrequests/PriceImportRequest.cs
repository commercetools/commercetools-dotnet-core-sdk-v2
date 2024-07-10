using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
