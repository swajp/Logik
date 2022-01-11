using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logik
{
    public partial class Form1 : Form
    {
        private Combination[] combinations;
        public Form1()
        {
            InitializeComponent();
            SetDefaults();
        }
        private void SetDefaults()
        {
            combinations = new Combination[9];

            for (int i = 0; i < combinations.Length; i++)
            {
                combinations[i] = new Combination();
            }

        }

        private void pBox_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < combinations.Length; i++)
            {
                var size = 35;
                combinations[i].Draw(e.Graphics,new PointF(10,10+i* size * 1.25F), size);
            }
        }
    }
}
