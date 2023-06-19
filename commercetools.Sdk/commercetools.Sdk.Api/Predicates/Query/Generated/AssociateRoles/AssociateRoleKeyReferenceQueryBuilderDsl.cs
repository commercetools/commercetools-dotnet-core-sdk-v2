// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleKeyReferenceQueryBuilderDsl
    {
        public AssociateRoleKeyReferenceQueryBuilderDsl()
        {
        }

        public static AssociateRoleKeyReferenceQueryBuilderDsl Of()
        {
            return new AssociateRoleKeyReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleKeyReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<AssociateRoleKeyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<AssociateRoleKeyReferenceQueryBuilderDsl>(p, AssociateRoleKeyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleKeyReferenceQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AssociateRoleKeyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AssociateRoleKeyReferenceQueryBuilderDsl>(p, AssociateRoleKeyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
