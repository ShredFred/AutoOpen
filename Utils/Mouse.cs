using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using ExileCore;

namespace AutoOpen.Utils;

internal class Mouse
{
    public const int DELAY_MOVE = 5;
    public const int DELAY_CLICK = 5;

    [DllImport("user32.dll")]
    private static extern bool BlockInput(bool block);

    public static void MoveMouse(Vector2 pos)
    {
        Input.SetCursorPos(pos);
        Thread.Sleep(DELAY_MOVE);
    }

    public static void LeftDown(int delay)
    {
        Input.LeftDown();
        Thread.Sleep(DELAY_CLICK + delay);
    }

    public static void LeftUp(int delay)
    {
        Input.LeftUp();
        Thread.Sleep(DELAY_CLICK + delay);
    }

    public static void blockInput(bool block)
    {
        BlockInput(block);
    }
}