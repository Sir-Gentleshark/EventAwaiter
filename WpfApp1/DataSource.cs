using System;
using System.Security.Cryptography.X509Certificates;

namespace WpfApp1
{
    internal class DataSource
    {
        TaskCompletionSource<string>? tcs = null;
        DataWindow dataWindow;
        public async Task<string> GetData()
        {
            dataWindow = new DataWindow();
            tcs = new TaskCompletionSource<string>();
            dataWindow.IsEnabled = true;
            dataWindow.tcs = tcs;
            dataWindow.Show();

            await tcs.Task;

            return tcs.Task.Result;
        }
    }
}