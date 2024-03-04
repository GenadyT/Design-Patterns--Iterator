namespace ArtistWorks
{
    partial class frmPaintingsViewer
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
            cbxPainters = new ComboBox();
            label1 = new Label();
            pbxArtWork = new PictureBox();
            btnMoveNext = new Button();
            btnReset = new Button();
            label2 = new Label();
            cbxArtMovements = new ComboBox();
            label3 = new Label();
            tbxPaintingTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxArtWork).BeginInit();
            SuspendLayout();
            // 
            // cbxPainters
            // 
            cbxPainters.FormattingEnabled = true;
            cbxPainters.Location = new Point(111, 55);
            cbxPainters.Name = "cbxPainters";
            cbxPainters.Size = new Size(270, 23);
            cbxPainters.TabIndex = 0;
            cbxPainters.SelectedIndexChanged += cbxPainters_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 58);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Painters";
            // 
            // pbxArtWork
            // 
            pbxArtWork.BorderStyle = BorderStyle.Fixed3D;
            pbxArtWork.Location = new Point(20, 131);
            pbxArtWork.Name = "pbxArtWork";
            pbxArtWork.Size = new Size(500, 417);
            pbxArtWork.SizeMode = PictureBoxSizeMode.Zoom;
            pbxArtWork.TabIndex = 2;
            pbxArtWork.TabStop = false;
            // 
            // btnMoveNext
            // 
            btnMoveNext.BackColor = Color.FromArgb(139, 193, 217);
            btnMoveNext.FlatAppearance.BorderColor = Color.Red;
            btnMoveNext.FlatStyle = FlatStyle.Flat;
            btnMoveNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMoveNext.Location = new Point(405, 565);
            btnMoveNext.Name = "btnMoveNext";
            btnMoveNext.Size = new Size(115, 25);
            btnMoveNext.TabIndex = 4;
            btnMoveNext.Text = "Next Painting";
            btnMoveNext.UseVisualStyleBackColor = false;
            btnMoveNext.Click += btnMoveNext_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(20, 567);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 25);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 24);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 5;
            label2.Text = "Art Movement";
            // 
            // cbxArtMovements
            // 
            cbxArtMovements.FormattingEnabled = true;
            cbxArtMovements.Location = new Point(111, 24);
            cbxArtMovements.Name = "cbxArtMovements";
            cbxArtMovements.Size = new Size(270, 23);
            cbxArtMovements.TabIndex = 6;
            cbxArtMovements.SelectedIndexChanged += cbxArtMovements_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 91);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Painting";
            // 
            // tbxPaintingTitle
            // 
            tbxPaintingTitle.Enabled = false;
            tbxPaintingTitle.Location = new Point(111, 91);
            tbxPaintingTitle.Name = "tbxPaintingTitle";
            tbxPaintingTitle.Size = new Size(270, 23);
            tbxPaintingTitle.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 609);
            Controls.Add(tbxPaintingTitle);
            Controls.Add(label3);
            Controls.Add(cbxArtMovements);
            Controls.Add(label2);
            Controls.Add(btnMoveNext);
            Controls.Add(btnReset);
            Controls.Add(pbxArtWork);
            Controls.Add(label1);
            Controls.Add(cbxPainters);
            Name = "Form1";
            Text = "Art Movements' Paintings";
            ((System.ComponentModel.ISupportInitialize)pbxArtWork).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxPainters;
        private Label label1;
        private PictureBox pbxArtWork;
        private Button btnMoveNext;
        private Button btnReset;
        private Label label2;
        private ComboBox cbxArtMovements;
        private Label label3;
        private TextBox tbxPaintingTitle;
    }
}