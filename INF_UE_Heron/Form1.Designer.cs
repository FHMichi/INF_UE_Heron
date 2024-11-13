namespace INF_UE_Heron
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
            tbEingabe = new TextBox();
            tbIterations = new TextBox();
            tbSmallerAs = new TextBox();
            label1 = new Label();
            rbAnz = new RadioButton();
            rbSize = new RadioButton();
            panel1 = new Panel();
            lblFalse = new Label();
            btStart = new Button();
            lbAnzeige = new ListBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbEingabe
            // 
            tbEingabe.Location = new Point(481, 28);
            tbEingabe.Name = "tbEingabe";
            tbEingabe.Size = new Size(180, 39);
            tbEingabe.TabIndex = 0;
            // 
            // tbIterations
            // 
            tbIterations.Location = new Point(298, 3);
            tbIterations.Name = "tbIterations";
            tbIterations.Size = new Size(140, 39);
            tbIterations.TabIndex = 1;
            // 
            // tbSmallerAs
            // 
            tbSmallerAs.Location = new Point(461, 204);
            tbSmallerAs.Name = "tbSmallerAs";
            tbSmallerAs.Size = new Size(200, 39);
            tbSmallerAs.TabIndex = 2;
            tbSmallerAs.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(463, 32);
            label1.TabIndex = 3;
            label1.Text = "Berechne die Wurzel näherungsweise für: ";
            // 
            // rbAnz
            // 
            rbAnz.AutoSize = true;
            rbAnz.Location = new Point(3, 3);
            rbAnz.Name = "rbAnz";
            rbAnz.Size = new Size(289, 36);
            rbAnz.TabIndex = 4;
            rbAnz.TabStop = true;
            rbAnz.Text = "Anzahl der Iterationen ";
            rbAnz.UseVisualStyleBackColor = true;
            // 
            // rbSize
            // 
            rbSize.AutoSize = true;
            rbSize.Location = new Point(3, 58);
            rbSize.Name = "rbSize";
            rbSize.Size = new Size(445, 36);
            rbSize.TabIndex = 5;
            rbSize.TabStop = true;
            rbSize.Text = "Solange bis der Fehler kleiner ist, als: ";
            rbSize.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbAnz);
            panel1.Controls.Add(rbSize);
            panel1.Controls.Add(tbIterations);
            panel1.Location = new Point(12, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 107);
            panel1.TabIndex = 6;
            // 
            // lblFalse
            // 
            lblFalse.AutoSize = true;
            lblFalse.Location = new Point(31, 409);
            lblFalse.Name = "lblFalse";
            lblFalse.Size = new Size(334, 32);
            lblFalse.TabIndex = 7;
            lblFalse.Text = "Es wurden x Schritte benötigt ";
            // 
            // btStart
            // 
            btStart.Location = new Point(491, 501);
            btStart.Name = "btStart";
            btStart.Size = new Size(150, 46);
            btStart.TabIndex = 8;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // lbAnzeige
            // 
            lbAnzeige.FormattingEnabled = true;
            lbAnzeige.ItemHeight = 32;
            lbAnzeige.Location = new Point(667, 63);
            lbAnzeige.Name = "lbAnzeige";
            lbAnzeige.Size = new Size(341, 484);
            lbAnzeige.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(667, 28);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 10;
            label3.Text = "Iterationsschritte";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 576);
            Controls.Add(label3);
            Controls.Add(lbAnzeige);
            Controls.Add(btStart);
            Controls.Add(lblFalse);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(tbSmallerAs);
            Controls.Add(tbEingabe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEingabe;
        private TextBox tbIterations;
        private TextBox tbSmallerAs;
        private Label label1;
        private RadioButton rbAnz;
        private RadioButton rbSize;
        private Panel panel1;
        private Label lblFalse;
        private Button btStart;
        private ListBox lbAnzeige;
        private Label label3;
    }
}
