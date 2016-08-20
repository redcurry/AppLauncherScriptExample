using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AppLauncherScriptExample
{
    public partial class MainView : UserControl
    {
        private readonly MainViewModel _viewModel;

        public MainView(MainViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;
        }

        private void ListBox_OnDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _viewModel.RunSelectedScript();
        }

        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);

            if (window != null)
            {
                window.Close();
            }
        }

        private void RunButton_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.RunSelectedScript();
        }
    }
}
