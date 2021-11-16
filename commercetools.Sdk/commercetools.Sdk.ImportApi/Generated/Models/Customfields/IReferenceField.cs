using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.ReferenceField))]
    public partial interface IReferenceField : ICustomField
    {
        IKeyReference Value { get; set;}
    }
}
