// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StorefrontQueryBuilderDsl
    {
        public StorefrontQueryBuilderDsl()
        {
        }

        public static StorefrontQueryBuilderDsl Of()
        {
            return new StorefrontQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> CheckoutUrlTemplate()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("checkoutUrlTemplate")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> OrderUrlTemplate()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderUrlTemplate")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> TermsOfServiceUrl()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("termsOfServiceUrl")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> PrivacyPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("privacyPolicyUrl")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> RefundPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("refundPolicyUrl")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> ShippingPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingPolicyUrl")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> CookiePolicyUrl()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cookiePolicyUrl")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> ImprintUrl()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("imprintUrl")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> FaqUrl()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("faqUrl")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string> ContactUrl()
        {
            return new ComparisonPredicateBuilder<StorefrontQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactUrl")),
            p => new CombinationQueryPredicate<StorefrontQueryBuilderDsl>(p, StorefrontQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
