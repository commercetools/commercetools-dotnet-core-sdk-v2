using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderImportRequest))]
    public partial interface IOrderImportRequest : IImportRequest
    {
        IList<IOrderImport> Resources { get; set; }
        IEnumerable<IOrderImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
