using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHome1_OOP_Lab
{
    public partial class PositionGuesserForm : Form
    {
        PositionGame positionGame;
        int counter = 1;

        public PositionGuesserForm()
        {
            InitializeComponent();
            positionGame = PositionGame.Instance;
        }

        private void buttonNorth_Click(object sender, EventArgs e)
        {
            positionGame.BinarySearch2D("North");
            listBoxCoordinates.Items.Add("(" + positionGame.currX + ", " + positionGame.currY + ")");
            counter++;
            labelCounter.Text = counter.ToString();
        }

        private void buttonNorthWest_Click(object sender, EventArgs e)
        {
            positionGame.BinarySearch2D("NorthWest");
            listBoxCoordinates.Items.Add("(" + positionGame.currX + ", " + positionGame.currY + ")");
            counter++;
            labelCounter.Text = counter.ToString();
        }

        private void buttonWest_Click(object sender, EventArgs e)
        {
            positionGame.BinarySearch2D("West");
            listBoxCoordinates.Items.Add("(" + positionGame.currX + ", " + positionGame.currY + ")");
            counter++;
            labelCounter.Text = counter.ToString();
        }

        private void buttonSouthWest_Click(object sender, EventArgs e)
        {
            positionGame.BinarySearch2D("SouthWest");
            listBoxCoordinates.Items.Add("(" + positionGame.currX + ", " + positionGame.currY + ")");
            counter++;
            labelCounter.Text = counter.ToString();
        }

        private void buttonSouth_Click(object sender, EventArgs e)
        {
            positionGame.BinarySearch2D("South");
            listBoxCoordinates.Items.Add("(" + positionGame.currX + ", " + positionGame.currY + ")");
            counter++;
            labelCounter.Text = counter.ToString();
        }

        private void buttonSouthEast_Click(object sender, EventArgs e)
        {
            positionGame.BinarySearch2D("SouthEast");
            listBoxCoordinates.Items.Add("(" + positionGame.currX + ", " + positionGame.currY + ")");
            counter++;
            labelCounter.Text = counter.ToString();
        }

        private void buttonEast_Click(object sender, EventArgs e)
        {
            positionGame.BinarySearch2D("East");
            listBoxCoordinates.Items.Add("(" + positionGame.currX + ", " + positionGame.currY + ")");
            counter++;
            labelCounter.Text = counter.ToString();
        }

        private void buttonNorthEast_Click(object sender, EventArgs e)
        {
            positionGame.BinarySearch2D("NorthEast");
            listBoxCoordinates.Items.Add("(" + positionGame.currX + ", " + positionGame.currY + ")");
            counter++;
            labelCounter.Text = counter.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            positionGame.Reset();
            listBoxCoordinates.Items.Clear();
            listBoxCoordinates.Items.Add("(0, 0)");
            counter = 1;
            labelCounter.Text = "1";
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
