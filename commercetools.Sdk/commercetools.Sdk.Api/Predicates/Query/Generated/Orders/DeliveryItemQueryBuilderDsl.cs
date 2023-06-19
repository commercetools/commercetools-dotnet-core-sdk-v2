// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class DeliveryItemQueryBuilderDsl
    {
        public DeliveryItemQueryBuilderDsl()
        {
        }

        public static DeliveryItemQueryBuilderDsl Of()
        {
            return new DeliveryItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryItemQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DeliveryItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DeliveryItemQueryBuilderDsl>(p, DeliveryItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryItemQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<DeliveryItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<DeliveryItemQueryBuilderDsl>(p, DeliveryItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
