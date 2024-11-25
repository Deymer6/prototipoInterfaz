namespace mq
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbConectar = new GroupBox();
            progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            btnConectar = new Button();
            linearGauge2 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            panel1 = new Panel();
            panel2 = new Panel();
            btnAlarm = new Button();
            label1 = new Label();
            digitalGauge1 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            btnLuz = new Button();
            btnAlarmaImag = new Button();
            btnFocoImag = new Button();
            btnAlarma = new Button();
            button1 = new Button();
            btnFoco = new Button();
            gbConectar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)progressBarAdv1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // gbConectar
            // 
            gbConectar.BackColor = Color.FromArgb(34, 34, 34);
            gbConectar.Controls.Add(progressBarAdv1);
            gbConectar.Controls.Add(btnConectar);
            gbConectar.ForeColor = SystemColors.ButtonHighlight;
            gbConectar.Location = new Point(31, 36);
            gbConectar.Margin = new Padding(0);
            gbConectar.Name = "gbConectar";
            gbConectar.Padding = new Padding(5, 4, 5, 4);
            gbConectar.Size = new Size(416, 186);
            gbConectar.TabIndex = 7;
            gbConectar.TabStop = false;
            gbConectar.Text = "CONECTAR";
            // 
            // progressBarAdv1
            // 
            progressBarAdv1.BackMultipleColors = new Color[]
    {
    Color.Empty
    };
            progressBarAdv1.BackSegments = false;
            progressBarAdv1.CustomText = null;
            progressBarAdv1.CustomWaitingRender = false;
            progressBarAdv1.ForeColor = Color.Fuchsia;
            progressBarAdv1.ForegroundImage = null;
            progressBarAdv1.Location = new Point(45, 122);
            progressBarAdv1.MultipleColors = new Color[]
    {
    Color.Empty
    };
            progressBarAdv1.Name = "progressBarAdv1";
            progressBarAdv1.SegmentWidth = 12;
            progressBarAdv1.Size = new Size(337, 29);
            progressBarAdv1.TabIndex = 2;
            progressBarAdv1.Text = "progressBarAdv1";
            progressBarAdv1.Value = 0;
            progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // btnConectar
            // 
            btnConectar.ForeColor = SystemColors.ActiveCaptionText;
            btnConectar.Location = new Point(137, 52);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(147, 39);
            btnConectar.TabIndex = 9;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // linearGauge2
            // 
            linearGauge2.BackgroundGradientEndColor = Color.LightSkyBlue;
            linearGauge2.BackgroundGradientStartColor = Color.Coral;
            linearGauge2.ForeColor = Color.Black;
            linearGauge2.GaugelabelFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            linearGauge2.ImeMode = ImeMode.Off;
            linearGauge2.InnerFrameGradientEndColor = Color.Black;
            linearGauge2.InnerFrameGradientStartColor = Color.Black;
            linearGauge2.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Vertical;
            linearGauge2.Location = new Point(79, 15);
            linearGauge2.MajorDifference = 10;
            linearGauge2.MajorTickMarkColor = Color.Red;
            linearGauge2.MajorTicksHeight = 15;
            linearGauge2.MaximumValue = 100F;
            linearGauge2.MinimumSize = new Size(75, 125);
            linearGauge2.MinorTickCount = 5;
            linearGauge2.MinorTickHeight = 10;
            linearGauge2.MinorTickMarkColor = Color.Black;
            linearGauge2.Name = "linearGauge2";
            linearGauge2.NeedleColor = Color.Black;
            linearGauge2.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearGauge2.ScaleColor = Color.Red;
            linearGauge2.ScaleLabelColor = Color.RosyBrown;
            linearGauge2.Size = new Size(248, 445);
            linearGauge2.TabIndex = 9;
            linearGauge2.Text = "linearGauge2";
            linearGauge2.ValueIndicatorColor = Color.Gray;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 34, 34);
            panel1.Controls.Add(linearGauge2);
            panel1.Location = new Point(31, 250);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 482);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 34, 34);
            panel2.Controls.Add(btnAlarm);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(digitalGauge1);
            panel2.Location = new Point(480, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 482);
            panel2.TabIndex = 10;
            // 
            // btnAlarm
            // 
            btnAlarm.Image = Properties.Resources.descarga;
            btnAlarm.Location = new Point(73, 201);
            btnAlarm.Name = "btnAlarm";
            btnAlarm.Size = new Size(225, 195);
            btnAlarm.TabIndex = 3;
            btnAlarm.TabStop = false;
            btnAlarm.UseVisualStyleBackColor = true;
            btnAlarm.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(304, 84);
            label1.Name = "label1";
            label1.Size = new Size(108, 85);
            label1.TabIndex = 1;
            label1.Text = "°C";
            label1.Click += label1_Click;
            // 
            // digitalGauge1
            // 
            digitalGauge1.BackgroundGradientEndColor = Color.FromArgb(255, 128, 128);
            digitalGauge1.BackgroundGradientStartColor = Color.FromArgb(128, 128, 255);
            digitalGauge1.DisplayRecordIndex = 0;
            digitalGauge1.Location = new Point(73, 71);
            digitalGauge1.MaximumSize = new Size(500, 180);
            digitalGauge1.MinimumSize = new Size(90, 90);
            digitalGauge1.Name = "digitalGauge1";
            digitalGauge1.Size = new Size(225, 112);
            digitalGauge1.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.FromArgb(34, 34, 34);
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Controls.Add(btnFoco);
            gradientPanel1.Location = new Point(480, 36);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(416, 186);
            gradientPanel1.TabIndex = 11;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BackColor = Color.FromArgb(34, 34, 34);
            gradientPanel2.Controls.Add(btnLuz);
            gradientPanel2.Controls.Add(btnAlarmaImag);
            gradientPanel2.Controls.Add(btnFocoImag);
            gradientPanel2.Controls.Add(btnAlarma);
            gradientPanel2.Location = new Point(-2, -2);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(416, 186);
            gradientPanel2.TabIndex = 12;
            // 
            // btnLuz
            // 
            btnLuz.Location = new Point(97, 105);
            btnLuz.Name = "btnLuz";
            btnLuz.Size = new Size(126, 45);
            btnLuz.TabIndex = 6;
            btnLuz.Text = "LUZ";
            btnLuz.UseVisualStyleBackColor = true;
            btnLuz.Click += btnLuz_Click;
            // 
            // btnAlarmaImag
            // 
            btnAlarmaImag.BackgroundImage = Properties.Resources.alarma;
            btnAlarmaImag.BackgroundImageLayout = ImageLayout.Stretch;
            btnAlarmaImag.Location = new Point(291, 14);
            btnAlarmaImag.Name = "btnAlarmaImag";
            btnAlarmaImag.Size = new Size(76, 71);
            btnAlarmaImag.TabIndex = 4;
            btnAlarmaImag.TabStop = false;
            btnAlarmaImag.UseVisualStyleBackColor = true;
            btnAlarmaImag.Visible = false;
            // 
            // btnFocoImag
            // 
            btnFocoImag.BackgroundImage = Properties.Resources.foco;
            btnFocoImag.BackgroundImageLayout = ImageLayout.Stretch;
            btnFocoImag.Location = new Point(291, 96);
            btnFocoImag.Name = "btnFocoImag";
            btnFocoImag.Size = new Size(76, 63);
            btnFocoImag.TabIndex = 3;
            btnFocoImag.TabStop = false;
            btnFocoImag.UseVisualStyleBackColor = true;
            btnFocoImag.Visible = false;
            // 
            // btnAlarma
            // 
            btnAlarma.Location = new Point(97, 22);
            btnAlarma.Name = "btnAlarma";
            btnAlarma.Size = new Size(126, 43);
            btnAlarma.TabIndex = 2;
            btnAlarma.Text = "ALARMA";
            btnAlarma.UseVisualStyleBackColor = true;
            btnAlarma.Click += btnAlarma_Click_1;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.alarma;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(291, 92);
            button1.Name = "button1";
            button1.Size = new Size(76, 71);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // btnFoco
            // 
            btnFoco.BackgroundImage = Properties.Resources.foco;
            btnFoco.BackgroundImageLayout = ImageLayout.Stretch;
            btnFoco.Location = new Point(291, 22);
            btnFoco.Name = "btnFoco";
            btnFoco.Size = new Size(76, 63);
            btnFoco.TabIndex = 3;
            btnFoco.TabStop = false;
            btnFoco.UseVisualStyleBackColor = true;
            btnFoco.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 68, 68);
            ClientSize = new Size(934, 763);
            Controls.Add(gradientPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(gbConectar);
            Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "MONITOREO";
            Load += Form1_Load;
            gbConectar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)progressBarAdv1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradientPanel2).EndInit();
            gradientPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbConectar;
        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge2;
        private Button btnConectar;
        private Panel panel1;
        private Panel panel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge1;
        private Label label1;
  
        private Button btnAlarm;
        private Button btnFoco;
        private Button button1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Button btnAlarmaImag;
        private Button btnFocoImag;
        private Button btnAlarma;
        private Button btnLuz;
    }
}