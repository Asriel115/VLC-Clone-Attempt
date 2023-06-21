using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private WaveOutEvent audioDevice;
        private AudioFileReader reader;
        private String audioFileLocation;
        public Form1()
        {
            InitializeComponent();
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            audioDevice.Dispose();
            audioDevice = null;
            reader.Dispose();
            reader = null;
        }
        private void StartPlayback_Click(object sender, EventArgs e)
        {

            if (audioDevice == null)
            {
                audioDevice = new WaveOutEvent();
                audioDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (reader == null)
            {
                reader = new AudioFileReader(audioFileLocation);
                audioDevice.Init(reader);
            }
            audioDevice.Play();

        }

        private void StopPlayback_Click(object sender, EventArgs e)
        {
            audioDevice?.Stop();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            audioFileLocation = openFileDialog1.FileName;
        }

        private void waveViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string file = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
            if (file.Contains(".mp3"))
            {
                audioFileLocation = file;
                button1.Text += file;
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void waveViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}