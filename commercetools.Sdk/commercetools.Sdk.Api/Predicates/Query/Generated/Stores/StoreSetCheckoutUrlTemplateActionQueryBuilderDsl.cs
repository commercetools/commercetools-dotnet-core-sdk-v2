// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetCheckoutUrlTemplateActionQueryBuilderDsl
    {
        public StoreSetCheckoutUrlTemplateActionQueryBuilderDsl()
        {
        }

        public static StoreSetCheckoutUrlTemplateActionQueryBuilderDsl Of()
        {
            return new StoreSetCheckoutUrlTemplateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetCheckoutUrlTemplateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetCheckoutUrlTemplateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetCheckoutUrlTemplateActionQueryBuilderDsl>(p, StoreSetCheckoutUrlTemplateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetCheckoutUrlTemplateActionQueryBuilderDsl, string> CheckoutUrlTemplate()
        {
            return new ComparisonPredicateBuilder<StoreSetCheckoutUrlTemplateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("checkoutUrlTemplate")),
            p => new CombinationQueryPredicate<StoreSetCheckoutUrlTemplateActionQueryBuilderDsl>(p, StoreSetCheckoutUrlTemplateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
