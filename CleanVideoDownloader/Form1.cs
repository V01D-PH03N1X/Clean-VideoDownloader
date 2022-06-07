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
                fade.HideSync(tB_Link);
                swipe.HideSync(dashboardPanel);
                dashboardPanel.ShadowDecoration.Enabled = false;
                dashboardPanel.Location = new Point(-140, 45);
                dashboardControlButton.Text = ">";
                dashboardVisibility = false;
                tB_Link.Location = new Point(65, 60);
                tB_Link.Size = new Size(725, 35);
                swipe.ShowSync(dashboardPanel, true);
                fade.ShowSync(tB_Link, true);
                
                dashboardPanel.ShadowDecoration.Enabled = true;
                
                
            }
            else
            {
                fade.HideSync(tB_Link);
                swipe.HideSync(dashboardPanel);
                dashboardPanel.ShadowDecoration.Enabled = false;
                dashboardPanel.Location = new Point(0, 45);
                dashboardControlButton.Text = "<";
                dashboardVisibility = true;
                tB_Link.Location = new Point(210, 60);
                tB_Link.Size = new Size(580, 35);
                swipe.ShowSync(dashboardPanel, true);
                fade.ShowSync(tB_Link, true);
                
                dashboardPanel.ShadowDecoration.Enabled = true;
                

            }

        }

        private void about(object sender, EventArgs e)
        {
            MessageBox.Show("CleanVideoDownloader\n\nVersion:1.3.5\n\nDeveloped by: DarkModz-Official");
        }

        private void github(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Möchten Sie das GitHub Projekt in Ihrem Standart Browser öffnen?", "GitHub", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("
        }
    }
}
