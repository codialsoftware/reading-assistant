using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReadingAssistant
{
    public class ViewModel: DependencyObject
    {
        public ViewModel()
        {
            this.TextToRead = "On the Insert tab, the galleries include items that are designed to coordinate with the overall look of your document. You can use these galleries to insert tables, headers, footers, lists, cover pages, and other document building blocks. When you create pictures, charts, or diagrams, they also coordinate with your current document look." + Environment.NewLine + Environment.NewLine +
                "You can easily change the formatting of selected text in the document text by choosing a look for the selected text from the Quick Styles gallery on the Home tab. You can also format text directly by using the other controls on the Home tab. Most controls offer a choice of using the look from the current theme or using a format that you specify directly." + Environment.NewLine + Environment.NewLine +
                "To change the overall look of your document, choose new Theme elements on the Page Layout tab. To change the looks available in the Quick Style gallery, use the Change Current Quick Style Set command. Both the Themes gallery and the Quick Styles gallery provide reset commands so that you can always restore the look of your document to the original contained in your current template.";
        }

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

        #region TextToRead dependancy property
        // Using a DependencyProperty as the backing store for TextToRead.
        public static readonly DependencyProperty TextToReadProperty =
            DependencyProperty.Register("TextToRead", typeof(string), typeof(ViewModel));

        public string TextToRead
        {
            get { return (string)GetValue(TextToReadProperty); }
            set { SetValue(TextToReadProperty, value); }
        }
        #endregion
    }
}
