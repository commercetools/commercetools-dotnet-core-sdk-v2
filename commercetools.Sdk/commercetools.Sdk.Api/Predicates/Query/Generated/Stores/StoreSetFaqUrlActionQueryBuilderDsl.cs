// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetFaqUrlActionQueryBuilderDsl
    {
        public StoreSetFaqUrlActionQueryBuilderDsl()
        {
        }

        public static StoreSetFaqUrlActionQueryBuilderDsl Of()
        {
            return new StoreSetFaqUrlActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetFaqUrlActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetFaqUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetFaqUrlActionQueryBuilderDsl>(p, StoreSetFaqUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetFaqUrlActionQueryBuilderDsl, string> FaqUrl()
        {
            return new ComparisonPredicateBuilder<StoreSetFaqUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("faqUrl")),
            p => new CombinationQueryPredicate<StoreSetFaqUrlActionQueryBuilderDsl>(p, StoreSetFaqUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
