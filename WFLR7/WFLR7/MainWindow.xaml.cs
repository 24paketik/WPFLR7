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

namespace WFLR7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void canvas1_Drop(object sender, DragEventArgs e)
        {
            if (!(e.Source is Canvas))
                return;
            TextBlock src = e.Data.GetData(typeof(TextBlock)) as TextBlock;
            Point p = e.GetPosition(canvas1);
            Canvas.SetLeft(src, p.X - src.ActualWidth/2);
            Canvas.SetTop(src, p.Y - src.ActualHeight/2);
        }

        private void label1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = e.Source as TextBlock;
            if (t == null)
                return;
            if (e.ChangedButton == MouseButton.Left)
                DragDrop.DoDragDrop(t, t, DragDropEffects.Move);
        }
    }
}
