using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContentPipelineUI.Views
{
    /// <summary>
    /// Interaktionslogik für ProjectManagementWindow.xaml
    /// </summary>
    public partial class ProjectManagementWindow : Window
    {
        public ProjectManagementWindow()
        {
            InitializeComponent();
            LanguageManager.SetupLanguage(Resources);
        }
    }
}

