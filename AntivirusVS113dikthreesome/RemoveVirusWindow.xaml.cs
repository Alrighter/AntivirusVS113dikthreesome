
namespace AntivirusVS113dikthreesome
{
    public partial class RemoveVirusWindow
    {
        private static bool _active = false;

        public static bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public RemoveVirusWindow()
        {
            InitializeComponent();
            _active = true;
        }
    }
}
