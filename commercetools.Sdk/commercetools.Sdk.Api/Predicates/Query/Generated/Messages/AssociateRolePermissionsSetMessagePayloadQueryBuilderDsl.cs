// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl
    {
        public AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl Of()
        {
            return new AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl>(p, AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl, string> Permissions()
        {
            return new ComparableCollectionPredicateBuilder<AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("permissions")),
            p => new CombinationQueryPredicate<AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl>(p, AssociateRolePermissionsSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
