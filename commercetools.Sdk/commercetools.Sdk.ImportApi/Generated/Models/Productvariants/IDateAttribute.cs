using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateAttribute))]
    public partial interface IDateAttribute : IAttribute
    {
        DateTime Value { get; set; }
    }
}
