using BallsGame.Common;
using Timer = System.Windows.Forms.Timer;

namespace FireworkWinFormsApp
{
    public partial class FireworkForm : Form
    {
        private List<Ball> nightSky = new List<Ball>();

        private int ballsMinimumNumber = 10;
        private int ballsMaximumNumber = 30;

        private Timer nightSkyTimer = new Timer();
        private Random random = new Random();


        public FireworkForm()
        {
            InitializeComponent();

            nightSky = NightSky.GetSky(this);

            nightSkyTimer.Interval = 10;
            nightSkyTimer.Tick += ShowNightSky;
            nightSkyTimer.Start();
        }

        private void ShowNightSky(object? sender, EventArgs e)
        {
            foreach (var ball in nightSky)
            {
                ball.Show();
            }
        }

        private async void FireworkForm_MouseDown(object sender, MouseEventArgs e)
        {
            var startFirework = new FireworkStartBall(this);
            startFirework.Start();
            while (startFirework.GetCenterY() > startFirework.GetHeight())
            {
                startFirework.Move();
                await Task.Delay(10);
            }

            var ballsCount = random.Next(ballsMinimumNumber, ballsMaximumNumber);
            startFirework.Stop();

            for (int i = 0; i < ballsCount; i++)
            {
                var fireworkBall = new FireworkBall(this, startFirework.GetCenterX(), startFirework.GetHeight());
                fireworkBall.Start();
            }
        }
        private void FireworkForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Нажимай на форму!");
        }
    }
}