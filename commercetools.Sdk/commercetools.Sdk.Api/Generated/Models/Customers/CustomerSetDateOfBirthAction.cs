using System;


namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class CustomerSetDateOfBirthAction : ICustomerSetDateOfBirthAction
    {
        public string Action { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public CustomerSetDateOfBirthAction()
        {
            this.Action = "setDateOfBirth";
        }
    }
}
