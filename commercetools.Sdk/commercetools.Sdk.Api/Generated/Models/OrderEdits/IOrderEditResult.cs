using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditResult))]
    [SubTypeDiscriminator("Applied", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditApplied))]
    [SubTypeDiscriminator("NotProcessed", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditNotProcessed))]
    [SubTypeDiscriminator("PreviewFailure", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewFailure))]
    [SubTypeDiscriminator("PreviewSuccess", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewSuccess))]
    public partial interface IOrderEditResult
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditApplied Applied(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditApplied> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditApplied();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditNotProcessed NotProcessed(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditNotProcessed> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditNotProcessed();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewFailure PreviewFailure(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewFailure> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewFailure();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewSuccess PreviewSuccess(Action<commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewSuccess> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewSuccess();
            init?.Invoke(t);
            return t;
        }
    }
}
