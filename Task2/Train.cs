namespace Task2
{
    internal struct Train
    {
        public string destination;
        public int trainNumber;
        public DateTime departureTime;

        public Train(string destination, int trainNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }
    }
}
