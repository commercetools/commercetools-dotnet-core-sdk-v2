// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl
    {
        public StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl, string> CheckoutUrlTemplate()
        {
            return new ComparisonPredicateBuilder<StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("checkoutUrlTemplate")),
            p => new CombinationQueryPredicate<StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl>(p, StoreCheckoutUrlTemplateSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
