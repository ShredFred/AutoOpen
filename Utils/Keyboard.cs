using System.Runtime.InteropServices;

namespace AutoOpen.Utils;

internal class Keyboard
{
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int nVirtKey);

    public static bool IsKeyPressed(int key)
    {
        return GetAsyncKeyState(key) == -32767;
    }
}