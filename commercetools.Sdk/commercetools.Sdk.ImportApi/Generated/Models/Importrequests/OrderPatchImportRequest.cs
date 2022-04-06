using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    public partial class OrderPatchImportRequest : IOrderPatchImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<IOrderPatchImport> Patches { get; set; }
        public OrderPatchImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("order-patch");
        }
    }
}
