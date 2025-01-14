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

namespace DisplayDate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // פורמט מותאם אישית להצגת התאריך והשעה
            string formattedDateTime = DateTime.Now.ToString("dddd, dd MMMM yyyy, HH:mm");

            // הצגת התאריך והשעה בתוך ה-Label
            datalable.Content = $"Current Date and Time: {formattedDateTime}";
            int yeudit = 5;
            int y = 6;

        }
    }
}
