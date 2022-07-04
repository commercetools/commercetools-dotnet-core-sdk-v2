using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteValidToSetMessagePayload))]
    public partial interface IStagedQuoteValidToSetMessagePayload : IMessagePayload
    {
        DateTime ValidTo { get; set; }
    }
}
