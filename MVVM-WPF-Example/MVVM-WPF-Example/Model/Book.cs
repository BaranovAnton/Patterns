using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVM_WPF_Example.Model
{
    public class Book : INotifyPropertyChanged
    {
        string author;
        string title;

        public string Author {
            get { return author; }
            set {
                author = value;
                OnPropertyChanged("Author");
            }
        }

        public string Title {
            get { return title; }
            set {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public static Book[] GetBooks()
        {
            return new[]
            {
                new Book() {Author = "Лев Толстой", Title = "Война и мир"},
                new Book() {Author = "Михаил Булгаков", Title = "Мастер и Маргарита"},
                new Book() {Author = "Стивен Кинг", Title = "Оно"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string _propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(_propertyName));
        }
    }
}
