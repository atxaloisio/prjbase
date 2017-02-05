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
    public partial class frmBase : Form
    {
        public virtual bool atualizagrid { get; set; }
        public virtual long? Id { get; set; }
        public frmBase()
        {
            InitializeComponent();
            atualizagrid = false;
            Id = null;
        }

        public virtual void ExibeDialogo(IWin32Window obj, long? pId)
        {
            Id = pId;
            ShowDialog(obj);
        }
        public virtual void ExibeDialogo(IWin32Window obj)
        {
            ShowDialog(obj);
        }

        public virtual void ExibeDialogo(long? pId)
        {
            Id = pId;
            ShowDialog();
        }

        public virtual void ExibeDialogo()
        {            
            ShowDialog();
        }


    }
}
