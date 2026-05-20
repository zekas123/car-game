using System.Media;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private Point pos;
        private bool dragging;
        private bool louse = false;
        private int coins = 0;
        public Form1()
        {
            InitializeComponent();

            bg1.MouseDown += MouseClickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;

            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;
            labelLouse.Visible = false;
            btnrestart.Visible = false;
            KeyPreview = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + bg1.Top);
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 10;
            bg1.Top += speed;
            bg2.Top += speed;

            int carspeed = 10;
            enemy1.Top += carspeed;
            enemy2.Top += carspeed;

            coin.Top += speed;

            if (bg1.Top >= 650)
            {
                bg1.Top = 0;
                bg2.Top = -650;
            }

            if (coin.Top >= 650)
            {
                Random rand = new Random();
                int x = rand.Next(150, 700);
                coin.Location = new Point(x, -100);
            }


            if (enemy1.Top >= 650)
            {
                Random rand = new Random();
                int x = rand.Next(150, 700);
                enemy1.Location = new Point(x, -100);
            }

            if (palyer.Bounds.IntersectsWith(enemy1.Bounds) || palyer.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Stop();
                labelLouse.Visible = true;
                btnrestart.Visible = true;
                louse = true;

            }

            if (palyer.Bounds.IntersectsWith(coin.Bounds))
            {
                coins ++;
                labelcoins.Text = $"Coins: {coins}";
                Random rand = new Random();
                int x = rand.Next(150, 700);
                coin.Location = new Point(x, -100);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;

            if (louse)
                return;



            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && palyer.Left > 150)
                palyer.Left -= speed;


            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && palyer.Right < 700)
                palyer.Left += speed;

            else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && palyer.Top > 30)
                palyer.Top -= speed;

            else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && palyer.Bottom < 650)
                palyer.Top += speed;
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -130;
            enemy2.Top = -400;
            labelLouse.Visible = false; 
            btnrestart.Visible = false;
            timer.Enabled = true;
            louse = false;
            coins = 0;
            labelcoins.Text = $"Coins: {coins}";
            coin.Top = -500;

        }
    }
}
