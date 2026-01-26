// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class AnyOrderQueryBuilderDsl
    {
        public AnyOrderQueryBuilderDsl()
        {
        }

        public static AnyOrderQueryBuilderDsl Of()
        {
            return new AnyOrderQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AnyOrderQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AnyOrderQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AnyOrderQueryBuilderDsl>(p, AnyOrderQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
