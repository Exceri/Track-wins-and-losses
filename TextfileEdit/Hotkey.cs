using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TextfileEdit
{
    class Hotkey
    {
        public enum fsModifiers
        {
            Alt = 0x0001,
            Control = 0x0002,
            Shift = 0x0004,
            Window = 0x0008,
        }

        

        private IntPtr _hWnd;

        public Hotkey(IntPtr hWnd)
        {
            this._hWnd = hWnd;
        }

        public void RegisterHotKeys()
        {
            RegisterHotKey(_hWnd, 1, (uint)fsModifiers.Control, (uint)Keys.Left);
            RegisterHotKey(_hWnd, 2, (uint)fsModifiers.Control, (uint)Keys.Down);
            RegisterHotKey(_hWnd, 3, (uint)fsModifiers.Control, (uint)Keys.Right);
            RegisterHotKey(_hWnd, 4, (uint)fsModifiers.Alt, (uint)Keys.Left);
            RegisterHotKey(_hWnd, 5, (uint)fsModifiers.Alt, (uint)Keys.Down);
            RegisterHotKey(_hWnd, 6, (uint)fsModifiers.Alt, (uint)Keys.Right);
        }

        public void UnRegisterHotKeys()
        {
            UnregisterHotKey(_hWnd, 1);
        }

        #region WindowsAPI
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        #endregion
    }
}
