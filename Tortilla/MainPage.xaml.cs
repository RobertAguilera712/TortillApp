using System;

namespace Tortilla
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async Task RandomAnimation(View view)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            switch (randomNumber)
            {
                case 1:
                    await FadeInOut(view);
                    break;
                case 2:
                    await ScaleUpDown(view);
                    break;
                case 3:
                    await Rotate(view);
                    break;
                case 4:
                    await Rotate(view);
                    break;
                case 5:
                    await SlideInOut(view);
                    break;
                case 6:
                    await Pulse(view); // Perform the "Pulse" animation
                    break;
                case 7:
                    await Shake(view);
                    break;
                case 8:
                    await Flip(view);
                    break;
                case 9:
                    await Bounce(view);
                    break;
                case 10:
                    await Spin(view);
                    break;
                default:
                    break;
            }
        }


        private async void animateBtn_Clicked(object sender, EventArgs e)
        {
            await RandomAnimation(tortillaImage);
        }

        private async Task FadeInOut(View view)
        {
            await view.FadeTo(0, 1000);
            await view.FadeTo(1, 1000);
        }

        private async Task ScaleUpDown(View view)
        {
            await view.ScaleTo(1.2, 500);
            await view.ScaleTo(1, 500);
        }

        private async Task Rotate(View view)
        {
            await view.RotateTo(360, 1000);
            view.Rotation = 0;
        }


        private async Task SlideInOut(View view)
        {
            await view.TranslateTo(200, 0, 1000);
            await view.TranslateTo(0, 0, 1000);
        }

        private async Task Pulse(View view)
        {
            await view.ScaleTo(1.1, 500);
            await view.ScaleTo(1, 500);
        }

        private async Task Shake(View view)
        {
            await view.TranslateTo(-20, 0, 100);
            await view.TranslateTo(20, 0, 100);
            await view.TranslateTo(-10, 0, 100);
            await view.TranslateTo(10, 0, 100);
            await view.TranslateTo(-5, 0, 100);
            await view.TranslateTo(5, 0, 100);
            view.TranslationX = 0;
        }

        private async Task Flip(View view)
        {
            await view.RotateYTo(180, 1000);
            await view.RotateYTo(0, 1000);
        }

        private async Task Bounce(View view)
        {
            await view.TranslateTo(0, -50, 250);
            await view.TranslateTo(0, 0, 250);
        }

        private async Task Spin(View view)
        {
            await view.RotateTo(360, 1000);
            view.Rotation = 0;
        }

    }

}
