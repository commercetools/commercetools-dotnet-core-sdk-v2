using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl
    {
        public AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl, string> Permission()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permission")),
            p => new CombinationQueryPredicate<AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl>(p, AssociateRolePermissionRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
