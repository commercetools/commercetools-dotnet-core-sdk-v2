using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeAttribute))]
    public partial interface IDateTimeAttribute : IAttribute
    {
        DateTime Value { get; set; }

    }
}
