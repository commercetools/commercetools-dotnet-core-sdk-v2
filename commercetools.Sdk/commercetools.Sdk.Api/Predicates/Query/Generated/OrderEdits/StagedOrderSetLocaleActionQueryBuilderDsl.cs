// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetLocaleActionQueryBuilderDsl
    {
        public StagedOrderSetLocaleActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetLocaleActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetLocaleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetLocaleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetLocaleActionQueryBuilderDsl>(p, StagedOrderSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetLocaleActionQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<StagedOrderSetLocaleActionQueryBuilderDsl>(p, StagedOrderSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
