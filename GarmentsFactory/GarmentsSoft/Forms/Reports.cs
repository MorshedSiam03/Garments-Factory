using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarmentsSoft.Forms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
            //label6.ForeColor = ThemeColor.PrimaryColor;
            //label7.ForeColor = ThemeColor.PrimaryColor;
            //label8.ForeColor = ThemeColor.PrimaryColor;
            //label9.ForeColor = ThemeColor.PrimaryColor;
            //label10.ForeColor = ThemeColor.PrimaryColor;
            //label11.ForeColor = ThemeColor.PrimaryColor;



            //panel1.BackColor = ThemeColor.SecondaryColor;
        }
    }
}
