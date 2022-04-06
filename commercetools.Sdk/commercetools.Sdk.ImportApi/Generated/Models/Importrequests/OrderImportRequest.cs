using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    public partial class OrderImportRequest : IOrderImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<IOrderImport> Resources { get; set; }
        public OrderImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("order");
        }
    }
}
