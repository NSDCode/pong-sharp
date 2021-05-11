using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class main : Form
    {

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        Player player = new Player();
        Ball ball = new Ball();
        DateTime _lastCheckTime = DateTime.Now;

        long _frameCount = 0;
        int[] score = {0, 0};

        public main()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint ,true);
            InitializeComponent();
            this.UpdateStyles();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void main_Load(object sender, EventArgs e)
        {
            ball.pos_x = this.Width / 2;
            ball.pos_y = this.Height / 2;

            InitBall();
            this.Focus();
            new Thread(new ThreadStart(Update)).Start();
        }


        private void InitBall()
        {
           Random rand = new Random();
           switch (rand.Next(0, 1))
           {
               case 0:
                   ball.speedX = -ball.speedX;
                   break;
               case 1:
                   ball.speedY = -ball.speedY;
                   break;
           }
        }

        internal void Update()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                Interlocked.Increment(ref _frameCount);

                player.pos_x = player1.Location.X;
                player.pos_y = player1.Location.Y;

                PredictBall();
                // calculate ball speed based on X and Y speed
                double ball_speed = (double)(ball.speedX + ball.speedY / 2) * 1000;

                fps_label.Text = $"fps: {GetFps()}";
                player1_coord_label.Text = $"player pos: ({player.pos_x},{player.pos_y})";
                ball_position_label.Text = $"ball pos: ({ball.pos_x},{ball.pos_y}) speed: {ball_speed.ToString().Replace("-", null)} pixels/s";

                Thread.Sleep(1);
            }
        }

        private void PredictBall()
        {
            // set the X position of the ball
            ball.pos_x += ball.speedX;
            // checks if the ball touch the left side
            if (ball.pos_x < 0)
            {
                //increase the score of the opponement and make tha ball bounce to the opposite direction
                score[1] += 1;
                ball.speedX = -ball.speedX;
            }

            // checks if the ball touch the right side
            if ((ball.pos_x + ball.width) > this.ClientSize.Width)
            {
                //increase the score of the opponement and make tha ball bounce to the opposite direction
                score[0] += 1;
                ball.speedX = -ball.speedX;
            }

            // set the Y position of the ball
            ball.pos_y += ball.speedY;
            // checks if the ball touch the up wall or down wall
            if (ball.pos_y < 0 || (ball.pos_y + ball.height) > this.ClientSize.Height)
            {
                ball.speedY = -ball.speedY;
            }

            // checks if the ball is touching the player1 and
            if (ball.pos_x + ball.width <= 
                player1.Location.X + player1.Width 
                && (ball.pos_y + ball.height) >= player1.Location.Y 
                && (ball.pos_y + ball.height) <= player1.Location.Y + player1.Height)
            {
                ball.speedX = -ball.speedX;
            }

            // checks if the ball is touching the player2
            if (ball.pos_x + ball.width >=
               player2.Location.X + player2.Width
               && (ball.pos_y + ball.height) >= player2.Location.Y
               && (ball.pos_y + ball.height) <= player2.Location.Y + player2.Height)
            {
                ball.speedX = -ball.speedX;
            }

            score_label.Text = $"{score[0]} - {score[1]}";
            this.Refresh();
        }


        private double GetFps()
        {
            double secondsElapsed = (DateTime.Now - _lastCheckTime).TotalSeconds;
            long count = Interlocked.Exchange(ref _frameCount, 0);
            double fps = count / secondsElapsed;
            _lastCheckTime = DateTime.Now;
            return Math.Round(fps);
        }

        private void main_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (player.pos_y > 0)
                    {
                        player1.Location = new Point(player.pos_x, player.pos_y - 10);
                    }
                    else
                    {
                        player1.Location = new Point(player.pos_x, 0);
                    }
                    break;
                case Keys.Down:
                    if (player.pos_y < this.Height - player1.Height)
                        player1.Location = new Point(player.pos_x, player.pos_y + 10);
                    break;

                case Keys.Enter:
                    debug_panel.Visible = !debug_panel.Visible;
                    break;
                case Keys.Delete:
                    this.Dispose();
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    break;
            }
        }

        private void DrawCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.White, ball.pos_x, ball.pos_y, ball.width, ball.height);

        }

        private void debug_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
