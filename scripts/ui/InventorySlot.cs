using Godot;
using System;

public partial class InventorySlot : Panel
{

  TextureRect itemTexture;
  public override void _Ready()
  {
	itemTexture = GetNode<TextureRect>("ItemTexture");
  }
  public void SetItem(Item item)
  {
	itemTexture.Texture = item.icon;
	itemTexture.Visible = true;
  }

}
