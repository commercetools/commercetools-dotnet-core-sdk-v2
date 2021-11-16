using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartChangeTaxModeAction : IMyCartChangeTaxModeAction
    {
        public string Action { get; set;}
        
        public ITaxMode TaxMode { get; set;}
        public MyCartChangeTaxModeAction()
        { 
           this.Action = "changeTaxMode";
        }
    }
}
