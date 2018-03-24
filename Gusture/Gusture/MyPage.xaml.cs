using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Gusture
{
    public partial class MyPage : ContentPage
    {

        private bool IsShow { get; set; } = true;

        public MyPage()
        {
            InitializeComponent();
            var tap = new TapGestureRecognizer();
            tap.Command = new Command(() =>
            {
                if (IsShow)
                {
                    myLayout.TranslateTo(0, -200, 500, Easing.SpringOut);
                }
                else
                {
                    myLayout.TranslateTo(0, 0, 500, Easing.SpringIn);
                }
                IsShow = !IsShow;
            });
            myLayout.GestureRecognizers.Add(tap);

            var stackLayout = new StackLayout();
            var label = new Label()
            {
                Text = "你好, 你好， 你好， 你好你好",
            };
            stackLayout.Children.Add(label);
            myLayout.Children.Add(label);
        }
    }
}
