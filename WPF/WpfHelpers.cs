using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public static class WpfHelpers
    {
        public static Point GetElementLocationRelativeToWindow(FrameworkElement element, Window w)
        {
            return element.TransformToAncestor(w).Transform(new Point(0, 0));
        }

        public static Rect GetElementBoundsRelativeToWindow(FrameworkElement element, Window w)
        {
            return element.TransformToAncestor(w).TransformBounds(new Rect(element.RenderSize));
        }       
    }
}
