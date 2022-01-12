namespace SwissTransport
{
    using System;
    using System.Threading.Tasks;
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public async Task LocationsAsync()
        {
            Stations stations = await this.testee.GetStationsAsync("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public async Task StationBoardAsync()
        {
            StationBoardRoot stationBoard = await this.testee.GetStationBoardAsync("Sursee");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void StationBoard()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public async Task ConnectionsAsync()
        {
            DateTime dateTime = DateTime.Now;
            Connections connections = await this.testee.GetConnectionsAsync("Sursee", "Luzern", 1, dateTime, dateTime);

            connections.Should().NotBeNull();
        }

        [Fact]
        public void Connections()
        {
            DateTime dateTime = DateTime.Now;
            Connections connections = this.testee.GetConnections("Sursee", "Luzern", 1, dateTime, dateTime);

            connections.Should().NotBeNull();
        }
    }
}