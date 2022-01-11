namespace SwissTransport.Core
{
    using System;
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Task<Stations> GetStationsAsync(string query);

        Stations GetStations(string query);

        Task<StationBoardRoot> GetStationBoardAsync(string station);

        StationBoardRoot GetStationBoard(string station);

        Task<Connections> GetConnectionsAsync(string fromStation, string toStation, int isArrivalTime, DateTime date, DateTime time);

        Connections GetConnections(string fromStation, string toStation, int isArrivalTime, DateTime date, DateTime time);
    }
}