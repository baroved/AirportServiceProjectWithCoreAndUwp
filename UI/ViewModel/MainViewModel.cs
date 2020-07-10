using Common.Models;

using GalaSoft.MvvmLight;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Media;
using System.Windows.Threading;

namespace UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        HubConnection connection;

        public SolidColorBrush Color1 { get; set; }
        public SolidColorBrush Color2 { get; set; }
        Dispatcher dispatcher;
        public MainViewModel()
        {
            dispatcher = Dispatcher.CurrentDispatcher;
            ConnectToServer();
            
        }

        

        public void ConnectToServer()
        {
            connection = new HubConnectionBuilder()
                            .WithUrl("https://localhost:44393/hub")
                            .Build();
            connection.StartAsync().ContinueWith(async task =>
            {
                try
                {
                    connection.On<List<Station>>("UpdateAirport", (list) =>
                    {
                        dispatcher.Invoke(() =>
                          {
                              UpdateAirport(list);
                          }
                    );
                    });
                    await connection.InvokeAsync("IncomingFlight", new EstimatedTakeOff());

                }
                catch (Exception ex)
                {

                    throw;
                }

            });
        }



        public void UpdateAirport(List<Station> stations)
        {
            if (!stations[0].IsAvailable)
            {
                Color1 = new SolidColorBrush(Colors.Blue);
                RaisePropertyChanged("Color1");
            }

            if (!stations[1].IsAvailable)
            {
                Color1 = new SolidColorBrush(Colors.Blue);
                RaisePropertyChanged("Color2");
            }
        }
    }
}