// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl
    {
        public AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl>(p, AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl, string> Permission()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permission")),
            p => new CombinationQueryPredicate<AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl>(p, AssociateRolePermissionAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
