using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class OrderPatchImportRequest : IOrderPatchImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IOrderPatchImport> Patches { get; set; }
        public IEnumerable<IOrderPatchImport> PatchesEnumerable { set => Patches = value.ToList(); }

        public OrderPatchImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("order-patch");
        }
    }
}
