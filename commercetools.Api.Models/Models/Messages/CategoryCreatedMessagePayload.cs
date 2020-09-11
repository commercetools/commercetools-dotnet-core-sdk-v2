using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class CategoryCreatedMessagePayload : MessagePayload
    {
        public Category Category { get; set;}
    }
}
