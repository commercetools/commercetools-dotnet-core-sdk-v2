using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessage))]
    public partial interface IReviewStateTransitionMessage : IMessage
    {
        IStateReference OldState { get; set; }

        IStateReference NewState { get; set; }

        bool OldIncludedInStatistics { get; set; }

        bool NewIncludedInStatistics { get; set; }

        IReference Target { get; set; }

        bool Force { get; set; }

    }
}
