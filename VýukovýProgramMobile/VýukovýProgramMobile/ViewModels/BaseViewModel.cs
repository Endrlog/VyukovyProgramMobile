using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace VýukovýProgramMobile.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        private static string topic;
        public string Topic
        {
            get => topic;
            set { SetProperty(ref topic, value); }
        }
        private static int score;
        public int Score
        {
            get => score;
            set { SetProperty(ref score, value); }
        }
        private static int lives;
        public int Lives
        {
            get => lives;
            set { SetProperty(ref lives, value); }
        }
        private static string question;
        public string Question
        {
            get => question;
            set { SetProperty(ref question, value); }
        }
        private static string answer;
        public string Answer
        {
            get => answer;
            set { SetProperty(ref answer, value); }
        }
        private static Dictionary<string, string> questions;
        public Dictionary<string, string> Questions
        {
            get => questions;
            set { SetProperty(ref questions, value); }
        }
        public static Dictionary<string, string> B = new Dictionary<string, string>();
        public static Dictionary<string, string> L = new Dictionary<string, string>();
        public static Dictionary<string, string> M = new Dictionary<string, string>();
        public static Dictionary<string, string> P = new Dictionary<string, string>();
        public static Dictionary<string, string> S = new Dictionary<string, string>();
        public static Dictionary<string, string> V = new Dictionary<string, string>();
        public static Dictionary<string, string> Z = new Dictionary<string, string>();
        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
