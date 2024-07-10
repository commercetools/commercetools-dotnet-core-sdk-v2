using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.DiscountCodes;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class DiscountCodeImportRequest : IDiscountCodeImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IDiscountCodeImport> Resources { get; set; }
        public IEnumerable<IDiscountCodeImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public DiscountCodeImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("discount-code");
        }
    }
}
