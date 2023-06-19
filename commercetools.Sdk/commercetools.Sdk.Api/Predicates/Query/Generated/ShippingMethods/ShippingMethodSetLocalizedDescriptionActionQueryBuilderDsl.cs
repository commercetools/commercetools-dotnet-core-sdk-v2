using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl
    {
        public ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl Of()
        {
            return new ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl>(p, ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl> LocalizedDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShippingMethodSetLocalizedDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
