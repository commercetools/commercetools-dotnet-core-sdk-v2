using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.DiscountCodes;
using System.Collections.Generic;
using System.Linq;


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
