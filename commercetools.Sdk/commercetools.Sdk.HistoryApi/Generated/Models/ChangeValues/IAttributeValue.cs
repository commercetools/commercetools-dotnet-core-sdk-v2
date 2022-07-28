using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.AttributeValue))]
    public partial interface IAttributeValue
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
