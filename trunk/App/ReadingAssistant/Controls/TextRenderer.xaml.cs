using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReadingAssistant.Controls
{
    /// <summary>
    /// Interaction logic for TextRenderer.xaml
    /// </summary>
    public partial class TextRenderer : Control
    {
        public TextRenderer()
        {
            InitializeComponent();
        }

        #region ViewModel dependancy property
        // Using a DependencyProperty as the backing store for ViewModel.
        public static readonly DependencyProperty ViewModelProperty =
            MainWindow.ViewModelProperty.AddOwner(typeof(TextRenderer));

        public ViewModel ViewModel
        {
            get { return (ViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        #endregion

        #region Text dependancy property
        // Using a DependencyProperty as the backing store for Text.
        public static readonly DependencyProperty TextProperty =
            TextBlock.TextProperty.AddOwner(typeof(TextRenderer), 
                new FrameworkPropertyMetadata(string.Empty, 
                    FrameworkPropertyMetadataOptions.AffectsRender,
                    OnTextChanged));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        private static void OnTextChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            ((TextRenderer)sender).createFormattedTextFromString(args.NewValue as string);
        }
        #endregion

        #region TextToRender property
        private FormattedText _textToRender;

        private void createFormattedTextFromString(string text)
        {
            _textToRender = new FormattedText(
                text,
                CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface("Verdana"),
                32,
                Brushes.Black);
        }
        #endregion

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (_textToRender != null)
            {
                _textToRender.MaxTextWidth = this.ActualWidth;
                drawingContext.DrawText(_textToRender, new Point());
            }
        }
    }
}
