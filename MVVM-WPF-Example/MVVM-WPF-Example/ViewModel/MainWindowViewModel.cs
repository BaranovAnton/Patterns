using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MVVM_WPF_Example.Model;

namespace MVVM_WPF_Example.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Book[] books;
        private Book selectedBook;
        public Book[] Books {
            get; private set;
        }
        public Book SelectedBook {
            get { return selectedBook; }
            set { 
                selectedBook = value;
                OnPropertyChanged("SelectedBook"); 
            }
        }

        public MainWindowViewModel ()
        {
            Books = Book.GetBooks();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string _propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(_propertyName));
        }
    }
}
