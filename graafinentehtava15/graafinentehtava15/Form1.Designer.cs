namespace graafinentehtava15
{
    partial class SekkariForm
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
            AikaLB = new Label();
            KaynnistaBT = new Button();
            LopetaBT = new Button();
            TyhjennaBT = new Button();
            AjanOttoT = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AikaLB.Location = new Point(60, 9);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(392, 84);
            AikaLB.TabIndex = 0;
            AikaLB.Text = "00:00:00:000";
            AikaLB.Click += AikaLB_Click;
            // 
            // KaynnistaBT
            // 
            KaynnistaBT.Location = new Point(60, 118);
            KaynnistaBT.Name = "KaynnistaBT";
            KaynnistaBT.Size = new Size(104, 42);
            KaynnistaBT.TabIndex = 1;
            KaynnistaBT.Text = "Käynnistä";
            KaynnistaBT.UseVisualStyleBackColor = true;
            KaynnistaBT.Click += c_Click;
            // 
            // LopetaBT
            // 
            LopetaBT.Location = new Point(208, 118);
            LopetaBT.Name = "LopetaBT";
            LopetaBT.Size = new Size(104, 42);
            LopetaBT.TabIndex = 2;
            LopetaBT.Text = "Lopeta";
            LopetaBT.UseVisualStyleBackColor = true;
            LopetaBT.Click += LopetaBT_Click;
            // 
            // TyhjennaBT
            // 
            TyhjennaBT.Location = new Point(348, 118);
            TyhjennaBT.Name = "TyhjennaBT";
            TyhjennaBT.Size = new Size(104, 42);
            TyhjennaBT.TabIndex = 3;
            TyhjennaBT.Text = "Tyhjennä";
            TyhjennaBT.UseVisualStyleBackColor = true;
            TyhjennaBT.Click += TyhjennaBT_Click;
            // 
            // AjanOttoT
            // 
            AjanOttoT.Enabled = true;
            AjanOttoT.Tick += timer1_Tick;
            // 
            // SekkariForm
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 201);
            Controls.Add(TyhjennaBT);
            Controls.Add(LopetaBT);
            Controls.Add(KaynnistaBT);
            Controls.Add(AikaLB);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "SekkariForm";
            Text = "Sekunttikello";
            Load += SekkariForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AikaLB;
        private Button KaynnistaBT;
        private Button LopetaBT;
        private Button TyhjennaBT;
        private System.Windows.Forms.Timer AjanOttoT;
    }
}
