using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using NStack;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LiteDB.Studio.ViewModels
{
    [DataContract]
    public class MainWindowViewModel : ViewModelBase
    {
        [IgnoreDataMember]
        public ReactiveCommand<Unit, Unit> ShowConnectWindowCommand { get; }

        [IgnoreDataMember]
        public ReactiveCommand<Unit, Unit> RefreshCommand { get; }
        [IgnoreDataMember]
        public ReactiveCommand<Unit, Unit> RunCommand { get; }
        [IgnoreDataMember]
        public ReactiveCommand<Unit, Unit> BeginCommand { get; }
        [IgnoreDataMember]
        public ReactiveCommand<Unit, Unit> CommitCommand { get; }
        [IgnoreDataMember]
        public ReactiveCommand<Unit, Unit> RollbackCommand { get; }
        [IgnoreDataMember]
        public ReactiveCommand<Unit, Unit> CheckpointCommand { get; }
        [IgnoreDataMember]
        public ReactiveCommand<Unit, Unit> DebugCommand { get; }

        public string Greeting => "Hello World!";
        public MainWindowViewModel()
        {

        }

    }
}
