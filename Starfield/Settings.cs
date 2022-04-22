using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Starfield
{
    public partial class Settings : Form
    {
        private int starsCount;
        private Brush color;
        public static UnityContainer Container { get; set; }
        public Settings()
        {
            InitializeComponent();
            starsCount = 10000;
            color = Brushes.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Container = new UnityContainer();
                  
            
            starsCount = int.Parse(comboBox1.Text);
            if(comboBox2.SelectedIndex == 0)
            {
                color = Brushes.Red;
            }
            else if(comboBox2.SelectedIndex == 1)
            {
                color = Brushes.Yellow;
            }
            else if(comboBox2.SelectedIndex == 2)
            {
                color = Brushes.Purple;
            }
            else if(comboBox2.SelectedIndex == 3)
            {
                color = Brushes.Blue;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                color = Brushes.Plum;
            }
            Container.RegisterInstance(starsCount);
            Container.RegisterInstance(color);
            Container.Resolve<Form1>().Show();
        }
    }
}
