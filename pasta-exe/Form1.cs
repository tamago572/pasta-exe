using System.Diagnostics;
using System.Media;
using NAudio.Wave;

namespace pasta_exe
{
    public partial class Form1 : Form
    {
        private WaveOutEvent bgmPlayer;
        private WaveOutEvent pastaPlayer;
        private AudioFileReader bgmReader;
        private AudioFileReader pastaReader;

        public Form1()
        {
            InitializeComponent();
            bgmPlayer = new WaveOutEvent();
            pastaPlayer = new WaveOutEvent();
            bgmReader = null!;
            pastaReader = null!;

        }

        private async void playPastaBtn_Click(object sender, EventArgs e)
        {


            pastaReader.Position = 0;
            pastaPlayer.Play();
            bgmReader.Volume = 0.0f;
            await Task.Run(() =>
            {
                Thread.Sleep(pastaReader.TotalTime - TimeSpan.FromMilliseconds(420));
                bgmReader.Volume = 1.0f;
            });
        }

        private async void PastaPlayer_PlaybackStopped(object? sender, StoppedEventArgs e)
        {
            await Task.Run(() =>
            {
                //bgmReader.Volume = 1.0f;
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form1�̃��[�h���Ɏ��s����鏈��

            Debug.WriteLine("�A�v���J�������O");

            string currentFolderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string bgmPath = currentFolderPath + "pasta_bgm.wav";
            string pastaPath = currentFolderPath + "pasta.wav";

            Debug.WriteLine("bgmPath: " + bgmPath);

            try
            {
                bgmReader = new AudioFileReader(bgmPath);
                pastaReader = new AudioFileReader(pastaPath);


                bgmPlayer.Init(bgmReader);
                pastaPlayer.Init(pastaReader);

                bgmPlayer.Play();

                pastaPlayer.PlaybackStopped += PastaPlayer_PlaybackStopped;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("�G���[��������O" + ex.Message);
                MessageBox.Show("�����t�@�C���̓ǂݍ��݂Ɏ��s���܂����B" + ex.Message, "�G���[��������O", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            bgmPlayer?.Stop();
            pastaPlayer?.Stop();
            bgmReader?.Dispose();
            pastaReader?.Dispose();
            bgmPlayer?.Dispose();
            pastaPlayer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
