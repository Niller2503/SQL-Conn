namespace WinFormsApp3.Views
{
    partial class Create
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
            lblCreateVare = new Label();
            lblName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNavn = new TextBox();
            txtBeskrivelse = new TextBox();
            txtIndkøbspris = new TextBox();
            txtAntal = new TextBox();
            txtFortjeneste = new TextBox();
            btnCreateVare = new Button();
            btnTilOverview = new Button();
            SuspendLayout();
            // 
            // lblCreateVare
            // 
            lblCreateVare.AutoSize = true;
            lblCreateVare.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreateVare.Location = new Point(288, 9);
            lblCreateVare.Name = "lblCreateVare";
            lblCreateVare.Size = new Size(245, 48);
            lblCreateVare.TabIndex = 0;
            lblCreateVare.Text = "Opret Ny Vare";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(154, 94);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Navn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 160);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Varebeskrivelse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 214);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 3;
            label3.Text = "Antal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 278);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 4;
            label4.Text = "Indkøbspris";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 332);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 5;
            label5.Text = "Fortjeneste";
            // 
            // txtNavn
            // 
            txtNavn.Location = new Point(235, 91);
            txtNavn.Name = "txtNavn";
            txtNavn.Size = new Size(399, 31);
            txtNavn.TabIndex = 7;
            // 
            // txtBeskrivelse
            // 
            txtBeskrivelse.Location = new Point(235, 157);
            txtBeskrivelse.Name = "txtBeskrivelse";
            txtBeskrivelse.Size = new Size(399, 31);
            txtBeskrivelse.TabIndex = 8;
            // 
            // txtIndkøbspris
            // 
            txtIndkøbspris.Location = new Point(235, 275);
            txtIndkøbspris.Name = "txtIndkøbspris";
            txtIndkøbspris.Size = new Size(399, 31);
            txtIndkøbspris.TabIndex = 9;
            // 
            // txtAntal
            // 
            txtAntal.Location = new Point(235, 211);
            txtAntal.Name = "txtAntal";
            txtAntal.Size = new Size(399, 31);
            txtAntal.TabIndex = 10;
            // 
            // txtFortjeneste
            // 
            txtFortjeneste.Location = new Point(235, 329);
            txtFortjeneste.Name = "txtFortjeneste";
            txtFortjeneste.Size = new Size(399, 31);
            txtFortjeneste.TabIndex = 11;
            // 
            // btnCreateVare
            // 
            btnCreateVare.Location = new Point(620, 393);
            btnCreateVare.Name = "btnCreateVare";
            btnCreateVare.Size = new Size(168, 45);
            btnCreateVare.TabIndex = 13;
            btnCreateVare.Text = "Opret Ny Vare";
            btnCreateVare.UseVisualStyleBackColor = true;
            // 
            // btnTilOverview
            // 
            btnTilOverview.Location = new Point(12, 382);
            btnTilOverview.Name = "btnTilOverview";
            btnTilOverview.Size = new Size(112, 34);
            btnTilOverview.TabIndex = 14;
            btnTilOverview.Text = "Tilbage";
            btnTilOverview.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTilOverview);
            Controls.Add(btnCreateVare);
            Controls.Add(txtFortjeneste);
            Controls.Add(txtAntal);
            Controls.Add(txtIndkøbspris);
            Controls.Add(txtBeskrivelse);
            Controls.Add(txtNavn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(lblCreateVare);
            Name = "Create";
            Text = "Create";
            Load += Create_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateVare;
        private Label lblName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNavn;
        private TextBox txtBeskrivelse;
        private TextBox txtIndkøbspris;
        private TextBox txtAntal;
        private TextBox txtFortjeneste;
        private Button btnCreateVare;
        private Button btnTilOverview;
    }
}