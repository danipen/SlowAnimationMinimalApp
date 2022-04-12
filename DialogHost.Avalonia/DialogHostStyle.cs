using Avalonia;
using Avalonia.Media;

namespace DialogHost {
    public class DialogHostStyle {
        /// <summary>
        /// Controls CornerRadius DialogHost's popup background.
        /// Works only for default DialogHost theme!
        /// </summary>
        public static readonly AttachedProperty<CornerRadius> CornerRadiusProperty = 
            AvaloniaProperty.RegisterAttached<DialogHostStyle, DialogHost, CornerRadius>("CornerRadius");

        /// <summary>
        /// Get CornerRadius in DialogHost's popup background.
        /// Works only for default DialogHost theme!
        /// </summary>
        public static CornerRadius GetCornerRadius(DialogHost element) {
            return element.GetValue(CornerRadiusProperty);
        }

        /// <summary>
        /// Set CornerRadius in DialogHost's popup background.
        /// Works only for default DialogHost theme!
        /// </summary>
        public static void SetCornerRadius(DialogHost element, CornerRadius value) {
            element.SetValue(CornerRadiusProperty, value);
        }

        /// <summary>
        /// Controls BorderBrush DialogHost's popup background.
        /// Works only for default DialogHost theme!
        /// </summary>
        public static readonly AttachedProperty<IBrush> BorderBrushProperty =
            AvaloniaProperty.RegisterAttached<DialogHostStyle, DialogHost, IBrush>("BorderBrush");

        /// <summary>
        /// Get BorderBruch in DialogHost's popup background.
        /// Works only for default DialogHost theme!
        /// </summary>
        public static IBrush GetBorderBrush(DialogHost element)
        {
            return element.GetValue(BorderBrushProperty);
        }

        /// <summary>
        /// Set BorderBrush in DialogHost's popup background.
        /// Works only for default DialogHost theme!
        /// </summary>
        public static void SetBorderBrush(DialogHost element, IBrush value)
        {
            element.SetValue(BorderBrushProperty, value);
        }

        /// <summary>
        /// Controls BorderThickness DialogHost's popup background.
        /// Works only for default DialogHost theme!
        /// </summary>
        public static readonly AttachedProperty<Thickness> BorderThicknessProperty =
            AvaloniaProperty.RegisterAttached<DialogHostStyle, DialogHost, Thickness>("BorderThickness");

        /// <summary>
        /// Get BorderThickness in DialogHost's popup background.
        /// Works only for default DialogHost theme!
        /// </summary>
        public static Thickness GetBorderThickness(DialogHost element)
        {
            return element.GetValue(BorderThicknessProperty);
        }

        /// <summary>
        /// Set BorderThickness in DialogHost's popup background.
        /// Works only for default DialogHost theme!
        /// </summary>
        public static void SetCornerRadius(DialogHost element, Thickness value)
        {
            element.SetValue(BorderThicknessProperty, value);
        }
    }
}