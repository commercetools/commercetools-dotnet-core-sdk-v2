using commercetools.MLApi.Models.Common;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingImages : IMissingImages
    {
        public IProductReference Product { get; set;}
        
        public long VariantId { get; set;}
        
        public long ImageCount { get; set;}
    }
}
