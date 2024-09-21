using System;
using Mars.Interfaces.Agents;
using Mars.Interfaces.Environments;

namespace OvercookedBox;

public class Spot : IPositionable, IEntity
{
    public Position Position { get; set; }
    public Guid ID { get; set; }
}