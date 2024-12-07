namespace WebUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.linkedin.com");
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void binanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.binance.com");
        }

        private void marketWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.marketwatch  .com");
        }

        private void globalNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.globalnews.com");
        }

        private void cNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.cnn.com");
        }

        private void theGuardianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.theguardian.com");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.medium.com");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.github.com");
        }

        private void ınstagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.instagram.com");
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.facebook.com");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.twitter.com");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com");
        }
    }
}
