using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{

    public partial class OrderPatchImport : IOrderPatchImport
    {
        public string OrderNumber { get; set; }

        public IOrderField Fields { get; set; }
    }
}
