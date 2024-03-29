using System.Collections.Generic;

namespace commercetools.Api.NewRelicExample.Models
{
    public class MyCartViewModel
    {
        public string CartId { get; set; }
        public List<LineItemViewModel> LineItems { get; set; }

        public MyCartViewModel()
        {
            LineItems = new List<LineItemViewModel>();
        }
    }
}