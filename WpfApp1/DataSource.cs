using System;
using System.Security.Cryptography.X509Certificates;

namespace WpfApp1
{
    internal class DataSource
    {
        TaskCompletionSource<string>? tcs = null;
        Window1 dataWindow;
        public async Task<string> GetData()
        {
            dataWindow = new Window1();
            tcs = new TaskCompletionSource<string>();
            dataWindow.IsEnabled = true;
            dataWindow.tcs = tcs;
            dataWindow.Show();

            await tcs.Task;

            return tcs.Task.Result;
        }
    }
}