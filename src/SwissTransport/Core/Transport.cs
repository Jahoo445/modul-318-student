namespace SwissTransport.Core
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using SwissTransport.Models;

    public class Transport : ITransport, IDisposable
    {
        private const string WebApiHost = "https://transport.opendata.ch/v1/";

        private readonly HttpClient httpClient = new HttpClient();

        public async Task<Stations> GetStationsAsync(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new ArgumentNullException(nameof(query));
            }

            var uri = new Uri($"{WebApiHost}locations?query={query}");
            return await this.GetObjectAsync<Stations>(uri)
                .ConfigureAwait(false);
        }

        public Stations GetStations(string query) => this.GetStationsAsync(query)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

        public async Task<StationBoardRoot> GetStationBoardAsync(string station)
        {
            if (string.IsNullOrEmpty(station))
            {
                throw new ArgumentNullException(nameof(station));
            }


            var uri = new Uri($"{WebApiHost}stationboard?station={station}");
            return await this
                .GetObjectAsync<StationBoardRoot>(uri)
                .ConfigureAwait(false);
        }

        public StationBoardRoot GetStationBoard(string station) =>
            this.GetStationBoardAsync(station)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

        public async Task<Connections> GetConnectionsAsync(string fromStation, string toStation, int isArrivalTime, DateTime date, DateTime time)
        {
            if (string.IsNullOrEmpty(fromStation))
            {
                throw new ArgumentNullException(nameof(fromStation));
            }

            if (string.IsNullOrEmpty(toStation))
            {
                throw new ArgumentNullException(nameof(toStation));
            }

            var uri = new Uri($"{WebApiHost}connections?from={fromStation}&to={toStation}&isArrivalTime={isArrivalTime}&date={date}&time={time}");
            return await this.GetObjectAsync<Connections>(uri)
                .ConfigureAwait(false);
        }

        public Connections GetConnections(string fromStation, string toStation, int isArrivalTime, DateTime date, DateTime time) =>
            this.GetConnectionsAsync(fromStation, toStation, isArrivalTime, date, time)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

        public void Dispose()
        {
            this.httpClient?.Dispose();
        }

        private async Task<T> GetObjectAsync<T>(Uri uri)
        {
            HttpResponseMessage response = await this.httpClient
                .GetAsync(uri)
                .ConfigureAwait(false);
            string content = await response.Content
                .ReadAsStringAsync()
                .ConfigureAwait(false);

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}