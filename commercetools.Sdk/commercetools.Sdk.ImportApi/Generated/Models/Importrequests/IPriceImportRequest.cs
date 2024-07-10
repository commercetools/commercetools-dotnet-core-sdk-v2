using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.PriceImportRequest))]
    public partial interface IPriceImportRequest : IImportRequest
    {
        IList<IPriceImport> Resources { get; set; }
        IEnumerable<IPriceImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
