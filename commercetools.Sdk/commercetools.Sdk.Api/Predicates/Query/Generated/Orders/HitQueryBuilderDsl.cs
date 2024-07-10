// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class HitQueryBuilderDsl
    {
        public HitQueryBuilderDsl()
        {
        }

        public static HitQueryBuilderDsl Of()
        {
            return new HitQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<HitQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<HitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<HitQueryBuilderDsl>(p, HitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HitQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<HitQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<HitQueryBuilderDsl>(p, HitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HitQueryBuilderDsl, decimal> Relevance()
        {
            return new ComparisonPredicateBuilder<HitQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("relevance")),
            p => new CombinationQueryPredicate<HitQueryBuilderDsl>(p, HitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
