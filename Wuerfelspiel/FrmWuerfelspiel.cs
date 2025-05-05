using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class FrmWuerfelspiel : Form
    {
        //Timer spielTimer;
        //Rectangle becher;
        //public FrmWuerfelspiel()
        //{
        //    InitializeComponent();
        
        //    this.KeyPreview = true;

        //    ResizeRedraw = true;
        //    DoubleBuffered = true;

        //    becher = new Rectangle(50, 50, 100, 100);

        //    spielTimer = new Timer();
        //    spielTimer.Interval = 10000;
        //    spielTimer.Tick += SpielTimer_Tick;
        //    spielTimer.Start();

        //    this.KeyDown += FrmWuerfelspiel_KeyDown;
        //}

        //private void FrmWuerfelspiel_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;

        //    Pen black = new Pen(Color.Black, 2);
        //    Brush brown = new SolidBrush(Color.SaddleBrown);

        //    g.FillEllipse(brown, becher);           
        //    g.DrawEllipse(black, becher);
        //}

        //private void FrmWuerfelspiel_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Right)
        //    {
        //        becher.X += 50;
        //        Invalidate();
        //    }

        //    if(e.KeyCode == Keys.Left)
        //    {
        //        becher.X -= 50;
        //        Invalidate();
        //    }
  
            
        //}

        //private void SpielTimer_Tick(object sender, EventArgs e)
        //{

        //}
        
    }
}