using commercetools.Api.Models.DiscountCodes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartRemoveDiscountCodeAction : IMyCartRemoveDiscountCodeAction
    {
        public string Action { get; set;}
        
        public IDiscountCodeReference DiscountCode { get; set;}
        public MyCartRemoveDiscountCodeAction()
        { 
           this.Action = "removeDiscountCode";
        }
    }
}
