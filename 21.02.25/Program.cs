﻿namespace _21._02._25;

public delegate void Notify(string message);

public class EventPublisher
{
    public event Notify OnNotify;
    
    public void RaiseEvent(string message)
    {
        OnNotify?.Invoke(message);
    }


}

public class EventSubscriber
{
    public void OnEventRaised(string message)
    {
        Console.WriteLine($"trololol event: {message}");
    }


}

class Program
{
    static void Main(string[] args)
    {
        EventPublisher publisher = new EventPublisher();
        EventSubscriber subscriber = new EventSubscriber();
        publisher.OnNotify += subscriber.OnEventRaised;

        publisher.RaiseEvent("test");

        Console.ReadKey();
        Console.WriteLine("Hello, World!");
    }
}
