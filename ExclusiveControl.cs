using System;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ExclusiveControl : UserControl
    {
        public RASDK.Arm.RoboticArm Arm;
        public RASDK.Gripper.IGripperController Gripper;
        public RASDK.Basic.LogHandler LogHandler;
        public RASDK.Basic.Message.MessageHandler MessageHandler;

        public ExclusiveControl()
        {
            InitializeComponent();
        }

        public Config Config { get; protected set; } = new Config();
    }
}