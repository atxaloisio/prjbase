using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjbase
{
    public partial class frmBase : Form, IDisposable
    {
        public virtual bool atualizagrid { get; set; }
        public virtual long? Id { get; set; }
        public frmBase()
        {
            InitializeComponent();
            atualizagrid = false;
            Id = null;
        }

        public virtual DialogResult ExibeDialogo(IWin32Window obj, long? pId)
        {
            Id = pId;
            return ShowDialog(obj);
        }
        public virtual DialogResult ExibeDialogo(IWin32Window obj)
        {
           return ShowDialog(obj);
        }

        public virtual DialogResult ExibeDialogo(long? pId)
        {
            Id = pId;
           return ShowDialog();
        }

        public virtual DialogResult ExibeDialogo()
        {            
           return ShowDialog();
        }                       
    }
}
