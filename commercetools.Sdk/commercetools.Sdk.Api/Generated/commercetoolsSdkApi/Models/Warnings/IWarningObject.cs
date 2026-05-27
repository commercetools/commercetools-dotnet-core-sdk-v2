using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Warnings
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Warnings.WarningObject))]
    [SubTypeDiscriminator("CannotChangeReservationExpiry", typeof(commercetools.Sdk.Api.Models.Warnings.CannotChangeReservationExpiryWarning))]
    [SubTypeDiscriminator("CannotCreateReservation", typeof(commercetools.Sdk.Api.Models.Warnings.CannotCreateReservationWarning))]
    [SubTypeDiscriminator("CannotUpdateReservation", typeof(commercetools.Sdk.Api.Models.Warnings.CannotUpdateReservationWarning))]
    [SubTypeDiscriminator("ImageProcessingOngoing", typeof(commercetools.Sdk.Api.Models.Warnings.ImageProcessingOngoingWarning))]
    public partial interface IWarningObject
    {
        string Code { get; set; }

        string Message { get; set; }

        static commercetools.Sdk.Api.Models.Warnings.CannotChangeReservationExpiryWarning CannotChangeReservationExpiry(Action<commercetools.Sdk.Api.Models.Warnings.CannotChangeReservationExpiryWarning> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Warnings.CannotChangeReservationExpiryWarning();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Warnings.CannotCreateReservationWarning CannotCreateReservation(Action<commercetools.Sdk.Api.Models.Warnings.CannotCreateReservationWarning> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Warnings.CannotCreateReservationWarning();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Warnings.CannotUpdateReservationWarning CannotUpdateReservation(Action<commercetools.Sdk.Api.Models.Warnings.CannotUpdateReservationWarning> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Warnings.CannotUpdateReservationWarning();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Warnings.ImageProcessingOngoingWarning ImageProcessingOngoing(Action<commercetools.Sdk.Api.Models.Warnings.ImageProcessingOngoingWarning> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Warnings.ImageProcessingOngoingWarning();
            init?.Invoke(t);
            return t;
        }
    }
}
