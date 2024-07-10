using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class ImageQueryBuilderDsl
    {
        public ImageQueryBuilderDsl()
        {
        }

        public static ImageQueryBuilderDsl Of()
        {
            return new ImageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ImageQueryBuilderDsl, string> Url()
        {
            return new ComparisonPredicateBuilder<ImageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("url")),
            p => new CombinationQueryPredicate<ImageQueryBuilderDsl>(p, ImageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ImageQueryBuilderDsl> Dimensions(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ImageDimensionsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ImageDimensionsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ImageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("dimensions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ImageDimensionsQueryBuilderDsl.Of())),
                ImageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ImageQueryBuilderDsl, string> Label()
        {
            return new ComparisonPredicateBuilder<ImageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("label")),
            p => new CombinationQueryPredicate<ImageQueryBuilderDsl>(p, ImageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
