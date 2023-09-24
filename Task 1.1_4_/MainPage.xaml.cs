namespace Task_1._1_4_
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSayHelloButtonClicked(object sender, EventArgs e)
        {
        
            outputLabel.Text = "Hello World!";
        }
    }
}