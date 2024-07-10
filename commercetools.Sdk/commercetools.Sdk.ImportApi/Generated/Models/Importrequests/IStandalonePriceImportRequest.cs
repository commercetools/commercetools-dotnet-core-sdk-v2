using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.StandalonePriceImportRequest))]
    public partial interface IStandalonePriceImportRequest : IImportRequest
    {
        IList<IStandalonePriceImport> Resources { get; set; }
        IEnumerable<IStandalonePriceImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
