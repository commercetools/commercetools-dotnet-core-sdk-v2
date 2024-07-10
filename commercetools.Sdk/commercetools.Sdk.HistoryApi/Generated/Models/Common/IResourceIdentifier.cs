using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ResourceIdentifier))]
    public partial interface IResourceIdentifier
    {
        string Id { get; set; }

        string Key { get; set; }

        IReferenceTypeId TypeId { get; set; }

    }
}
