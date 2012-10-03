using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReadingAssistant
{
    class ViewModel: DependencyObject
    {
        #region HighlightingSpeed dependancy property
        // Using a DependencyProperty as the backing store for HighlightingSpeed.
        public static readonly DependencyProperty HighlightingSpeedProperty =
            DependencyProperty.Register("HighlightingSpeed", typeof(double), typeof(ViewModel));

        public double HighlightingSpeed
        {
            get { return (double)GetValue(HighlightingSpeedProperty); }
            set { SetValue(HighlightingSpeedProperty, value); }
        }
        #endregion

        #region InputTextFilePath dependancy property
        // Using a DependencyProperty as the backing store for InputTextFilePath.
        public static readonly DependencyProperty InputTextFilePathProperty =
            DependencyProperty.Register("InputTextFilePath", typeof(string), typeof(ViewModel));

        public string InputTextFilePath
        {
            get { return (string)GetValue(InputTextFilePathProperty); }
            set { SetValue(InputTextFilePathProperty, value); }
        }
        #endregion

    }
}
