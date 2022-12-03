using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace _03._12_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("response.json", FileMode.OpenOrCreate))
            {
                Weather weather = await JsonSerializer.DeserializeAsync<Weather>(fs);
                WeatherFrom.Content = $"Погода за: {weather.now}";
                Season.Content = $"Сезон: {weather.season}";
                FeelsLike.Content = $"Ощущается как: {weather.feels_like}";
                Temp.Content = $"Температура: {weather.temp}";
                Name.Content = $"Место: {weather.info.tzinfo.name}";

            }
        }
    }
}
