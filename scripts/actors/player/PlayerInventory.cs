using Godot;
using System;

public partial class PlayerInventory : Node
{
  [Export] public ItemInventory inventory { get; set; } = null;
}
