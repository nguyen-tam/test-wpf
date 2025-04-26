using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // Handle state changes
            StateChanged += MainWindow_StateChanged;
            
            // Enable window dragging from title bar
            AppTitleBar.MouseLeftButtonDown += AppTitleBar_MouseLeftButtonDown;
            
            // Connect window control buttons
            MinimizeButton.Click += MinimizeButton_Click;
            MaximizeButton.Click += MaximizeButton_Click;
            CloseButton.Click += CloseButton_Click;
            
            // Handle your custom button events
            YourButton.Click += YourButton_Click;
            
            // Initialize your ComboBox
            PopulateComboBox();
            
            // Set initial maximize icon based on window state
            UpdateMaximizeIcon();
        }

        // Make window draggable from title bar
        private void AppTitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left && e.ButtonState == MouseButtonState.Pressed)
                {
                    if (Mouse.LeftButton == MouseButtonState.Pressed)
                    {
                        DragMove();
                    }
                }
            }
            catch (InvalidOperationException)
            {
                // Ignore errors if mouse button is released during drag
            }
        }

        // Window control button handlers
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
            UpdateMaximizeIcon();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Update window state icons
        private void MainWindow_StateChanged(object sender, EventArgs e)
        {
            UpdateMaximizeIcon();
        }
        
        private void UpdateMaximizeIcon()
        {
            if (WindowState == WindowState.Maximized)
            {
                // Restore icon (showing a restored window)
                MaximizeIcon.Data = Geometry.Parse("M 2,2 H 10 V 10 H 2 Z M 0,0 H 8 V 0 M 0,0 V 8 H 0");
            }
            else
            {
                // Maximize icon (showing a maximized window)
                MaximizeIcon.Data = Geometry.Parse("M 0,0 H 10 V 10 H 0 Z");
            }
        }

        private void YourButton_Click(object sender, RoutedEventArgs e)
        {
            // Your button functionality here
            MessageBox.Show("Button clicked!");
        }

        private void PopulateComboBox()
        {
            // Add items to your ComboBox
            YourComboBox.Items.Add("Option 1");
            YourComboBox.Items.Add("Option 2");
            YourComboBox.Items.Add("Option 3");
        }
    }
}