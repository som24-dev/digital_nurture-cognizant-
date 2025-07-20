using Confluent.Kafka;

class Program
{
    static async Task Main()
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Kafka Chat - Type your message (type 'exit' to quit):");

        while (true)
        {
            string? message = Console.ReadLine();
            if (message?.ToLower() == "exit") break;

            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
            Console.WriteLine($"Sent: {message}");
        }
    }
}
