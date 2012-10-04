using System;
using System.Collections.Generic;
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
    public partial class TextRenderer : TextBlock
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
    }
}
