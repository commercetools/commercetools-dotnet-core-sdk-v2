using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using System;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderCustomerSetMessage : IOrderCustomerSetMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public ICustomerReference Customer { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public ICustomerReference OldCustomer { get; set; }

        public ICustomerGroupReference OldCustomerGroup { get; set; }
        public OrderCustomerSetMessage()
        {
            this.Type = "OrderCustomerSet";
        }
    }
}
