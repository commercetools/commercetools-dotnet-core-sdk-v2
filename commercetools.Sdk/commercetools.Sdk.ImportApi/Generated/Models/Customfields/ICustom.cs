using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.Custom))]
    public partial interface ICustom 
    {
        ITypeKeyReference Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
