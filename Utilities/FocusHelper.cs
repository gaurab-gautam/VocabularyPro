using System;
using System.Windows;
using System.Windows.Threading;
using System.Threading;
using System.Windows.Input;

namespace VocabularyProNamespace
{
    public static class FocusHelper
    {
        public static void Focus(UIElement element)
        {
            element.Dispatcher.BeginInvoke(DispatcherPriority.Input, new ThreadStart(delegate()
                {
                    element.Focus();
                    Keyboard.Focus(element);
                }));
        }
    }
}
