using BallsGame.Common;

namespace BilliardBallsWinFormsApp
{
    public partial class BilliardMainForm : Form
    {
        private List<Ball> Balls = new List<Ball>();

        public BilliardMainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new BilliardBall(this);
                ball.OnHited += Ball_OnHited; 
                ball.Start();
                Balls.Add(ball);
            }
        }
        
        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            { 
                case Side.Left:
                    leftLabel.Text = (int.Parse(leftLabel.Text) + 1).ToString();
                    break; 
                case Side.Right:
                    rightLabel.Text = (int.Parse(rightLabel.Text) + 1).ToString();
                    break; 
                case Side.Top:
                    topLabel.Text = (int.Parse(topLabel.Text) + 1).ToString();
                    break;
                case Side.Bottom:
                    bottomLabel.Text = (int.Parse(bottomLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}