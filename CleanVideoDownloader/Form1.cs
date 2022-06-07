using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanVideoDownloader
{
    public partial class Form1 : Form
    {
        private KonamiSequence konami = new KonamiSequence();
        
        bool dashboardVisibility = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openAnimation.SetAnimateWindow(this);
            ShadowForm.SetShadowForm(this);
            dragBar.SetDrag(dragPanel);
        }

        private void btn_Exit(object sender, EventArgs e)
        {
            //Bist du dir sicher dass du die Anwendung Beenden möchtest?
            DialogResult = MessageBox.Show("Bist du dir sicher dass du die Anwendung beenden möchtest?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboardControl(object sender, EventArgs e)
        {
            
            if (dashboardVisibility == true)
            {
                fade.Hide(tB_Link, true);
                fade.HideSync(btn_Download, true);
                swipe.HideSync(dashboardPanel);
                dashboardPanel.ShadowDecoration.Enabled = false;
                dashboardPanel.Location = new Point(-140, 45);
                dashboardControlButton.Text = ">";
                dashboardVisibility = false;
                tB_Link.Location = new Point(65, 60);
                tB_Link.Size = new Size(725, 35);
                btn_Download.Location = new Point(65, 102);
                swipe.ShowSync(dashboardPanel, true);
                fade.Show(tB_Link, true);
                fade.ShowSync(btn_Download, true);

                dashboardPanel.ShadowDecoration.Enabled = true;
                
                
            }
            else
            {
                fade.Hide(tB_Link, true);
                fade.HideSync(btn_Download, true);
                swipe.HideSync(dashboardPanel);
                dashboardPanel.ShadowDecoration.Enabled = false;
                dashboardPanel.Location = new Point(0, 45);
                dashboardControlButton.Text = "<";
                dashboardVisibility = true;
                tB_Link.Location = new Point(210, 60);
                tB_Link.Size = new Size(580, 35);
                btn_Download.Location = new Point(206, 102);
                swipe.ShowSync(dashboardPanel, true);
                fade.Show(tB_Link, true);
                fade.ShowSync(btn_Download, true);

                dashboardPanel.ShadowDecoration.Enabled = true;
                

            }

        }

        private void about(object sender, EventArgs e)
        {
            MessageBox.Show("Version:1.3.5\nDeveloped by: DarkModz-Official\n\n\n Es wird die YouTube-DL importiert!", "CleanVideoDownloader");
        }

        private void github(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Möchten Sie das GitHub Projekt in Ihrem Standart Browser öffnen?", "GitHub", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/DarkModz-Official/Clean-VideoDownloader");
            }
        }

        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Alt || Control.ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }
        }

        private void update(object sender, EventArgs e)
        {

        }

        private void tB_Link_KeyUp(object sender, KeyEventArgs e)
        {
            if (konami.IsCompletedBy(e.KeyCode))
            {
                DialogResult = MessageBox.Show("CheatMode Activated!");
                if (DialogResult == DialogResult.OK)
                {
                    //Open RickRoll in Browser
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                }
            }
        }
    }
    public class KonamiSequence
    {

        List<Keys> Keys = new List<Keys>{System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Up,
                                       System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Down,
                                       System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right,
                                       System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right,
                                       System.Windows.Forms.Keys.B, System.Windows.Forms.Keys.A};
        private int mPosition = -1;

        public int Position
        {
            get { return mPosition; }
            private set { mPosition = value; }
        }

        public bool IsCompletedBy(Keys key)
        {

            if (Keys[Position + 1] == key)
            {
                // move to next
                Position++;
            }
            else if (Position == 1 && key == System.Windows.Forms.Keys.Up)
            {
                // stay where we are
            }
            else if (Keys[0] == key)
            {
                // restart at 1st
                Position = 0;
            }
            else
            {
                // no match in sequence
                Position = -1;
            }

            if (Position == Keys.Count - 1)
            {
                Position = -1;
                return true;
            }

            return false;
        }
    }
}
