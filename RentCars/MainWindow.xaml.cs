using Newtonsoft.Json;
using RentCars.Models;
using RentCars.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Xml.Serialization;

namespace RentCars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        private List<Car> cars { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            cars = CarsService.GetCars();
            ShowCars();
        }

        private void ShowCars()
        {
            foreach(Car c in cars)
            {
                Border b = new Border
                {
                    BorderBrush = Brushes.LightGray,
                    BorderThickness = new Thickness(1),
                    CornerRadius = new CornerRadius(10),
                    Margin = new Thickness(10)
                };
                StackPanel st = new StackPanel
                {
                    Height = 200,
                    Width = 250,
                    Orientation = Orientation.Horizontal
                };
                DockPanel.SetDock(st, Dock.Top);
                Label lb = new Label
                {
                    Margin = new Thickness(10),
                    VerticalContentAlignment = VerticalAlignment.Center,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    Content = c.Model
                };
                DockPanel.SetDock(lb, Dock.Top);
                Image img = new Image
                {
                    Margin = new Thickness(10, 0, 0, 0),
                    Source = new BitmapImage(new Uri(c.Photo, UriKind.Relative))
                };

                Button btn = new Button
                {
                    Margin = new Thickness(10),
                    Padding = new Thickness(10),
                    VerticalContentAlignment = VerticalAlignment.Center,
                    HorizontalContentAlignment = HorizontalAlignment.Center
                };
                btn.Click += BookCar;
                btn.Content = "Забронировать";
                DockPanel.SetDock(btn, Dock.Bottom);

                StackPanel sp = new StackPanel();
                sp.Children.Add(lb);
                sp.Children.Add(img);
                st.Children.Add(sp);
                st.Children.Add(btn);
                b.Child = st;
                CarsPanel.Children.Add(b);
                var t = 0;
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void ShowCars(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
        private void ShowInfo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/InfoPage.xaml", UriKind.Relative));
        }

        private void BookCar(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BookPage.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }

}

