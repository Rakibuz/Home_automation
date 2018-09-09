using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Final
{
    public partial class HomeControll : Form
    {
        SerialPort myport = new SerialPort("COM5"); // port initialization 


        SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer receng = new SpeechSynthesizer();

        public HomeControll()
        {
            InitializeComponent();

            try
            {
                //hook to events
                speechRecognitionEngine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(engine_AudioLevelUpdated);
                speechRecognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);

                //Load dictionary
                LoadGrammarAndCommands();

                //use the system's default microphone
                speechRecognitionEngine.SetInputToDefaultAudioDevice();

                //start listening
                speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
                receng.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(receng_SpeakCompleted);

                if (receng.State == SynthesizerState.Speaking)
                    receng.SpeakAsyncCancelAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "voice recognition failed");
            }

        }

        private void receng_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void LoadGrammarAndCommands()
        {
            try
            {
                Choices Text = new Choices();
                string[] Lines = File.ReadAllLines(Environment.CurrentDirectory + "\\homectrl.txt");
                Text.Add(Lines);
                Grammar WordsList = new Grammar(new GrammarBuilder(Text));
                speechRecognitionEngine.LoadGrammar(WordsList);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
            String Speech = e.Result.Text;
            switch (Speech)
            {
                case "hello computer":
                   // Global.wake = false;
                    receng.Speak("How may i help you");
                    break;
                case "Turn ON Light":
                   // Global.wake = false;
                    receng.Speak("ok turning on Light");
                    btn_led1_on.PerformClick();
                    break;
                case "Turn OFF Light":
                    receng.Speak("ok turning off Light");
                    btn_led1_off.PerformClick();
                    break;
                case "Turn ON Fan":
                    Global.wake = false;
                    receng.Speak("ok turning on Fan");
                    btn_fan_on.PerformClick();
                    break;
                case "Turn OFF Fan":              
                    receng.Speak("ok turning off Fan");
                    btn_fan_off.PerformClick();
                    break;
                case "Close Home Controll":
                    Global.wake = true;
                    receng.SpeakAsyncCancelAll();
                    receng.Speak("Ok closing home controll");
                    this.Close();
                    myport.Close();
                    break;            
            }
        }

        private void engine_AudioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e)
        {
            progressBar1.Value = e.AudioLevel;
        }

        private void btn_led1_on_Click(object sender, EventArgs e)
        {
            try
            {   
                myport.Write("0");//send 1 to Arduino
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HomeControll_Load(object sender, EventArgs e)
        {
            //SerialPort myport = new SerialPort();
              myport.Open();
        }

        private void btn_led1_off_Click(object sender, EventArgs e)
        {
            try
            {
                myport.Write("1"); //send 0 to Arduino
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_fan_on_Click(object sender, EventArgs e)
        {
            try
            {
                // fan controll which is connected with 12 pin             
                myport.Write("2");//send 2 to Arduino
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_fan_off_Click(object sender, EventArgs e)
        {
            // fan controll which is connected with 11 pin
            try
            {
                myport.Write("3"); //send 3 to Arduino
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
