using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class EditPreviewFailedErrorQueryBuilderDsl
    {
        public EditPreviewFailedErrorQueryBuilderDsl()
        {
        }

        public static EditPreviewFailedErrorQueryBuilderDsl Of()
        {
            return new EditPreviewFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<EditPreviewFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<EditPreviewFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<EditPreviewFailedErrorQueryBuilderDsl>(p, EditPreviewFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<EditPreviewFailedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<EditPreviewFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<EditPreviewFailedErrorQueryBuilderDsl>(p, EditPreviewFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<EditPreviewFailedErrorQueryBuilderDsl> Result(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewFailureQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewFailureQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<EditPreviewFailedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("result"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewFailureQueryBuilderDsl.Of())),
                EditPreviewFailedErrorQueryBuilderDsl.Of);
        }


    }
}
