using System;

using Xamarin.Forms;
using System.Linq;

namespace VScroll
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page itemsPage, aboutPage = null;
            Page myPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    itemsPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    };

                    myPage = new NavigationPage(new MyPage())
                    {
                        Title = "MyPage"
                    };

                    itemsPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";
                    myPage.Icon = "tab_feed.png";
                    break;
                default:
                    itemsPage = new ItemsPage()
                    {
                        Title = "Browse"
                    };

                    aboutPage = new AboutPage()
                    {
                        Title = "About"
                    };

                    myPage = new MyPage()
                    {
                        Title = "MyPage"
                    };

                    break;
            }

            Children.Add(itemsPage);
            Children.Add(aboutPage);
            Children.Add(myPage);

            Title = Children.LastOrDefault().Title;
            this.CurrentPage = Children.LastOrDefault();
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
