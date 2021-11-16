using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueChangeValue))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueAbsoluteChangeValue))]
    [SubTypeDiscriminator("external", typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueExternalChangeValue))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueGiftLineItemChangeValue))]
    [SubTypeDiscriminator("relative", typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueRelativeChangeValue))]
    public partial interface IChangeValueChangeValue 
    {
        string Type { get; set;}
    }
}
