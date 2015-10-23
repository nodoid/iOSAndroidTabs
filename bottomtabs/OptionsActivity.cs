using Android.App;
using Android.OS;

namespace bottomtabs
{
    [Activity(Label = "OptionsActivity")]			
    public class OptionsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.OptionsPage);
        }
    }
}

