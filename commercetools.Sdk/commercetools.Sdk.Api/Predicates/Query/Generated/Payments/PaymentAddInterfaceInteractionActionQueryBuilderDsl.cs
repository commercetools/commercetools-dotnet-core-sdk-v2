using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentAddInterfaceInteractionActionQueryBuilderDsl
    {
        public PaymentAddInterfaceInteractionActionQueryBuilderDsl()
        {
        }

        public static PaymentAddInterfaceInteractionActionQueryBuilderDsl Of()
        {
            return new PaymentAddInterfaceInteractionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentAddInterfaceInteractionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<PaymentAddInterfaceInteractionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<PaymentAddInterfaceInteractionActionQueryBuilderDsl>(p, PaymentAddInterfaceInteractionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentAddInterfaceInteractionActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentAddInterfaceInteractionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                PaymentAddInterfaceInteractionActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentAddInterfaceInteractionActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentAddInterfaceInteractionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                PaymentAddInterfaceInteractionActionQueryBuilderDsl.Of);
        }


    }
}
