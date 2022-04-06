using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.Custom))]
    public partial interface ICustom
    {
        ITypeKeyReference Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
