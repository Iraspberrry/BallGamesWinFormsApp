

namespace BallsGame.Common
{
    public class FireworkStartBall : MoveBall
    {
        private int height;
        private int marginFromSideForm = 50;
        public FireworkStartBall(Form form) : base(form)
        {
            centerY = form.ClientSize.Height;
            centerX = random.Next(marginFromSideForm, form.ClientSize.Width - marginFromSideForm);
            height = random.Next(marginFromSideForm, form.ClientSize.Height - marginFromSideForm);
            radius = 5;

            vx = 0f;
            vy = -1f;
            color = ColorHelper.GetRandomColor();
        }
        public int GetHeight()
        {
            return height;
        }
    }
}
