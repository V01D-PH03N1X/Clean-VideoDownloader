using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDLSharp;

namespace CleanVideoDownloader
{
    public partial class Form1 : Form
    {
        //Klassen Imports
        private KonamiSequence konami = new KonamiSequence();
        private YoutubeDL ytdl = new YoutubeDL();
        private YoutubeDLProcess ytdlproc = new YoutubeDLProcess();

        //Global Variablen
        private bool dashboardVisibility = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Grundkonfigurationen für Design
            openAnimation.SetAnimateWindow(this);
            ShadowForm.SetShadowForm(this);
            dragBar.SetDrag(dragPanel); 
        }

        private void btn_Exit(object sender, EventArgs e)
        {
            //Beenden Abfrage
            DialogResult = MessageBox.Show("Bist du dir sicher dass du die Anwendung beenden möchtest?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboardControl(object sender, EventArgs e)
        {
            // GUI Animationen nach drücken des Buttons des Dashboardes
            if (dashboardVisibility == true)
            {
                fade.Hide(tB_Link, true);
                fade.Hide(prgressBar, true);
                fade.HideSync(btn_Download, true);
                swipe.HideSync(dashboardPanel);
                
                dashboardPanel.ShadowDecoration.Enabled = false;
                dashboardPanel.Location = new Point(-140, 45);
                dashboardControlButton.Text = ">";
                dashboardVisibility = false;
                
                tB_Link.Location = new Point(65, 60);
                tB_Link.Size = new Size(725, 35);

                prgressBar.Location = new Point(273, 100); ;
                prgressBar.Size = new Size(515, 45);

                btn_Download.Location = new Point(65, 102);
                
                swipe.ShowSync(dashboardPanel, true);
                fade.Show(tB_Link, true);
                fade.Show(prgressBar, true);
                fade.ShowSync(btn_Download, true);

                dashboardPanel.ShadowDecoration.Enabled = true;
                
                
            }
            else
            {
                fade.Hide(tB_Link, true);
                fade.Hide(prgressBar, true);
                fade.HideSync(btn_Download, true);
                swipe.HideSync(dashboardPanel);
                
                dashboardPanel.ShadowDecoration.Enabled = false;
                dashboardPanel.Location = new Point(0, 45);
                dashboardControlButton.Text = "<";
                dashboardVisibility = true;
                
                tB_Link.Location = new Point(210, 60);
                tB_Link.Size = new Size(580, 35);
                
                prgressBar.Location = new Point(415, 100);
                prgressBar.Size = new Size(370, 45);

                btn_Download.Location = new Point(205, 100);
                
                swipe.ShowSync(dashboardPanel, true);
                fade.Show(tB_Link, true);
                fade.Show(prgressBar, true);
                fade.ShowSync(btn_Download, true);

                dashboardPanel.ShadowDecoration.Enabled = true;
                

            }

        }

        private void about(object sender, EventArgs e)
        {
            MessageBox.Show("Version:1.3.5\nDeveloped by: DarkModz-Official\n\n\n Es wird die YouTube-DL importiert!", "CleanVideoDownloader"); //Öffnet eine Messagebox mit den Informationen zur Anwendung
        }

        private void github(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Möchten Sie das GitHub Projekt in Ihrem Standart Browser öffnen?", "GitHub", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/DarkModz-Official/Clean-VideoDownloader"); //Öffne das GitHub Projekt
            }
        }

        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Alt || Control.ModifierKeys == Keys.F4)    //Blockieren von Alt + F4
            {
                e.Cancel = true;
            }
        }

        private void update(object sender, EventArgs e)
        {
            string exeToRun = @"C:\TEST\youtube-dl.exe";    //Pfad der Ziel EXE-Datei
            if (File.Exists(exeToRun)) //Wenn datei nicht Existiert dann Datei an Zielspeicherort Speichern!
            {
                System.Diagnostics.Process.Start(exeToRun, "--update");   //Update der youtube-dl.exe
            }
        }

        private void tB_Link_KeyUp(object sender, KeyEventArgs e)
        {
            if (konami.IsCompletedBy(e.KeyCode))// Wenn der KonamiCode eingetippt wurde
            {
                DialogResult = MessageBox.Show("CheatMode Activated!");
                if (DialogResult == DialogResult.OK)
                {
                    //Open RickRoll in Browser
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                }
            }
        }
        
        private async void download(object sender, EventArgs e)
        {
            byte[] exeBytes = resources.youtubedl;  //Bytes der Youtube-DL auslesen und in ein Array speichern
            string exeToRun = @"C:\TEST\youtube-dl.exe";    //Pfad der Ziel EXE-Datei

            System.IO.Directory.CreateDirectory(@"C:\TEST");    //Ordner erstellen
            if (!File.Exists(exeToRun)) //Wenn datei nicht Existiert dann Datei an Zielspeicherort Speichern!
            {
                using (FileStream exeFile = new FileStream(exeToRun, FileMode.CreateNew))
                {
                    exeFile.Write(exeBytes, 0, exeBytes.Length);
                }
            }

            ytdl.YoutubeDLPath = exeToRun;  //Youtube-DL Pfad setzen
            ytdl.OutputFolder = @"C:\TEST"; //Zielordner setzen
            var cts = new CancellationTokenSource();    //CancellationTokenSource erstellen
            var progress = new Progress<DownloadProgress>(p => {
                prgressBar.Value = Convert.ToInt32(p.Progress * 100);   //Fortschritt in ProgressBar setzen
            });


            await ytdl.RunVideoDownload(tB_Link.Text, "best", progress: progress, ct: cts.Token);   //Download starten
            cts.Cancel();   //Download Stop nach Fertigstellung um Ressourcen zu sparen
        }
    }
    public class KonamiSequence
    {

        List<Keys> Keys = new List<Keys>{System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Up,
                                       System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Down,
                                       System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right,
                                       System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right,
                                       System.Windows.Forms.Keys.B, System.Windows.Forms.Keys.A};   //Array mit den Keys des Konami Codes

        private int mPosition = -1; // Position im Array

        public int Position
        {
            get { return mPosition; }
            private set { mPosition = value; }
        }

        public bool IsCompletedBy(Keys key)
        {

            if (Keys[Position + 1] == key)
            {
                // Wechseln zur nächsten Taste in der Sequenz
                Position++;
            }
            else if (Position == 1 && key == System.Windows.Forms.Keys.Up)
            {
                // Zurücksetzen der Sequenz, wenn die Taste nicht mehr gedrückt ist und die Sequenz an zweiter Stelle im Array steht
            }
            else if (Keys[0] == key)
            {
                // Zurücksetzen der Sequenz, wenn die Taste der ersten Taste in der Sequenz entspricht und die Sequenz derzeit an erster Stelle im Array steht
                Position = 0;
            }
            else
            {
                // Zurücksetzen der Sequenz, wenn der Schlüssel nicht Teil der Sequenz ist
                Position = -1;
            }

            if (Position == Keys.Count - 1) //Wenn die Sequenz abgeschlossen wurde
            {
                Position = -1;
                return true;
            }

            return false;
        }
    }
}
