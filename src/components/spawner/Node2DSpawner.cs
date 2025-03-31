using Godot;
using System;

public partial class Node2DSpawner : SceneSpawner
{
    protected override Node InstanciateNewNode()
    {
		Node2D spawn = (Node2D) base.InstanciateNewNode();
		spawn.GlobalPosition = GlobalPosition;
        return spawn;
    }
}
