using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CardDemoXamarin
{
    public class MainPageViewModel: BindableObject
    {
        private string _cardNumber;
        private string _expiration;
        private string _cvc;

        public string CardNumber
        {
            get => _cardNumber;
            set
            {
                _cardNumber = value;
                OnPropertyChanged();
            }
        }

        public string Expiration
        {
            get => _expiration;
            set { _expiration = value; OnPropertyChanged();}
        }

        public string CVC
        {
            get => _cvc;
            set { _cvc = value; OnPropertyChanged();}
        }
    }
}
