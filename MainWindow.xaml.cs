using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private KeyBoardHook _listener;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmailSender emailSender = new EmailSender();
            emailSender.to = mailTo.Text;
            emailSender.body = textMail.Text;
            Click.Background = Brushes.Red;
            MediaOperator media = new MediaOperator();
            media.soundPlay();
            emailSender.emailsend();          
        }

        private void HideApp_Click(object sender, RoutedEventArgs e)
        {         
            this.Hide();
        }

        
        
        private void textMail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _listener = new KeyBoardHook();
            _listener.OnKeyPressed += _listener_OnKeyPressed;

            _listener.HookKeyboard();

            // P.D. Przeanalizować kod
        }

        void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            if(Keyboard.IsKeyDown(Key.A))
            {
                this.Show();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _listener.UnHookKeyboard();
        }
    }
}
