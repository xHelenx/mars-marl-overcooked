using System;
using System.IO;
using Mars.Components.Starter;
using Mars.Interfaces.Model;
using OvercookedBox;

public class Program
{
    public static void Main(string[] args)
    {
        var description = new ModelDescription();

        description.AddLayer<Kitchen>();
        //  description.AddLayer<Layer2>();
        //  description.AddAgent<Agent1, Layer1>();
        
        // Load the simulation configuration from a JSON configuration file
        var file = File.ReadAllText("config.json");
        var config = SimulationConfig.Deserialize(file);

        // Couple model description and simulation configuration
        var starter = SimulationStarter.Start(description, config);

        // Run the simulation
        var handle = starter.Run();
        
        // Close the program
        Console.WriteLine("Successfully executed iterations: " + handle.Iterations);
        starter.Dispose();
    
    }
}