// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetContactUrlActionQueryBuilderDsl
    {
        public StoreSetContactUrlActionQueryBuilderDsl()
        {
        }

        public static StoreSetContactUrlActionQueryBuilderDsl Of()
        {
            return new StoreSetContactUrlActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetContactUrlActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetContactUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetContactUrlActionQueryBuilderDsl>(p, StoreSetContactUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetContactUrlActionQueryBuilderDsl, string> ContactUrl()
        {
            return new ComparisonPredicateBuilder<StoreSetContactUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactUrl")),
            p => new CombinationQueryPredicate<StoreSetContactUrlActionQueryBuilderDsl>(p, StoreSetContactUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
