using FastNotes.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNotes
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        public SettingsViewModel()
        {
            this.engLanguageLabel = InterfaceResources.Label_Language_Eng;
            this.rusLanguageLabel = InterfaceResources.Label_Language_Rus;
            this.ukrLanguageLabel = InterfaceResources.Label_Language_Ukr;
        }

        private string engLanguageLabel;
        private string rusLanguageLabel;
        private string ukrLanguageLabel;

        public string EngLanguageLabel
        {
            get => this.engLanguageLabel;
            set
            {
                this.engLanguageLabel = value;
                OnPropertyChanged();
            }
        }

        public string RusLanguageLabel
        {
            get => this.rusLanguageLabel;
            set
            {
                this.rusLanguageLabel = value;
                OnPropertyChanged();
            }
        }

        public string UkrLanguageLabel
        {
            get => this.ukrLanguageLabel;
            set
            {
                this.ukrLanguageLabel = value;
                OnPropertyChanged();
            }
        }

        public void HandleLanguageChangeEvent(string language)
        {
            InterfaceResources.Culture = new System.Globalization.CultureInfo(language);
            this.EngLanguageLabel = InterfaceResources.Label_Language_Eng;
            this.RusLanguageLabel = InterfaceResources.Label_Language_Rus;
            this.UkrLanguageLabel = InterfaceResources.Label_Language_Ukr;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
