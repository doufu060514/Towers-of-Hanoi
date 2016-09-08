using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    public partial class MainForm : Form
    {
        private Disk[,] disks = new Disk[3, 4];
        private Board gameBoard;

        public MainForm()
        {
            InitializeComponent();
            this.AllowDrop = true;
            //create four disks
            Disk D1 = new Disk(label1, 0, 3, 0);
            Disk D2 = new Disk(label2, 0, 3, 0); 
            Disk D3 = new Disk(label3, 0, 3, 0);
            Disk D4 = new Disk(lblDisk4, 0, 3, 0);

            gameBoard = new Board(D1, D2, D3, D4);
        }

        private void label3_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Label aLabel = sender as Label;
            
            DragDropEffects result =
                    aLabel.DoDragDrop(0, DragDropEffects.All);

            //
            Label clickedLabel = (Label)sender;
            Disk clickedDisk = gameBoard.FindDisk(clickedLabel);
            Boolean canBeMoved = gameBoard.canStartMove(clickedDisk);

            if (canBeMoved)
            {

            }
            else { 
            
            }


        }

        private void lblPeg2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
