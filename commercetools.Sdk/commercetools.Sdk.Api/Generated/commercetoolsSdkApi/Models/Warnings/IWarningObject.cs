using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Warnings
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Warnings.WarningObject))]
    [SubTypeDiscriminator("ImageProcessingOngoing", typeof(commercetools.Sdk.Api.Models.Warnings.ImageProcessingOngoingWarning))]
    public partial interface IWarningObject
    {
        string Code { get; set; }

        string Message { get; set; }

        static commercetools.Sdk.Api.Models.Warnings.ImageProcessingOngoingWarning ImageProcessingOngoing(Action<commercetools.Sdk.Api.Models.Warnings.ImageProcessingOngoingWarning> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Warnings.ImageProcessingOngoingWarning();
            init?.Invoke(t);
            return t;
        }
    }
}
