using System;


namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerSetDateOfBirthAction : IMyCustomerSetDateOfBirthAction
    {
        public string Action { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public MyCustomerSetDateOfBirthAction()
        {
            this.Action = "setDateOfBirth";
        }
    }
}
