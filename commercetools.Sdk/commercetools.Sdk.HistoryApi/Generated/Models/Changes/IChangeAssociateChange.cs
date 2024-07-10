using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssociateChange))]
    public partial interface IChangeAssociateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAssociate PreviousValue { get; set; }

        IAssociate NextValue { get; set; }

    }
}
