using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace VocabularyProNamespace
{
    class ClassModel : INotifyPropertyChanged
    {
        private ObservableCollection<DataObject<string>> meanings;

        public ObservableCollection<DataObject<string>> Meanings
        {
            get
            {
                return this.meanings;
            }

            set
            {
                this.meanings = value;
                this.sendPropertyChanged("Meanings");
            }
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void sendPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion
    }
}
