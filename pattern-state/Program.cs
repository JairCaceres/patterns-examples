using pattern_state.Context;

public class Program
{
    static void Main(string[] args)
    {
        var trafficLight = new TrafficLight();

        Console.WriteLine("Initial state");

        trafficLight.StopTraffic();
        trafficLight.WarningTraffic();
        trafficLight.ContinueTraffic();


        Console.WriteLine("Final state");
    }
}