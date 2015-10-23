using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace bottomtabs
{
    [Activity(Label = "TabSample", MainLauncher = true, Icon = "@mipmap/icon")]			
    public class TabSample : TabActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            SetupTabs();
        }

        void SetupTabs()
        {
            AddTab("Home", Resource.Drawable.tab_home, typeof(ArrowsActivity));
            AddTab("Search", Resource.Drawable.tab_search, typeof(OptionsActivity));

            AddTab("Home", Resource.Drawable.tab_home, typeof(ArrowsActivity));
            AddTab("Search", Resource.Drawable.tab_search, typeof(OptionsActivity));
        }

        void AddTab(string labelId, int drawableId, System.Type c)
        {
            var tabHost = TabHost;
            var intent = new Intent(this, c);
            TabHost.TabSpec spec = tabHost.NewTabSpec(string.Format("tab{0}", labelId)); 

            var tabIndicator = LayoutInflater.From(this).Inflate(Resource.Layout.tab_indicator, TabWidget, false);
            var title = tabIndicator.FindViewById<TextView>(Resource.Id.title);
            title.Text = labelId;
            var icon = tabIndicator.FindViewById<ImageView>(Resource.Id.icon);
            icon.SetImageResource(drawableId);

            spec.SetIndicator(tabIndicator);
            spec.SetContent(intent);
            tabHost.AddTab(spec);
        }
    }
}

