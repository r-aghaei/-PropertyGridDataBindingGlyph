using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGridDataBindingGlyph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.exPropertyGrid1.DataBindings.Add("Anchor", this, "Anchor");
            this.exPropertyGrid1.DataBindings.Add("BackColor", this, "BackColor");
            this.exPropertyGrid1.DataBindings.Add("AccessibleRole", this, "AccessibleRole");
            this.exPropertyGrid1.SelectedObject = exPropertyGrid1;
        }
    }
}
