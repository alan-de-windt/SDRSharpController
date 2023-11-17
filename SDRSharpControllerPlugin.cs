using System.Windows.Forms;
using SDRSharp.Common;

namespace SDRSharp.SDRSharpController
{
    public class SDRSharpControllerPlugin : ISharpPlugin, ICanLazyLoadGui, ISupportStatus, IExtendedNameProvider
    {
        private ControlPanel _gui;
        private ISharpControl _control;
        public string DisplayName => "SDRSharp Controller";
        
        public string Category => "Misc";
        
        public string MenuItemName => DisplayName;
        
        public bool IsActive => _gui != null && _gui.Visible;

        public UserControl Gui
        {
            get
            {
                LoadGui();
                return _gui;
            }
        }

        public void LoadGui()
        {
            if (_gui == null)
            {
                _gui = new ControlPanel(_control);
            }
        }

        public void Initialize(ISharpControl control)
        {
            _control = control;
        }

        public void Close()
        {
        }
    }
}
