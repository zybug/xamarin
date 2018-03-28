using Xamarin.Forms;

namespace ChangeBinding
{
    public partial class ChangeBindingPage : ContentPage
    {

        private MainViewModel viewModel;
        public ChangeBindingPage()
        {
            InitializeComponent();
            Title = "Segmented Control";

            this.BindingContext = viewModel = new MainViewModel();
        }

        void Handle_ValueChanged(object sender, SegmentedControl.FormsPlugin.Abstractions.ValueChangedEventArgs e)
        {
            var i = e.NewValue;
            viewModel.ChangeModelType(i);

            //switch (e.NewValue)
            //{
                //case 0:
                //    SegContent.Children.Clear();
                //    SegContent.Children.Add(new Label() { Text = "Items tab selected" });
                //    break;
                //case 1:
                //    SegContent.Children.Clear();
                //    SegContent.Children.Add(new Label() { Text = "Notes tab selected" });
                //    break;
                //case 2:
                //    SegContent.Children.Clear();
                //    SegContent.Children.Add(new Label() { Text = "Approvers tab selected" });
                //    break;
                //case 3:
                    //SegContent.Children.Clear();
                    //SegContent.Children.Add(new Label() { Text = "Attachments tab selected" });
                    //break;
            //}
        }
    }
}
