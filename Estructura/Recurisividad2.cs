using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura
{
    public partial class Recurisividad2 : Form
    {
        public Recurisividad2()
        {
            InitializeComponent();
        }

        private void Btn_Bu_Click(object sender, EventArgs e)
        {
            Class_Factorial obj_fac = new Class_Factorial();
            obj_fac.Pnum_Set(int.Parse(textBox2.Text));
            obj_fac.factorial();
            textBox3.Text = obj_fac.Pfac_Get() + "";


        }
    }
}
