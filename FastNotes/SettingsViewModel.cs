using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNotes
{
    class SettingsViewModel : INotifyPropertyChanged
    {
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
