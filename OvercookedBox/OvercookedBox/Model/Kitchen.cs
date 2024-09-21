using System;
using Mars.Components.Environments;
using Mars.Components.Layers;
using Mars.Interfaces.Data;
using Mars.Interfaces.Layers;

namespace OvercookedBox;

public class Kitchen : RasterLayer
{

    public override bool InitLayer(LayerInitData layerInitData, RegisterAgent registerAgentHandle,
        UnregisterAgent unregisterAgentHandle)
    {
        var initLayer = base.InitLayer(layerInitData, registerAgentHandle, unregisterAgentHandle);
        var map = new SpatialHashEnvironment<Spot>(Height, Width);
        Console.Out.WriteLine(map);
        
        /*
        SimpleAgentEnvironment = new SpatialHashEnvironment<SimpleAgent>(Width, Height);
        ComplexAgentEnvironment = new SpatialHashEnvironment<ComplexAgent>(Width, Height);

        var agentManager = layerInitData.Container.Resolve<IAgentManager>();

        SimpleAgents = agentManager.Spawn<SimpleAgent, GridLayer>().ToList();
        ComplexAgents = agentManager.Spawn<ComplexAgent, GridLayer>().ToList();
        HelperAgents = agentManager.Spawn<HelperAgent, GridLayer>().ToList();
         */

        return initLayer;
    }
}