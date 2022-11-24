using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using OrderFoodApp1;
using OrderFoodApp1.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry),typeof(CustomEntryRendererAndriod))]


namespace OrderFoodApp1.Droid
{
      class CustomEntryRendererAndriod : EntryRenderer
    {
        public CustomEntryRendererAndriod(Context context): base(context)
        {

        }
        CustomEntry CustomEntry;
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                CustomEntry = (CustomEntry)e.NewElement;
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(CustomEntry.EntryCornerRadius);
               /* gradientDrawable.SetStroke(25, CustomEntry.EntryBorderColor.ToAndroid())*/;
                Control.SetBackground(gradientDrawable);






            }
        }
    }
}