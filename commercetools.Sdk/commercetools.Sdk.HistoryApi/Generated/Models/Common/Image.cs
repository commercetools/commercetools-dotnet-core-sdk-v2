namespace commercetools.HistoryApi.Models.Common
{
    public partial class Image : IImage
    {
        public string Url { get; set;}
        
        public IImageDimensions Dimensions { get; set;}
        
        public string Label { get; set;}
    }
}
