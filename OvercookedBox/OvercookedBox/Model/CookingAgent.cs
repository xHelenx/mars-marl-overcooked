using System;
using Mars.Interfaces.Agents;

namespace OvercookedBox;

public class CookingAgent : IAgent<Kitchen> 
{
    public void Init(Kitchen layer) 
    {
        // finalize the init process
    }
    
    public void Tick() 
    {
        // define your logic here
    }
    
    public Guid ID { get; set; }
}