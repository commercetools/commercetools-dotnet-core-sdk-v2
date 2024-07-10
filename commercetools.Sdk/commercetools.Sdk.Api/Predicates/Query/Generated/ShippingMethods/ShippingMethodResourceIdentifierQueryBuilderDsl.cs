using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodResourceIdentifierQueryBuilderDsl
    {
        public ShippingMethodResourceIdentifierQueryBuilderDsl()
        {
        }

        public static ShippingMethodResourceIdentifierQueryBuilderDsl Of()
        {
            return new ShippingMethodResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ShippingMethodResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ShippingMethodResourceIdentifierQueryBuilderDsl>(p, ShippingMethodResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ShippingMethodResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ShippingMethodResourceIdentifierQueryBuilderDsl>(p, ShippingMethodResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShippingMethodResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShippingMethodResourceIdentifierQueryBuilderDsl>(p, ShippingMethodResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
