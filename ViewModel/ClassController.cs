using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VocabularyProNamespace
{
    class ClassController
    {
        private ClassModel model;

        private DataObject<string>[] _data;

        public ClassController()
        {

        }

        public ClassController(string[] data)
        {
            _data = new DataObject<string>[data.Length];
            int i = 0;

            foreach (string s in data)
            {
                _data[i++] = new DataObject<string>(s);
            }
        }

        public void Initialize(ClassModel model)
        {
            this.model = model;
            this.model.Meanings = new System.Collections.ObjectModel.ObservableCollection<DataObject<string>>
            (new List<DataObject<string>>(this._data));
        }
    }
}
