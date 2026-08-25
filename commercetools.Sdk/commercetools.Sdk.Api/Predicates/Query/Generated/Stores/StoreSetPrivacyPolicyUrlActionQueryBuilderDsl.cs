// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetPrivacyPolicyUrlActionQueryBuilderDsl
    {
        public StoreSetPrivacyPolicyUrlActionQueryBuilderDsl()
        {
        }

        public static StoreSetPrivacyPolicyUrlActionQueryBuilderDsl Of()
        {
            return new StoreSetPrivacyPolicyUrlActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetPrivacyPolicyUrlActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetPrivacyPolicyUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetPrivacyPolicyUrlActionQueryBuilderDsl>(p, StoreSetPrivacyPolicyUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetPrivacyPolicyUrlActionQueryBuilderDsl, string> PrivacyPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StoreSetPrivacyPolicyUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("privacyPolicyUrl")),
            p => new CombinationQueryPredicate<StoreSetPrivacyPolicyUrlActionQueryBuilderDsl>(p, StoreSetPrivacyPolicyUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
