namespace Navegador_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.Source = new Uri("https://www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text; 
            if (!url.StartsWith("http"))
            {
                url = "https://" + url; 
            }
            webView21.Source = new Uri(url); 
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            
        }
    }
}


