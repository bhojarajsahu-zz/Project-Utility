using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities.UtilityClass
{
    public class UIElement
    {
        public string Label { get; set; }
        public string Id { get; set; }
        public ControlTypes.ControlType ControlType { get; set; }
        public string DisplayFormat { get; set; }

        public string Value { get; set; }
    }
}
