using Xamarin.Forms;

namespace TestAsyncFunsion.Views
{
    public partial class TestExpander : ContentPage
    {
        public TestExpander()
        {
            InitializeComponent();
        }

        private void Accordion_Collapsed(object sender, Syncfusion.XForms.Accordion.ExpandedAndCollapsedEventArgs e)
        {
            var value = e.Index.ToString();
            DisplayAlert("Index", value, "ok");
        }
        //Chạm vào thì hiển thị thông tin
        private void Accordion_Expanding(object sender, Syncfusion.XForms.Accordion.ExpandingAndCollapsingEventArgs e)
        {
            var value = e.Index.ToString();
            DisplayAlert("Index", value, "ok");
        }
        //khi đang hiển thị chạm vào là hiển thị thông tin cột nào
        private void Accordion_Collapsing(object sender, Syncfusion.XForms.Accordion.ExpandingAndCollapsingEventArgs e)
        {
            var value = e.Index.ToString();
            DisplayAlert("Index", value, "ok");
        }

        //private void Accordion_Collapsed(object sender, Syncfusion.XForms.Accordion.ExpandedAndCollapsedEventArgs e)
        //{
        //    var value = e.Index.ToString();
        //    DisplayAlert("Index", value, "ok");
        //}
    }
}
