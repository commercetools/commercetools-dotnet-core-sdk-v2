using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Labels
{
    public partial class PaymentLabel : IPaymentLabel
    {
        public string Type { get; set;}
        
        public string Key { get; set;}
        
        public IMoney AmountPlanned { get; set;}
        public PaymentLabel()
        { 
           this.Type = "PaymentLabel";
        }
    }
}
