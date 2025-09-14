using Godot;
using System;

[GlobalClass]
public partial class Item : Resource
{
  [Export] public string itemName { get; set; } = "New Item";
  [Export] public Texture2D icon { get; set; } = null;
  [Export] public int maxStack { get; set; } = 1;
}
