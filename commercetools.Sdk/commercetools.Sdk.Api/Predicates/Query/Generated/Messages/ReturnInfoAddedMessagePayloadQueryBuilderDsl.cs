using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ReturnInfoAddedMessagePayloadQueryBuilderDsl
    {
        public ReturnInfoAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ReturnInfoAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new ReturnInfoAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReturnInfoAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ReturnInfoAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ReturnInfoAddedMessagePayloadQueryBuilderDsl>(p, ReturnInfoAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReturnInfoAddedMessagePayloadQueryBuilderDsl> ReturnInfo(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnInfoAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("returnInfo"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoQueryBuilderDsl.Of())),
                ReturnInfoAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
