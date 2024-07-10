using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class OrderImportRequest : IOrderImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IOrderImport> Resources { get; set; }
        public IEnumerable<IOrderImport> ResourcesEnumerable { set => Resources = value.ToList(); }

        public OrderImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("order");
        }
    }
}
