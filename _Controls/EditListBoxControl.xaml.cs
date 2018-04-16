using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VocabularyProNamespace
{
    /// <summary>
    /// Interaction logic for EditListBoxControl.xaml
    /// </summary>
    public partial class EditListBoxControl : UserControl
    {
        private  ClassController _controller;
        private ClassModel model;
        
        public EditListBoxControl()
        {
            // This constructor is unusable but is included just to make
            // drag and drop of the user control possible during design.
            // After dropping this user control on the designer, an 
            // empty string must be passed to call the other overridden
            // constructor or array of string as applicable
            this._controller = new ClassController(null);
            InitializeComponent();
            DataContext = this; InitializeComponent();
        }

        public EditListBoxControl(string[] data)
        {
            this._controller = new ClassController(data);
            InitializeComponent();
            DataContext = this;
        }


        // return the meaning list as array of strings
        public string[] GetMeanings()
        {
            DataObject<string> []data =  this.model.Meanings.ToArray<DataObject<string>>();
            List<string> list = new List<string>();

            foreach (DataObject<string> d in data)
            {
                if (d.Data != String.Empty)
                {
                    list.Add(d.Data);
                }
            }

            return list.ToArray<string>();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            model = this.Resources["model"] as ClassModel;
            this._controller.Initialize(model);
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.grid1.Focus();
        }

        private void lbMeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (e.OriginalSource is ListBoxItem)
                {
                    ListBoxItem lbi = (ListBoxItem)e.OriginalSource;
                    EditableTextBlockControl etb = getEditableTextBlock(lbi);

                    if (etb != null)
                    {
                        etb.IsEditMode(etb.txtBlkMeaning, true);
                    }
                }
            }
        }

        private childItem FindVisualChild<childItem>(DependencyObject obj)
            where childItem : DependencyObject
        {
            for (int i = 0; i < System.Windows.Media.VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = System.Windows.Media.VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is childItem)
                    return (childItem)child;
                else
                {
                    childItem childOfChild = FindVisualChild<childItem>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        private EditableTextBlockControl getEditableTextBlock(ListBoxItem selectedLVI)
        {
            // Getting the ContentPresenter of TreeViewItem
            ContentPresenter myContentPresenter = FindVisualChild<ContentPresenter>(selectedLVI);
            
            if (myContentPresenter == null)
                return null;

            // Finding EditableTextBlock from the DataTemplate that is set on that ContentPresenter
            DataTemplate myDataTemplate = myContentPresenter.ContentTemplate;
            EditableTextBlockControl editBox = myDataTemplate.FindName("myEditableTextBlockControl", myContentPresenter) as EditableTextBlockControl;
            
            return editBox;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            DataObject<string> data = btn.DataContext as DataObject<string>;
            if (data != null)
            {
                ClassModel model = this.Resources["model"] as ClassModel;
                model.Meanings.Remove(data);
            }
        }


        public static T FindAncestor<T>(DependencyObject from)
            where T : class
        {
            if (from == null)
            {
                return null;
            }

            T candidate = from as T;
            if (candidate != null)
            {
                return candidate;
            }

            return FindAncestor<T>(VisualTreeHelper.GetParent(from));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Button addBtn = sender as Button;
            DataObject<string> data = new DataObject<string>("");

            if ((this.model.Meanings.Count > 0) &&
                (this.model.Meanings.Last<DataObject<string>>().Data != ""))
            {
                // add an empty Data Object
                this.model.Meanings.Add(data);
                this.lbMeaning.UpdateLayout();

                ListBoxItem lbi = (ListBoxItem)this.lbMeaning.ItemContainerGenerator.ContainerFromItem(data);                
                EditableTextBlockControl etb = getEditableTextBlock(lbi);

                if (etb != null)
                {
                    etb.IsEditMode(etb.txtBlkMeaning, true);
                }
            }
            else if ((this.model.Meanings.Count > 0) &&
                     (this.model.Meanings.Last<DataObject<string>>().Data == ""))
            {
                ListBoxItem lbi = (ListBoxItem)this.lbMeaning.ItemContainerGenerator.ContainerFromItem(
                    this.model.Meanings.Last<DataObject<string>>());
                EditableTextBlockControl etb = getEditableTextBlock(lbi);

                if (etb != null)
                {
                    etb.IsEditMode(etb.txtBlkMeaning, true);
                    FocusHelper.Focus(etb.txtMeaning);
                }

            }
            else if (this.model.Meanings.Count <= 0)
            {
                // add an empty data
                this.model.Meanings.Add(data);
                this.lbMeaning.UpdateLayout();

                ListBoxItem lbi = (ListBoxItem)this.lbMeaning.ItemContainerGenerator.ContainerFromItem(data);
                EditableTextBlockControl etb = getEditableTextBlock(lbi);

                if (etb != null)
                {
                    etb.IsEditMode(etb.txtBlkMeaning, true);
                    FocusHelper.Focus(etb.txtMeaning);
                }
            }
        }
    }
}
