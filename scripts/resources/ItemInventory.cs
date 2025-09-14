using Godot;
using System;

[GlobalClass]
public partial class ItemInventory : Resource
{
  // [Export] public int inventorySize { get; set; } = 15;
  [Export] public Godot.Collections.Array<Item> items;

}
