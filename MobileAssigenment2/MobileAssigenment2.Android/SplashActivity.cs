using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace MobileAssigenment2.Droid
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startupwork = new Task(() => { SimulateStartup(); });
            startupwork.Start();
        }

        async void SimulateStartup()
        {
            await Task.Delay(100);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}