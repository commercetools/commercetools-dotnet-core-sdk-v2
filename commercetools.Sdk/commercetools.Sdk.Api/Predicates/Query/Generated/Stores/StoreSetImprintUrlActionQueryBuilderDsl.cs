// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetImprintUrlActionQueryBuilderDsl
    {
        public StoreSetImprintUrlActionQueryBuilderDsl()
        {
        }

        public static StoreSetImprintUrlActionQueryBuilderDsl Of()
        {
            return new StoreSetImprintUrlActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetImprintUrlActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetImprintUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetImprintUrlActionQueryBuilderDsl>(p, StoreSetImprintUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetImprintUrlActionQueryBuilderDsl, string> ImprintUrl()
        {
            return new ComparisonPredicateBuilder<StoreSetImprintUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imprintUrl")),
            p => new CombinationQueryPredicate<StoreSetImprintUrlActionQueryBuilderDsl>(p, StoreSetImprintUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
