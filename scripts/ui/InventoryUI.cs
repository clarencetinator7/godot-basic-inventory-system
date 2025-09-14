using Godot;
using System;

public partial class InventoryUI : Control
{
  private ItemInventory playerInventoryResource = GD.Load<ItemInventory>("res://resources/data/Player/PlayerInventory.tres");
  private GridContainer gridContainer;

  public override void _Ready()
  {
    gridContainer = GetNode<GridContainer>("NinePatchRect/GridContainer");
    Godot.Collections.Array<InventorySlot> slots = GetInventorySlots();

    for (int i = 0; i < slots.Count; i++)
    {
      if (playerInventoryResource.items[i] != null)
      {
        slots[i].SetItem(playerInventoryResource.items[i]);
      }
    }
  }
  public override void _Input(InputEvent @event)
  {
    if (@event.IsActionPressed("ui_toggle_inventory"))
    {
      toggleInventoryVisibility();
    }
  }

  public void toggleInventoryVisibility()
  {
    Visible = !Visible;
  }

  private Godot.Collections.Array<InventorySlot> GetInventorySlots()
  {
    Godot.Collections.Array<InventorySlot> slots = new Godot.Collections.Array<InventorySlot>();
    foreach (Node child in gridContainer.GetChildren())
    {
      if (child is InventorySlot slot)
      {
        slots.Add(slot);
      }
    }
    return slots;
  }
}
