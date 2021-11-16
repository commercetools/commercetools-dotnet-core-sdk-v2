using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class Custom : ICustom
    {
        public ITypeKeyReference Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
    }
}
