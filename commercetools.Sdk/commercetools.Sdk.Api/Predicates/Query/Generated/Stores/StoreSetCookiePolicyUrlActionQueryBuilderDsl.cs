// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetCookiePolicyUrlActionQueryBuilderDsl
    {
        public StoreSetCookiePolicyUrlActionQueryBuilderDsl()
        {
        }

        public static StoreSetCookiePolicyUrlActionQueryBuilderDsl Of()
        {
            return new StoreSetCookiePolicyUrlActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetCookiePolicyUrlActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetCookiePolicyUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetCookiePolicyUrlActionQueryBuilderDsl>(p, StoreSetCookiePolicyUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetCookiePolicyUrlActionQueryBuilderDsl, string> CookiePolicyUrl()
        {
            return new ComparisonPredicateBuilder<StoreSetCookiePolicyUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cookiePolicyUrl")),
            p => new CombinationQueryPredicate<StoreSetCookiePolicyUrlActionQueryBuilderDsl>(p, StoreSetCookiePolicyUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
