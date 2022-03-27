using System.Runtime.InteropServices;

namespace NXUI_CSharp
{
    public class Lib
    {
        [DllImport("nxui.dll", EntryPoint = "initialize")]
        public static extern bool initialize();
    }
}
