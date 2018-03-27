using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Xamarin.Forms;

namespace VScroll
{
    public partial class MyPage : ContentPage
    {
        MyViewModel viewModel;

        public MyPage()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new MyViewModel();
        }
    }

    public class MyViewModel
    {
        public ObservableCollection<BookInfo> BooksInfo { private set; get; } = new ObservableCollection<BookInfo>();

        public MyViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                BookInfo bookInfo = new BookInfo("https://www.baidu.com/img/bd_logo1.png?where=super");
                BooksInfo.Add(bookInfo);
            }
        }
    }

    public class BookInfo
    {
        public string CoverImage { set; get; }

        public BookInfo(string image = null)
        {
            CoverImage = image;
        }
    }
}
