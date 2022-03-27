using System.Runtime.InteropServices;

namespace NXUI_CSharp
{
    public class Nxui
    {
        [DllImport("nxui.dll", EntryPoint = "create_new_app")]
        public static extern bool create_new_app();
    }
}
