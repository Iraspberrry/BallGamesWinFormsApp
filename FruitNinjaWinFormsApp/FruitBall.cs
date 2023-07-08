using BallsGame.Common;

namespace FruitNinjaWinFormsApp
{
    public class FruitBall : FireworkStartBall
    {
        private float g = 0.2f;

        public FruitBall(Form form) : base(form)
        {
            radius = random.Next(10, 20);
            vy = -Math.Abs(random.Next(7, 14));
            vx = random.Next(-4, 4);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;

            OutsideOfForm();
        }
    }
}
