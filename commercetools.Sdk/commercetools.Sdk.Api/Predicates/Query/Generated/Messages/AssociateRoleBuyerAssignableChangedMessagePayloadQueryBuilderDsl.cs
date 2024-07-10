using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl
    {
        public AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl, bool> BuyerAssignable()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buyerAssignable")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
