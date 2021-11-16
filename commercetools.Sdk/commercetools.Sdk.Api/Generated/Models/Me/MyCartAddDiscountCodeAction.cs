namespace commercetools.Api.Models.Me
{
    public partial class MyCartAddDiscountCodeAction : IMyCartAddDiscountCodeAction
    {
        public string Action { get; set; }

        public string Code { get; set; }
        public MyCartAddDiscountCodeAction()
        {
            this.Action = "addDiscountCode";
        }
    }
}
