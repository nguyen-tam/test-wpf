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
using System.Windows.Interop; // Required for HwndSource, HwndSourceHook
using System.Runtime.InteropServices; // Required for DllImport and Point definition

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

        // --- WM_NCHITTEST Handling for Snap Layouts ---

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            var helper = new WindowInteropHelper(this);
            var hwnd = helper.Handle;
            var source = HwndSource.FromHwnd(hwnd);
            source?.AddHook(WndProc);
        }

        private const int WM_NCHITTEST = 0x0084;
        private const int HTMAXBUTTON = 9; // Indicates the maximize button

        // Basic Point struct if not available
        [StructLayout(LayoutKind.Sequential)]
        public struct Point
        {
            public int X;
            public int Y;
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Point pt);


        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == WM_NCHITTEST)
            {
                // Use the custom Point struct for GetCursorPos
                Point screenPointWin32 = new Point(); 
                if (GetCursorPos(ref screenPointWin32))
                {
                    // Convert the Win32 screen point to a WPF screen point
                    System.Windows.Point screenPointWpf = new System.Windows.Point(screenPointWin32.X, screenPointWin32.Y);

                    // Convert the WPF screen point to a WPF client point relative to the window
                    System.Windows.Point clientPoint = PointFromScreen(screenPointWpf);

                    // Check if the point is within the MaximizeButton bounds
                    if (MaximizeButton != null)
                    {
                        // Get the bounds of the button relative to the window
                        Rect buttonBounds = MaximizeButton.TransformToAncestor(this)
                                                    .TransformBounds(new Rect(0, 0, MaximizeButton.ActualWidth, MaximizeButton.ActualHeight));

                        // Check if the client point is within the button bounds
                        if (buttonBounds.Contains(clientPoint)) // Use the WPF clientPoint here
                        {
                            handled = true;
                            return new IntPtr(HTMAXBUTTON);
                        }
                    }
                }
            }
            return IntPtr.Zero;
        }
    }
}