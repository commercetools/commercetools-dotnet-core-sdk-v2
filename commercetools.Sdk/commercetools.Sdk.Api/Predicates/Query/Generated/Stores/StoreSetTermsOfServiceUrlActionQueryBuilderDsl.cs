// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetTermsOfServiceUrlActionQueryBuilderDsl
    {
        public StoreSetTermsOfServiceUrlActionQueryBuilderDsl()
        {
        }

        public static StoreSetTermsOfServiceUrlActionQueryBuilderDsl Of()
        {
            return new StoreSetTermsOfServiceUrlActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetTermsOfServiceUrlActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetTermsOfServiceUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetTermsOfServiceUrlActionQueryBuilderDsl>(p, StoreSetTermsOfServiceUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetTermsOfServiceUrlActionQueryBuilderDsl, string> TermsOfServiceUrl()
        {
            return new ComparisonPredicateBuilder<StoreSetTermsOfServiceUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("termsOfServiceUrl")),
            p => new CombinationQueryPredicate<StoreSetTermsOfServiceUrlActionQueryBuilderDsl>(p, StoreSetTermsOfServiceUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
