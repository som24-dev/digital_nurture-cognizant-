using Confluent.Kafka;
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static string bootstrapServers = "localhost:9092";
    static string topic = "chat";

    static async Task Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        var config = new ConsumerConfig
        {
            BootstrapServers = bootstrapServers,
            GroupId = $"{userName}-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        // Start background consumer task
        var cancellationTokenSource = new CancellationTokenSource();
        Task consumerTask = Task.Run(() =>
        {
            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe(topic);

            try
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var consumeResult = consumer.Consume(cancellationTokenSource.Token);
                    Console.WriteLine($"\n[Chat] {consumeResult.Message.Value}");
                    Console.Write("> ");
                }
            }
            catch (OperationCanceledException)
            {
                consumer.Close();
            }
        });

        // Create producer
        var producerConfig = new ProducerConfig { BootstrapServers = bootstrapServers };
        using var producer = new ProducerBuilder<Null, string>(producerConfig).Build();

        // Read and send messages
        Console.WriteLine("Type your messages below. Type 'exit' to quit.");
        while (true)
        {
            Console.Write("> ");
            string message = Console.ReadLine();

            if (message.ToLower() == "exit")
            {
                cancellationTokenSource.Cancel();
                break;
            }

            await producer.ProduceAsync(topic, new Message<Null, string> { Value = $"{userName}: {message}" });
        }

        await consumerTask;
    }
}
