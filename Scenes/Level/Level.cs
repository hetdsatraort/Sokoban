using Godot;
using System;

public partial class Level : Node
{
	[Export] private TileMapLayer _tml;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print(_tml.GetUsedCells());
		GD.Print(_tml.GetUsedRect());
		GD.Print(_tml.GetUsedRect().GetCenter());

		// _tml.SetCell()

	}
}
