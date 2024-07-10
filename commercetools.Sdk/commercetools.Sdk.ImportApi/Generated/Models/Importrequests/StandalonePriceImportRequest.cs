using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
