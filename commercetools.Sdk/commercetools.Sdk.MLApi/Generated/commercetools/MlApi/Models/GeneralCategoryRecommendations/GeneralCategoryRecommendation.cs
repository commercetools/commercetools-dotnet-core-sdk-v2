namespace commercetools.MLApi.Models.GeneralCategoryRecommendations
{
    public partial class GeneralCategoryRecommendation : IGeneralCategoryRecommendation
    {
        public string CategoryName { get; set;}
        
        public double Confidence { get; set;}
    }
}
