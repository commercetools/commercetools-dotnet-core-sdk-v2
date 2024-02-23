using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ReturnInfoSetMessagePayloadQueryBuilderDsl
    {
        public ReturnInfoSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ReturnInfoSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ReturnInfoSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReturnInfoSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ReturnInfoSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ReturnInfoSetMessagePayloadQueryBuilderDsl>(p, ReturnInfoSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReturnInfoSetMessagePayloadQueryBuilderDsl> ReturnInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnInfoSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("returnInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl.Of())),
                ReturnInfoSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ReturnInfoSetMessagePayloadQueryBuilderDsl> ReturnInfo()
        {
            return new CollectionPredicateBuilder<ReturnInfoSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnInfo")),
                    p => new CombinationQueryPredicate<ReturnInfoSetMessagePayloadQueryBuilderDsl>(p, ReturnInfoSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
