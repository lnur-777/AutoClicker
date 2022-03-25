using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class KeyBoardEvent
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        private const int VK_CAPITAL = 0x14;
        private const int VK_OEM_PLUS = 0xBB;
        private const int VK_OEM_MINUS = 0xBD;
        private const int VK_CONTROL = 0x11;
        private const int VK_V = 0x56;
        private const int VK_TAB = 0x09;
        private const int VK_ALT = 0x12;

        public static void PressCapslock()
        {
            keybd_event(VK_CAPITAL, 0, KEYEVENTF_KEYDOWN, 0);
        }

        public static void PressControlPlus()
        {
            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_OEM_PLUS, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);
        }

        public static void PressControlMinus()
        {
            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_OEM_MINUS, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);
        }

        public static void PressControlAndV()
        {
            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_V, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);
        }

        public static void PressAltTAB()
        {
            keybd_event(VK_ALT, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_TAB, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_ALT, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
