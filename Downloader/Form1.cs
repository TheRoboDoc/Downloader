using Downloader.Properties;
using System.Diagnostics;

namespace Downloader
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string path = "C:\\";

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FolderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void FileDialogButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FolderBrowserDialog.ShowDialog();
            this.Enabled = true;
            path = FolderBrowserDialog.SelectedPath;
            FileLocation.Text = path;
        }

        private void StartDownload_Click(object sender, EventArgs e)
        {
            StartDownload.Enabled = false;

            this.pictureBox1.Image = Resources.RobitThink;
            WaitingText.Text = "Please Wait...";

            string format = FormatSelect.Text;

            if (string.IsNullOrEmpty(format))
            {
                format = "webm";
            }

            string arguments;

            if (format == "mp3")
            {
                arguments = $"-f bestaudio --recode-video mp3 ";
            }
            else if (format != "webm")
            {
                arguments = $"--recode-video {format} ";
            }
            else
            {
                arguments = "";
            }

            arguments = arguments + $"-o \"{path}\\%(title)s [%(id)s].%(ext)s\" \"{LinkInput.Text}\"";

            _ = Task.Run(async () =>
            {
                ProcessStartInfo ytdlpStartInfo = new ProcessStartInfo()
                {
                    FileName = Application.StartupPath + "yt-dlp.exe",
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process? ytdlp = new Process();

                ytdlp.StartInfo = ytdlpStartInfo;

                ytdlp.Exited += Ytdlp_Exited;

                ytdlp.OutputDataReceived += Ytdlp_OutputDataReceived;
                ytdlp.ErrorDataReceived += Ytdlp_OutputDataReceived;

                ytdlp.Start();
                ytdlp.BeginOutputReadLine();
                ytdlp.BeginErrorReadLine();

                await ytdlp.WaitForExitAsync();

                BeginInvoke(new Action(() =>
                {
                    consoleOutputbox.AppendText($"Download completed, file can be found at {path}" + Environment.NewLine);
                    consoleOutputbox.AppendText("Opening..." + Environment.NewLine);
                }));

                ProcessStartInfo explorerStartInfo = new ProcessStartInfo()
                {
                    FileName = "explorer.exe",
                    Arguments = path
                };

                Process.Start(explorerStartInfo);
            });
        }

        private void Ytdlp_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data))
            {
                return;
            }

            BeginInvoke(new Action(() =>
            {
                consoleOutputbox.AppendText(e.Data + Environment.NewLine);
            }));
        }

        private void Ytdlp_Exited(object? sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                WaitingText.Text = "Standing By...";
                pictureBox1.Image = Resources.Robo_Meme_The_bois;
                StartDownload.Enabled = true;
            }));
        }

        private bool isMoving = false;
        private Point initialMousePos;
        private Point initialWindowPos;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMoving = true;
                initialMousePos = Control.MousePosition;
                initialWindowPos = this.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                int deltaX = Control.MousePosition.X - initialMousePos.X;
                int deltaY = Control.MousePosition.Y - initialMousePos.Y;
                this.Location = new Point(initialWindowPos.X + deltaX, initialWindowPos.Y + deltaY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMoving = false;
            }
        }
    }
}