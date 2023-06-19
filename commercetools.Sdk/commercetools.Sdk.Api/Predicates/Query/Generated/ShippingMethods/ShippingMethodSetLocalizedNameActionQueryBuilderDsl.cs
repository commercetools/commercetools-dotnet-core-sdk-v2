using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodSetLocalizedNameActionQueryBuilderDsl
    {
        public ShippingMethodSetLocalizedNameActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodSetLocalizedNameActionQueryBuilderDsl Of()
        {
            return new ShippingMethodSetLocalizedNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodSetLocalizedNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetLocalizedNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodSetLocalizedNameActionQueryBuilderDsl>(p, ShippingMethodSetLocalizedNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodSetLocalizedNameActionQueryBuilderDsl> LocalizedName(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodSetLocalizedNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedName"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShippingMethodSetLocalizedNameActionQueryBuilderDsl.Of);
        }


    }
}
