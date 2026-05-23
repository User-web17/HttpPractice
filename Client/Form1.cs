// WebPage with styles for panel
using Microsoft.Web.WebView2.WinForms;

namespace Client
{
    public partial class Form1 : Form
    {
        private WebView2 web;

        public Form1()
        {
            InitializeComponent();

            // Creating and initializing Dockstyle(full filling of the form)
            web = new WebView2();
            web.Dock = DockStyle.Fill;

            panel.Controls.Add(web);

            Load += Form1_Load;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            // Microsoft Edge Engine
            await web.EnsureCoreWebView2Async();
        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            using HttpClient client = new HttpClient();

            try
            {
                string html = await client.GetStringAsync(txtUrl.Text);

                web.NavigateToString(html);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}