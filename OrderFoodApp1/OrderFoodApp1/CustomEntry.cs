using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Forms;
using Color = System.Drawing.Color;

namespace OrderFoodApp1
{
    public class CustomEntry:Entry
    {
        public static readonly BindableProperty CornerRadiusProperty =
        BindableProperty.Create("CornerRadius", typeof(int),typeof(CustomEntry),0);
        public int EntryCornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
       // public static readonly BindableProperty BorderColorProperty =
       //BindableProperty.Create("BorderThickness", typeof(Color), typeof(CustomEntry),Color.White);
       // public Color EntryBorderColor
       // {
       //     get { return (Color)GetValue(BorderColorProperty); }
       //     set { SetValue(BorderColorProperty, value); }
       // }
        //public static readonly BindableProperty ImageProperty=
        //    BindableProperty.Create(nameof(Image), typeof(Image), typeof(CustomEntry),typeof(String));
        //public static readonly BindableProperty LineColorProperty=
        //    BindableProperty.Create(nameof(LineColor),typeof(Xamarin.Forms.Color),typeof(CustomEntry), Color.White);
        //public static readonly BindableProperty ImageHeightProperty =
        //    BindableProperty.Create(nameof(ImageHeight), typeof(int), typeof(CustomEntry), 40);
        //public static readonly BindableProperty ImageWidthProperty =
        //    BindableProperty.Create(nameof(ImageWidth), typeof(int), typeof(CustomEntry), 40);
       
        //public Color LineColor
        //{
        //    get { return (Color)GetValue(LineColorProperty); }
        //    set { SetValue(LineColorProperty, value); }
        //}
        //public int ImageHeight
        //{
        //    get { return (int)GetValue(ImageHeightProperty); }
        //    set { SetValue(ImageHeightProperty, value); }
        //}
        //public int ImageWidth
        //{
        //    get { return (int)GetValue(ImageWidthProperty); }
        //    set
        //    {
        //        SetValue(ImageWidthProperty, value);
        //    }
        //}
        //public string Image
        //{
        //    get { return (string)GetValue(ImageProperty); }
        //    set
        //    {
        //        SetValue(ImageProperty, value);
        //    }
        //}
        
            
       












    }
}
