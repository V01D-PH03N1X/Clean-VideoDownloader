namespace CleanVideoDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dragPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.dragBar = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dashboardControlButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.openGithub = new Guna.UI2.WinForms.Guna2Button();
            this.swipe = new Guna.UI2.WinForms.Guna2Transition();
            this.tB_Link = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Download = new Guna.UI2.WinForms.Guna2Button();
            this.prgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.openAnimation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.fade = new Guna.UI2.WinForms.Guna2Transition();
            this.dragPanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.dragPanel.Controls.Add(this.guna2HtmlLabel1);
            this.dragPanel.Controls.Add(this.guna2TileButton1);
            this.fade.SetDecoration(this.dragPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.dragPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.ShadowDecoration.BorderRadius = 8;
            this.dragPanel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dragPanel.ShadowDecoration.Depth = 45;
            this.dragPanel.ShadowDecoration.Parent = this.dragPanel;
            this.dragPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.dragPanel.Size = new System.Drawing.Size(800, 45);
            this.dragPanel.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fade.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Brevia Medium", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 8);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(526, 34);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "VideoDownloader - by DarkModz - Official";
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.guna2TileButton1.CheckedState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.CustomImages.Parent = this.guna2TileButton1;
            this.fade.SetDecoration(this.guna2TileButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.guna2TileButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(124)))));
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Location = new System.Drawing.Point(740, 0);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.BorderRadius = 8;
            this.guna2TileButton1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.guna2TileButton1.ShadowDecoration.Depth = 45;
            this.guna2TileButton1.ShadowDecoration.Enabled = true;
            this.guna2TileButton1.ShadowDecoration.Parent = this.guna2TileButton1;
            this.guna2TileButton1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2TileButton1.Size = new System.Drawing.Size(60, 45);
            this.guna2TileButton1.TabIndex = 1;
            this.guna2TileButton1.Text = "X";
            this.guna2TileButton1.Click += new System.EventHandler(this.btn_Exit);
            // 
            // dragBar
            // 
            this.dragBar.TargetControl = null;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.dashboardPanel.Controls.Add(this.dashboardControlButton);
            this.dashboardPanel.Controls.Add(this.guna2Button2);
            this.dashboardPanel.Controls.Add(this.guna2Button1);
            this.dashboardPanel.Controls.Add(this.openGithub);
            this.fade.SetDecoration(this.dashboardPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.dashboardPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dashboardPanel.Location = new System.Drawing.Point(-141, 45);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.ShadowDecoration.BorderRadius = 2;
            this.dashboardPanel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dashboardPanel.ShadowDecoration.Enabled = true;
            this.dashboardPanel.ShadowDecoration.Parent = this.dashboardPanel;
            this.dashboardPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dashboardPanel.Size = new System.Drawing.Size(200, 405);
            this.dashboardPanel.TabIndex = 1;
            // 
            // dashboardControlButton
            // 
            this.dashboardControlButton.Animated = true;
            this.dashboardControlButton.BackColor = System.Drawing.Color.Transparent;
            this.dashboardControlButton.CheckedState.Parent = this.dashboardControlButton;
            this.dashboardControlButton.CustomImages.Parent = this.dashboardControlButton;
            this.fade.SetDecoration(this.dashboardControlButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.dashboardControlButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dashboardControlButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.dashboardControlButton.Font = new System.Drawing.Font("Brevia Medium", 18F, System.Drawing.FontStyle.Bold);
            this.dashboardControlButton.ForeColor = System.Drawing.Color.White;
            this.dashboardControlButton.HoverState.Parent = this.dashboardControlButton;
            this.dashboardControlButton.Location = new System.Drawing.Point(145, 343);
            this.dashboardControlButton.Name = "dashboardControlButton";
            this.dashboardControlButton.ShadowDecoration.Enabled = true;
            this.dashboardControlButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dashboardControlButton.ShadowDecoration.Parent = this.dashboardControlButton;
            this.dashboardControlButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.dashboardControlButton.Size = new System.Drawing.Size(50, 50);
            this.dashboardControlButton.TabIndex = 0;
            this.dashboardControlButton.Text = ">";
            this.dashboardControlButton.Tile = false;
            this.dashboardControlButton.UseTransparentBackground = true;
            this.dashboardControlButton.Click += new System.EventHandler(this.dashboardControl);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.fade.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.guna2Button2.Font = new System.Drawing.Font("Brevia Medium", 8F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(8, 108);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(125, 45);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "Über VideoDownloader";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.about);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.fade.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.guna2Button1.Font = new System.Drawing.Font("Brevia Medium", 8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(8, 57);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(125, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Update";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.update);
            // 
            // openGithub
            // 
            this.openGithub.Animated = true;
            this.openGithub.AutoRoundedCorners = true;
            this.openGithub.BackColor = System.Drawing.Color.Transparent;
            this.openGithub.BorderRadius = 21;
            this.openGithub.CheckedState.Parent = this.openGithub;
            this.openGithub.CustomImages.Parent = this.openGithub;
            this.fade.SetDecoration(this.openGithub, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.openGithub, Guna.UI2.AnimatorNS.DecorationType.None);
            this.openGithub.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.openGithub.Font = new System.Drawing.Font("Brevia Medium", 8F, System.Drawing.FontStyle.Bold);
            this.openGithub.ForeColor = System.Drawing.Color.Black;
            this.openGithub.HoverState.Parent = this.openGithub;
            this.openGithub.Location = new System.Drawing.Point(8, 6);
            this.openGithub.Name = "openGithub";
            this.openGithub.ShadowDecoration.Parent = this.openGithub;
            this.openGithub.Size = new System.Drawing.Size(125, 45);
            this.openGithub.TabIndex = 0;
            this.openGithub.Text = "GitHub Project";
            this.openGithub.UseTransparentBackground = true;
            this.openGithub.Click += new System.EventHandler(this.github);
            // 
            // swipe
            // 
            this.swipe.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.swipe.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.swipe.DefaultAnimation = animation3;
            this.swipe.Interval = 2;
            this.swipe.MaxAnimationTime = 1000;
            this.swipe.TimeStep = 0.01F;
            // 
            // tB_Link
            // 
            this.tB_Link.AutoRoundedCorners = true;
            this.tB_Link.BackColor = System.Drawing.Color.Transparent;
            this.tB_Link.BorderRadius = 16;
            this.tB_Link.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fade.SetDecoration(this.tB_Link, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.tB_Link, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tB_Link.DefaultText = "";
            this.tB_Link.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tB_Link.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tB_Link.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tB_Link.DisabledState.Parent = this.tB_Link;
            this.tB_Link.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tB_Link.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tB_Link.FocusedState.Parent = this.tB_Link;
            this.tB_Link.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tB_Link.HoverState.Parent = this.tB_Link;
            this.tB_Link.Location = new System.Drawing.Point(65, 60);
            this.tB_Link.Name = "tB_Link";
            this.tB_Link.PasswordChar = '\0';
            this.tB_Link.PlaceholderText = "Ihr VideoLink";
            this.tB_Link.SelectedText = "";
            this.tB_Link.ShadowDecoration.Parent = this.tB_Link;
            this.tB_Link.Size = new System.Drawing.Size(725, 35);
            this.tB_Link.TabIndex = 2;
            this.tB_Link.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tB_Link_KeyUp);
            // 
            // btn_Download
            // 
            this.btn_Download.Animated = true;
            this.btn_Download.AutoRoundedCorners = true;
            this.btn_Download.BackColor = System.Drawing.Color.Transparent;
            this.btn_Download.BorderRadius = 21;
            this.btn_Download.CheckedState.Parent = this.btn_Download;
            this.btn_Download.CustomImages.Parent = this.btn_Download;
            this.fade.SetDecoration(this.btn_Download, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this.btn_Download, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_Download.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btn_Download.Font = new System.Drawing.Font("Brevia Medium", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Download.ForeColor = System.Drawing.Color.Black;
            this.btn_Download.HoverState.Parent = this.btn_Download;
            this.btn_Download.Location = new System.Drawing.Point(65, 102);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.ShadowDecoration.Parent = this.btn_Download;
            this.btn_Download.Size = new System.Drawing.Size(202, 45);
            this.btn_Download.TabIndex = 3;
            this.btn_Download.Text = "⮟ Download ⮟";
            this.btn_Download.UseTransparentBackground = true;
            this.btn_Download.Click += new System.EventHandler(this.download);
            // 
            // prgressBar
            // 
            this.prgressBar.AutoRoundedCorners = true;
            this.prgressBar.BackColor = System.Drawing.Color.Transparent;
            this.prgressBar.BorderRadius = 21;
            this.prgressBar.BorderThickness = 1;
            this.swipe.SetDecoration(this.prgressBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.fade.SetDecoration(this.prgressBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.prgressBar.FillColor = System.Drawing.Color.Transparent;
            this.prgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.prgressBar.Location = new System.Drawing.Point(285, 102);
            this.prgressBar.Name = "prgressBar";
            this.prgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(124)))));
            this.prgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.prgressBar.ShadowDecoration.Parent = this.prgressBar;
            this.prgressBar.ShowPercentage = true;
            this.prgressBar.Size = new System.Drawing.Size(503, 45);
            this.prgressBar.TabIndex = 4;
            this.prgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.prgressBar.UseTransparentBackground = true;
            this.prgressBar.Value = 100;
            // 
            // openAnimation
            // 
            this.openAnimation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.openAnimation.Interval = 500;
            // 
            // fade
            // 
            this.fade.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.fade.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.fade.DefaultAnimation = animation4;
            this.fade.MaxAnimationTime = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prgressBar);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.tB_Link);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.dragPanel);
            this.fade.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swipe.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Panel dragPanel;
        private Guna.UI2.WinForms.Guna2DragControl dragBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2Panel dashboardPanel;
        private Guna.UI2.WinForms.Guna2CircleButton dashboardControlButton;
        private Guna.UI2.WinForms.Guna2Transition swipe;
        private Guna.UI2.WinForms.Guna2Button openGithub;
        private Guna.UI2.WinForms.Guna2AnimateWindow openAnimation;
        private Guna.UI2.WinForms.Guna2TextBox tB_Link;
        private Guna.UI2.WinForms.Guna2Transition fade;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btn_Download;
        private Guna.UI2.WinForms.Guna2ProgressBar prgressBar;
    }
}

