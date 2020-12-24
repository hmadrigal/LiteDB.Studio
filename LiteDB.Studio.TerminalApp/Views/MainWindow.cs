using System.Reactive.Disposables;
using System.Reactive.Linq;
using LiteDB.Studio.ViewModels;
using NStack;
using ReactiveUI;
using Terminal.Gui;

namespace LiteDB.Studio.Views
{
    public class MainWindow : Window, IViewFor<MainWindowViewModel>
    {
        readonly CompositeDisposable _disposable = new CompositeDisposable();

        public MainWindow(MainWindowViewModel mainWindowViewModel) : base("LiteDB.Studio")
        {
            this.ViewModel = mainWindowViewModel;
        }

        protected override void Dispose(bool disposing)
        {
            _disposable.Dispose();
            base.Dispose(disposing);
        }

        #region IViewFor<MainWindowViewModel>
        public MainWindowViewModel ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (MainWindowViewModel)value;
        }
        #endregion

    }
}
