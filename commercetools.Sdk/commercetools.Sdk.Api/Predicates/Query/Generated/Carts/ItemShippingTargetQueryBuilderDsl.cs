// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ItemShippingTargetQueryBuilderDsl
    {
        public ItemShippingTargetQueryBuilderDsl()
        {
        }

        public static ItemShippingTargetQueryBuilderDsl Of()
        {
            return new ItemShippingTargetQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ItemShippingTargetQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<ItemShippingTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<ItemShippingTargetQueryBuilderDsl>(p, ItemShippingTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ItemShippingTargetQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ItemShippingTargetQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ItemShippingTargetQueryBuilderDsl>(p, ItemShippingTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ItemShippingTargetQueryBuilderDsl, string> ShippingMethodKey()
        {
            return new ComparisonPredicateBuilder<ItemShippingTargetQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingMethodKey")),
            p => new CombinationQueryPredicate<ItemShippingTargetQueryBuilderDsl>(p, ItemShippingTargetQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
