using System;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitSetCustomFieldAction : IMyBusinessUnitSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyBusinessUnitSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
