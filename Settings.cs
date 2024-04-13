using System.Windows.Forms;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace AutoOpen;

public class Settings : ISettings
{
    public ToggleNode Enable { get; set; } = new(false);

    [Menu("Blacklist|Whitelist Key")]
    public HotkeyNode ToggleEntityKey { get; set; } = new(Keys.V);

    public ToggleNode BlockInputWhenClicking { get; set; } = new(true);
    public RangeNode<int> ClickDelay { get; set; } = new(1, 0, 100);

    public TypeSettings DoorSettings { get; set; } = new();
    [Menu("Switches/Levers")]
    public TypeSettings SwitchSettings { get; set; } = new();
    public TypeSettings ChestSettings { get; set; } = new();
    public TypeSettings ShrineSettings { get; set; } = new();
}

[Submenu]
public class TypeSettings
{
    public ToggleNode Open { get; set; } = new(true);
    public RangeNode<int> MaxDistance { get; set; } = new(150, 0, 300);
}