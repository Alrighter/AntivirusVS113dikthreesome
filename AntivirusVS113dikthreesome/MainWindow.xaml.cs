using System.Windows;


namespace AntivirusVS113dikthreesome
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private RemoveVirusWindow _window1;

        private void RemoveVirusButton_OnClick(object sender, RoutedEventArgs e)
        {
            _window1 = new RemoveVirusWindow();
            _window1.Show();

        }

        private void SecurityStatusButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (RemoveVirusWindow.Active)
            {
                MessageBox.Show("Ваш комп'ютер під захистом!");
            }
            else
            {
                MessageBox.Show("Рекомендуємо ввімкнити захист! \n\n\nВін увімкнеться автоматично після перевірки та знищення потенційних загроз на вашому комп'ютері!");
            }
        }

        private void InfoButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Створено для запобігання появи нових та знешкодження старих вірусів пов'язаних з діяльністю рабі та його шайки\n\nby https://t.me/alrighter \n\nЗа підтримки https://t.me/theporoshenko \n\n                                                Version 1.0 (release)");

        }
    }
}
