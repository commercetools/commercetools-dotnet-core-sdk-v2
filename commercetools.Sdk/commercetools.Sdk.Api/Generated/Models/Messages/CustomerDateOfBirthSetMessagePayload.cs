using System;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomerDateOfBirthSetMessagePayload : ICustomerDateOfBirthSetMessagePayload
    {
        public string Type { get; set; }

        public DateTime DateOfBirth { get; set; }
        public CustomerDateOfBirthSetMessagePayload()
        {
            this.Type = "CustomerDateOfBirthSet";
        }
    }
}
