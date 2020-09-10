using FastNotes.Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FastNotes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            this.EngLanguageButton.Click += LanguageChangedHandler;
            this.RusLanguageButton.Click += LanguageChangedHandler;
            this.UkrLanguageButton.Click += LanguageChangedHandler;
        }

        private void LanguageChangedHandler(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource.Equals(this.EngLanguageButton))
            {
                this.SettingsViewModel.HandleLanguageChangeEvent("en-US");
            }
            else if (e.OriginalSource.Equals(this.RusLanguageButton))
            {
                this.SettingsViewModel.HandleLanguageChangeEvent("ru-RU");
            }
            else if (e.OriginalSource.Equals(this.UkrLanguageButton))
            {
                this.SettingsViewModel.HandleLanguageChangeEvent("uk-UA");
            }
        }

        public SettingsViewModel SettingsViewModel { get; set; } = new SettingsViewModel();
    
    }
}
