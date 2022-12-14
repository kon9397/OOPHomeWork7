namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrainByUserChoose();
        }

        static Train[] Trains()
        {
            return new Train[]
            {
                new Train("Odesa", 23, new DateTime(2022, 7, 1, 15, 0, 0)),
                new Train("Kyiv", 12, new DateTime(2022, 7, 1, 14, 54, 0)),
                new Train("Lviv", 10, new DateTime(2022, 7, 1, 23, 12, 0)),
                new Train("Mykolaiev", 1, new DateTime(2022, 7, 1, 8, 43, 0)),
                new Train("Chernihiv", 3, new DateTime(2022, 7, 1, 19, 16, 0)),
                new Train("Kaminets-Podolski", 6, new DateTime(2022, 7, 1, 15, 0, 0)),
                new Train("Kharkiv", 9, new DateTime(2022, 7, 1, 16, 24, 0)),
                new Train("Odesa", 32, DateTime.Now),
            };
        }

        static void TrainByUserChoose()
        {
            Console.WriteLine("Enter the train number");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());

            var train = TrainByUserInput(userInputNumber);

            Console.WriteLine(train);
        }

        static string TrainByUserInput(int userInputNumber)
        {
            var trains = Trains();

            var existTrain = trains.Where(a => a.trainNumber == userInputNumber).SingleOrDefault();

            return existTrain.destination == null ? "No trains found!" : string.Format($"Train: {existTrain.destination}, Train number: {existTrain.trainNumber}, Departure time: {existTrain.departureTime}");
        }
    }
}