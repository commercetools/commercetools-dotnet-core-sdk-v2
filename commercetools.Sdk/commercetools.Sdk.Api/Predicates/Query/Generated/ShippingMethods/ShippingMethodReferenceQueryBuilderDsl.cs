using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodReferenceQueryBuilderDsl
    {
        public ShippingMethodReferenceQueryBuilderDsl()
        {
        }

        public static ShippingMethodReferenceQueryBuilderDsl Of()
        {
            return new ShippingMethodReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ShippingMethodReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ShippingMethodReferenceQueryBuilderDsl>(p, ShippingMethodReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ShippingMethodReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ShippingMethodReferenceQueryBuilderDsl>(p, ShippingMethodReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ShippingMethodQueryBuilderDsl.Of())),
                ShippingMethodReferenceQueryBuilderDsl.Of);
        }


    }
}
