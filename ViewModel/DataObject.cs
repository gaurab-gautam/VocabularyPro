using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VocabularyProNamespace
{
    /// <summary>
    /// This class is generic in the sense that the data can be of any type
    /// While implementing this class, provide the generic data type
    /// and make changes to Model and Controller classes accordingly
    /// </summary>
    /// <typeparam name="T">T as generic object</typeparam>
    public class DataObject<T>
    {
        private T data;

        public T Data
        {
            get
            {
                return this.data;
            }

            set
            {
                this.data = value;
            }
        }

        public DataObject()
        {

        }

        public DataObject(T val)
        {
            this.Data = val;
        }
    }
}
