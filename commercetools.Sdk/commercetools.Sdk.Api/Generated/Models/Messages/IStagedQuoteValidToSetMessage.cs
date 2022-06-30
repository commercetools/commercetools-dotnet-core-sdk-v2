using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessage))]
    public partial interface IStagedQuoteValidToSetMessage : IMessage
    {
        DateTime ValidTo { get; set; }
    }
}
