using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    abstract class CommandBase
    {
        protected ToolStripItem[] controls;
        protected CommandBase(params ToolStripItem[] controls)
        {
            this.controls = controls;
        }

        public abstract void excute();
    }

    class EnanbleCommand : CommandBase
    {
        public EnanbleCommand(params ToolStripItem[] controls) : base(controls)
        {
        }

        public override void excute()
        {
            foreach (var control in controls)
            {
                control.Enabled = true;
            }
        }
    }

    class DisableCommand : CommandBase
    {
        public DisableCommand(params ToolStripItem[] controls) : base(controls)
        {
        }

        public override void excute()
        {
            foreach (var control in controls)
            {
                control.Enabled = false;
            }
        }
    }
}
