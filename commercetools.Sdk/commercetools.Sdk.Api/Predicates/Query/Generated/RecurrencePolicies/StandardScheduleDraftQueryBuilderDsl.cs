// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class StandardScheduleDraftQueryBuilderDsl
    {
        public StandardScheduleDraftQueryBuilderDsl()
        {
        }

        public static StandardScheduleDraftQueryBuilderDsl Of()
        {
            return new StandardScheduleDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandardScheduleDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StandardScheduleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StandardScheduleDraftQueryBuilderDsl>(p, StandardScheduleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandardScheduleDraftQueryBuilderDsl, long> Value()
        {
            return new ComparisonPredicateBuilder<StandardScheduleDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<StandardScheduleDraftQueryBuilderDsl>(p, StandardScheduleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandardScheduleDraftQueryBuilderDsl, string> IntervalUnit()
        {
            return new ComparisonPredicateBuilder<StandardScheduleDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("intervalUnit")),
            p => new CombinationQueryPredicate<StandardScheduleDraftQueryBuilderDsl>(p, StandardScheduleDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
