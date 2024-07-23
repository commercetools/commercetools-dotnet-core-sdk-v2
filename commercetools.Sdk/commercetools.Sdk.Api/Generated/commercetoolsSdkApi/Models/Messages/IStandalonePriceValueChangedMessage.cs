using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceValueChangedMessage))]
    public partial interface IStandalonePriceValueChangedMessage : IMessage
    {
        ITypedMoney Value { get; set; }

        bool Staged { get; set; }

        ITypedMoney OldValue { get; set; }

    }
}
