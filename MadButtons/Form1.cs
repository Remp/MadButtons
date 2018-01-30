using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RunningButtons
{
    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;
        Thread t3;

        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            t1 = new Thread(MovementBMW);
            t2 = new Thread(MovementFerrari);
            t3 = new Thread(MovementLamborgini);
            t1.IsBackground = t2.IsBackground = t3.IsBackground = true;
            t1.Start();
            t2.Start();
            t3.Start();

        }

        void MovementBMW()
        {
            while (true)
            {
                btnBMW.Location = new Point(btnBMW.Location.X + r.Next(3) + 1, btnBMW.Location.Y);
                Thread.Sleep(100); 
            }
            
        }

        void MovementFerrari()
        {
            while (true)
            {
                btnFerrari.Location = new Point(btnFerrari.Location.X + r.Next(3) + 1, btnFerrari.Location.Y);
                Thread.Sleep(100);
            }
        }

        void MovementLamborgini()
        {
            while (true)
            {
                btnLamborgini.Location = new Point(btnLamborgini.Location.X + r.Next(3) + 1, btnLamborgini.Location.Y);
                Thread.Sleep(100);
            }
        }
    }
}





