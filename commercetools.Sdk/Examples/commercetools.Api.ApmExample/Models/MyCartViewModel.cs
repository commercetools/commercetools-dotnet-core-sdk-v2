using System.Collections.Generic;

namespace commercetools.Api.ApmExample.Models
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