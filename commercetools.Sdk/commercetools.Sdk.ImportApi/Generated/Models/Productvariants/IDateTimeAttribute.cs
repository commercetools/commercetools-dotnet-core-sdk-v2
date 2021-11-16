using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.DateTimeAttribute))]
    public partial interface IDateTimeAttribute : IAttribute
    {
        DateTime Value { get; set; }
    }
}
