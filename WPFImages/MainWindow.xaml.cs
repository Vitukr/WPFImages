using System;
using System.Collections.Generic;
using MyBitmap = System.Drawing;
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
using System.Windows.Media.Effects;
using System.Collections.ObjectModel;

namespace WPFImages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int ImageIndex { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Drop(object sender, DragEventArgs e)
        {
            try
            {
                string[] droppedFiles = null;
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    droppedFiles = e.Data.GetData(DataFormats.FileDrop, true) as string[];
                }

                if ((null == droppedFiles) || (!droppedFiles.Any())) { return; }

                foreach (string s in droppedFiles)
                {
                    Image image = new Image() { /*MaxHeight = 200, MaxWidth = 200*/ };
                    image.PreviewMouseDown += Image_PreviewMouseDown;
                    image.Source = new BitmapImage(new Uri(s));
                    WrapPanelImages.Children.Add(image);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {

            }
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var imageClicked = sender as Image;
            try
            {
                if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
                {
                    ImageIndex = WrapPanelImages.Children.IndexOf(imageClicked);
                    ImageBig.Source = imageClicked.Source;
                    ScrollViewerImages.Visibility = Visibility.Collapsed;
                    GridImage.Visibility = Visibility.Visible;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {

            }
        }
        
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Escape)
                {
                    ScrollViewerImages.Visibility = Visibility.Visible;
                    GridImage.Visibility = Visibility.Collapsed;
                }
                if (e.Key == Key.Up)
                {
                    if (WrapPanelImages.Children.Count > ImageIndex + 1)
                    {
                        ImageBig.Source = (WrapPanelImages.Children[++ImageIndex] as Image).Source;
                        ScrollViewerImages.Visibility = Visibility.Collapsed;
                        GridImage.Visibility = Visibility.Visible;
                    }
                }
                if (e.Key == Key.Down)
                {
                    if (ImageIndex > 0)
                    {
                        ImageBig.Source = (WrapPanelImages.Children[--ImageIndex] as Image).Source;
                        ScrollViewerImages.Visibility = Visibility.Collapsed;
                        GridImage.Visibility = Visibility.Visible;
                    }
                }
            }
            catch
            {

            }
        }

        private void ButtonUp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (WrapPanelImages.Children.Count > ImageIndex + 1)
                {
                    ImageBig.Source = (WrapPanelImages.Children[++ImageIndex] as Image).Source;
                    ScrollViewerImages.Visibility = Visibility.Collapsed;
                    GridImage.Visibility = Visibility.Visible;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {

            }
        }

        private void ButtonDown_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ImageIndex > 0)
                {
                    ImageBig.Source = (WrapPanelImages.Children[--ImageIndex] as Image).Source;
                    ScrollViewerImages.Visibility = Visibility.Collapsed;
                    GridImage.Visibility = Visibility.Visible;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {

            }
        }

        private void ButtonBlur_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(ImageBig.Effect != null)
                {
                    ImageBig.Effect = null;
                }
                else
                {   
                    BlurEffect be = new BlurEffect() { Radius = 5, KernelType = KernelType.Gaussian, RenderingBias = RenderingBias.Performance};
                    ImageBig.Effect = be;
                }
            }
            catch
            {

            }
        }
    }
}
