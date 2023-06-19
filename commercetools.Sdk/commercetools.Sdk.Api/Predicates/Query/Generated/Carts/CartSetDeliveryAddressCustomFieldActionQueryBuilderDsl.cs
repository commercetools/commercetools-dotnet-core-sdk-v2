// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl
    {
        public CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl>(p, CartSetDeliveryAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
