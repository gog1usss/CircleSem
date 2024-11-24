using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class fMain : Form
    {
        
        public fMain()
        {
            InitializeComponent();
            circles = new CCircle[100];
        }

        CCircle[] circles;
        int CircleCount = 0;
        int CurrentCircleIndex;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(0, 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Expand(5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(10, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(-10, 0);
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (CircleCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }
            Graphics graphics = pnMain.CreateGraphics();
            CurrentCircleIndex = CircleCount;
            circles[CurrentCircleIndex] = new CCircle(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);
            circles[CurrentCircleIndex].Show();
            CircleCount++;
            cbCircles.Items.Add("Коло № " + (CircleCount - 1).ToString());
            cbCircles.SelectedIndex = CircleCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(0, -10);
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            if ((CurrentCircleIndex >= CircleCount) || (CurrentCircleIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
