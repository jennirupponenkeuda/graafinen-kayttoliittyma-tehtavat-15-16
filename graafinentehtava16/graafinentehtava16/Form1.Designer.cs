namespace graafinentehtava16
{
    partial class LaskuriF
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
            components = new System.ComponentModel.Container();
            MinuutitLB = new Label();
            SekunnitLB = new Label();
            MinuutitCB = new ComboBox();
            SekunnitCB = new ComboBox();
            AikaLB = new Label();
            StartBT = new Button();
            StopBT = new Button();
            AjastinTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // MinuutitLB
            // 
            MinuutitLB.AutoSize = true;
            MinuutitLB.Location = new Point(12, 25);
            MinuutitLB.Name = "MinuutitLB";
            MinuutitLB.Size = new Size(62, 19);
            MinuutitLB.TabIndex = 0;
            MinuutitLB.Text = "Minuutit:";
            // 
            // SekunnitLB
            // 
            SekunnitLB.AutoSize = true;
            SekunnitLB.Location = new Point(80, 25);
            SekunnitLB.Name = "SekunnitLB";
            SekunnitLB.Size = new Size(68, 19);
            SekunnitLB.TabIndex = 1;
            SekunnitLB.Text = "Sekunnit:";
            // 
            // MinuutitCB
            // 
            MinuutitCB.FormattingEnabled = true;
            MinuutitCB.Location = new Point(12, 59);
            MinuutitCB.Name = "MinuutitCB";
            MinuutitCB.RightToLeft = RightToLeft.Yes;
            MinuutitCB.Size = new Size(62, 27);
            MinuutitCB.TabIndex = 2;
            // 
            // SekunnitCB
            // 
            SekunnitCB.FormattingEnabled = true;
            SekunnitCB.Location = new Point(80, 59);
            SekunnitCB.Name = "SekunnitCB";
            SekunnitCB.RightToLeft = RightToLeft.Yes;
            SekunnitCB.Size = new Size(68, 27);
            SekunnitCB.TabIndex = 3;
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Segoe MDL2 Assets", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AikaLB.Location = new Point(12, 101);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(148, 64);
            AikaLB.TabIndex = 4;
            AikaLB.Text = "00:00";
            // 
            // StartBT
            // 
            StartBT.Location = new Point(12, 181);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(62, 43);
            StartBT.TabIndex = 5;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // StopBT
            // 
            StopBT.Location = new Point(86, 181);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(62, 43);
            StopBT.TabIndex = 6;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // AjastinTimer
            // 
            AjastinTimer.Interval = 1000;
            AjastinTimer.Tick += AjastinTimer_Tick;
            // 
            // LaskuriF
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 267);
            Controls.Add(StopBT);
            Controls.Add(StartBT);
            Controls.Add(AikaLB);
            Controls.Add(SekunnitCB);
            Controls.Add(MinuutitCB);
            Controls.Add(SekunnitLB);
            Controls.Add(MinuutitLB);
            Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LaskuriF";
            Text = "Laskuri";
            Load += LaskuriF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MinuutitLB;
        private Label SekunnitLB;
        private ComboBox MinuutitCB;
        private ComboBox SekunnitCB;
        private Label AikaLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer AjastinTimer;
    }
}
