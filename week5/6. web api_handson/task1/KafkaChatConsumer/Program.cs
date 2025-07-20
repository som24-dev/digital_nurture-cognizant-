﻿using Confluent.Kafka;

class Program
{
    static void Main()
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe("chat-topic");

        Console.WriteLine("Kafka Chat Consumer - Waiting for messages...");

        while (true)
        {
            var message = consumer.Consume();
            Console.WriteLine($"Received: {message.Message.Value}");
        }
    }
}
