using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchSorting))]
    public partial interface IOrderSearchSorting
    {
        string Field { get; set; }

        string Language { get; set; }

        IOrderSearchSortOrder Order { get; set; }

        IOrderSearchSortMode Mode { get; set; }

        IOrderSearchQueryExpression Filter { get; set; }

    }
}
