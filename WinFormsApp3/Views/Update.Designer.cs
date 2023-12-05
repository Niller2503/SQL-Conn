namespace WinFormsApp3.Views
{
    partial class Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtUpdateNavn = new TextBox();
            TxtUpdateAntal = new TextBox();
            TxtUpdateIndkøbspris = new TextBox();
            TxtUpdateFortjeneste = new TextBox();
            TxtUpdateBeskrivelse = new TextBox();
            btnUpdateVare = new Button();
            btnFraUpdateTilOverview = new Button();
            trackBar1 = new TrackBar();
            hScrollBar2 = new HScrollBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 51);
            label1.TabIndex = 0;
            label1.Text = "Opdater Vare";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 344);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "Fortjeneste";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 277);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 3;
            label4.Text = "Indkøbspris";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 222);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 4;
            label5.Text = "Antal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 164);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 5;
            label6.Text = "Beskrivelse";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 105);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 6;
            label7.Text = "Navn";
            // 
            // TxtUpdateNavn
            // 
            TxtUpdateNavn.Location = new Point(247, 102);
            TxtUpdateNavn.Name = "TxtUpdateNavn";
            TxtUpdateNavn.Size = new Size(345, 31);
            TxtUpdateNavn.TabIndex = 7;
            // 
            // TxtUpdateAntal
            // 
            TxtUpdateAntal.Location = new Point(247, 219);
            TxtUpdateAntal.Name = "TxtUpdateAntal";
            TxtUpdateAntal.Size = new Size(345, 31);
            TxtUpdateAntal.TabIndex = 8;
            // 
            // TxtUpdateIndkøbspris
            // 
            TxtUpdateIndkøbspris.Location = new Point(247, 274);
            TxtUpdateIndkøbspris.Name = "TxtUpdateIndkøbspris";
            TxtUpdateIndkøbspris.Size = new Size(345, 31);
            TxtUpdateIndkøbspris.TabIndex = 9;
            // 
            // TxtUpdateFortjeneste
            // 
            TxtUpdateFortjeneste.Location = new Point(247, 341);
            TxtUpdateFortjeneste.Name = "TxtUpdateFortjeneste";
            TxtUpdateFortjeneste.Size = new Size(345, 31);
            TxtUpdateFortjeneste.TabIndex = 10;
            // 
            // TxtUpdateBeskrivelse
            // 
            TxtUpdateBeskrivelse.Location = new Point(247, 161);
            TxtUpdateBeskrivelse.Name = "TxtUpdateBeskrivelse";
            TxtUpdateBeskrivelse.Size = new Size(345, 31);
            TxtUpdateBeskrivelse.TabIndex = 11;
            // 
            // btnUpdateVare
            // 
            btnUpdateVare.Location = new Point(635, 371);
            btnUpdateVare.Name = "btnUpdateVare";
            btnUpdateVare.Size = new Size(137, 48);
            btnUpdateVare.TabIndex = 12;
            btnUpdateVare.Text = "Opdater Vare";
            btnUpdateVare.UseVisualStyleBackColor = true;
            // 
            // btnFraUpdateTilOverview
            // 
            btnFraUpdateTilOverview.Location = new Point(12, 408);
            btnFraUpdateTilOverview.Name = "btnFraUpdateTilOverview";
            btnFraUpdateTilOverview.Size = new Size(99, 30);
            btnFraUpdateTilOverview.TabIndex = 13;
            btnFraUpdateTilOverview.Text = "Tilbage";
            btnFraUpdateTilOverview.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(49, 34);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(156, 69);
            trackBar1.TabIndex = 14;
            // 
            // hScrollBar2
            // 
            hScrollBar2.Location = new Point(576, 30);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(120, 39);
            hScrollBar2.TabIndex = 15;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hScrollBar2);
            Controls.Add(trackBar1);
            Controls.Add(btnFraUpdateTilOverview);
            Controls.Add(btnUpdateVare);
            Controls.Add(TxtUpdateBeskrivelse);
            Controls.Add(TxtUpdateFortjeneste);
            Controls.Add(TxtUpdateIndkøbspris);
            Controls.Add(TxtUpdateAntal);
            Controls.Add(TxtUpdateNavn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Update";
            Text = "Update";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtUpdateNavn;
        private TextBox TxtUpdateAntal;
        private TextBox TxtUpdateIndkøbspris;
        private TextBox TxtUpdateFortjeneste;
        private TextBox TxtUpdateBeskrivelse;
        private Button btnUpdateVare;
        private Button btnFraUpdateTilOverview;
        private HScrollBar hScrollBar1;
        private TrackBar trackBar1;
        private HScrollBar hScrollBar2;
    }
}