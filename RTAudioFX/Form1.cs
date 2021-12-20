using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.DSP;
using CSCore.SoundIn;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTAudioFX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshDevices();
        }

        private void btnRefreshDevices_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void RefreshDevices()
        {
            cbInputDevice.Items.Clear();
            cbOutputDevice.Items.Clear();
            foreach (var device in MMDeviceEnumerator.EnumerateDevices(DataFlow.All))
            {
                if (device.DeviceState != DeviceState.Active)
                    continue;

                if (device.DataFlow == DataFlow.Capture && !cbInputDevice.Items.Contains(device))
                    cbInputDevice.Items.Add(device);
                else if (device.DataFlow == DataFlow.Render && !cbOutputDevice.Items.Contains(device))
                    cbOutputDevice.Items.Add(device);
            }

            cbInputDevice.SelectedIndex = 0;
            cbOutputDevice.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbInputDevice.SelectedItem == null || cbOutputDevice.SelectedItem == null)
                return;
            btnRefreshDevices.Enabled = btnStart.Enabled = cbInputDevice.Enabled = cbOutputDevice.Enabled = false;
            btnStop.Enabled = true;
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnRefreshDevices.Enabled = btnStart.Enabled = cbInputDevice.Enabled = cbOutputDevice.Enabled = true;
            btnStop.Enabled = false;
            Stop();
        }

        private WasapiCapture soundIn;
        private WasapiOut soundOut;
        private DelaySource delaySource;
        private PanSource panSource;
        private DmoWavesReverbEffect reverb;

        private void Start()
        {
            soundIn = new WasapiCapture(true, AudioClientShareMode.Shared, 30);
            soundIn.Device = (MMDevice)cbInputDevice.SelectedItem;
            soundIn.Initialize();
            soundIn.Start();

            var source = new SoundInSource(soundIn) { FillWithZeros = true };
            

            delaySource = new DelaySource(source.ToSampleSource());
            reverb = new DmoWavesReverbEffect(delaySource.ToWaveSource()) { ReverbTime = 600};
            panSource = new PanSource(reverb.ToSampleSource());

            soundOut = new WasapiOut();
            soundOut.Device = (MMDevice)cbOutputDevice.SelectedItem;
            soundOut.Initialize(panSource.ToWaveSource());
            soundOut.Play();
        }

        private void Stop()
        {
            if (soundIn != null)
            {
                soundIn.Stop();
                soundOut.Stop();
                soundIn.Dispose();
                soundOut.Dispose();

                soundIn = null;
                soundOut = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        private void tbDelay_Scroll(object sender, EventArgs e)
        {
            UpdateSource();
        }

        private void tbPan_Scroll(object sender, EventArgs e)
        {
            UpdateSource();
        }

        const float delayScale = 0.5f;
        const float panScale = 0.4f;

        private void UpdateSource()
        {
            var left = tbDelay.Value > 0 ? tbDelay.Value : 0;
            var right = tbDelay.Value < 0 ? -tbDelay.Value : 0;
            delaySource.LeftDelay = (int)(left * delayScale);
            delaySource.RightDelay = (int)(right * delayScale);
            panSource.Pan = -tbPan.Value / (float)tbPan.Maximum * panScale;
        }

        private void cb8D_CheckedChanged(object sender, EventArgs e)
        {
            timer.Enabled = cb8D.Checked;
        }

        int direction = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (tbDelay.Value < -240 || tbDelay.Value > 240)
            {
                direction *= -1;
            }

            tbDelay.Value += direction;
            tbPan.Value += direction;
            UpdateSource();
        }

        private void tbRoomSize_Scroll(object sender, EventArgs e)
        {
            reverb.ReverbTime = tbRoomSize.Value;
        }
    }
}
