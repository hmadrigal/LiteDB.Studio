
using System;
using System.Reactive.Concurrency;
using LiteDB.Studio.TerminalApp.Views;
using LiteDB.Studio.ViewModels;
using ReactiveUI;
using Terminal.Gui;

namespace LiteDB.Studio.TerminalApp
{
    class Program
    {
        public static Action running = MainApp;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            while (running != null)
            {
                running.Invoke();
            }
            Application.Shutdown();
        }


        static void MainApp()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            if (System.Diagnostics.Debugger.IsAttached)
                System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            Application.Init();

            RxApp.MainThreadScheduler = TerminalScheduler.Default;
            RxApp.TaskpoolScheduler = TaskPoolScheduler.Default;

            Application.Run(new LoginView(new LoginViewModel()));
        }
    }
}
