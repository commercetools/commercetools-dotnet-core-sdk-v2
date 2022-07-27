namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartRecalculateAction : IMyCartRecalculateAction
    {
        public string Action { get; set; }

        public bool? UpdateProductData { get; set; }
        public MyCartRecalculateAction()
        {
            this.Action = "recalculate";
        }
    }
}
