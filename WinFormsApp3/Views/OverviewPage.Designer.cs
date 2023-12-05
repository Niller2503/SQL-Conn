namespace WinFormsApp3
{
    partial class OverviewPage
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
            lblHelloWorld = new Label();
            TxtSearch = new TextBox();
            dgvVare = new DataGridView();
            btnToCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            TxtDelete = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVare).BeginInit();
            SuspendLayout();
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(32, 9);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(112, 25);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "Dit varelager";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(441, 394);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(112, 31);
            TxtSearch.TabIndex = 2;
            // 
            // dgvVare
            // 
            dgvVare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVare.Location = new Point(28, 42);
            dgvVare.Name = "dgvVare";
            dgvVare.RowHeadersWidth = 62;
            dgvVare.RowTemplate.Height = 33;
            dgvVare.Size = new Size(701, 292);
            dgvVare.TabIndex = 4;
            dgvVare.CellContentDoubleClick += dgvVare_DoubleClick;
            // 
            // btnToCreate
            // 
            btnToCreate.Location = new Point(28, 354);
            btnToCreate.Name = "btnToCreate";
            btnToCreate.Size = new Size(112, 34);
            btnToCreate.TabIndex = 5;
            btnToCreate.Text = "Opret Vare";
            btnToCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(216, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Refresh";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(617, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Slet Vare";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(441, 354);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Søg Vare";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtDelete
            // 
            TxtDelete.Location = new Point(617, 394);
            TxtDelete.Name = "TxtDelete";
            TxtDelete.Size = new Size(112, 31);
            TxtDelete.TabIndex = 9;
            // 
            // OverviewPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnToCreate);
            Controls.Add(dgvVare);
            Controls.Add(TxtSearch);
            Controls.Add(lblHelloWorld);
            Name = "OverviewPage";
            Text = "OverviewPage";
            ((System.ComponentModel.ISupportInitialize)dgvVare).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHelloWorld;
        private TextBox TxtSearch;
        private DataGridView dgvVare;
        private Button btnToCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox TxtDelete;
    }
}