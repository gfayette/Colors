namespace ColorApp
{
    partial class Colors
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
            this.redBar = new System.Windows.Forms.TrackBar();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenUpDown = new System.Windows.Forms.NumericUpDown();
            this.normalizeBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // redBar
            // 
            this.redBar.BackColor = System.Drawing.Color.Black;
            this.redBar.Location = new System.Drawing.Point(106, 433);
            this.redBar.Maximum = 1000;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(472, 69);
            this.redBar.TabIndex = 0;
            this.redBar.TickFrequency = 100;
            this.redBar.Scroll += new System.EventHandler(this.redBar_Scroll);
            // 
            // greenBar
            // 
            this.greenBar.BackColor = System.Drawing.Color.Black;
            this.greenBar.Location = new System.Drawing.Point(106, 508);
            this.greenBar.Maximum = 1000;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(472, 69);
            this.greenBar.TabIndex = 1;
            this.greenBar.TickFrequency = 100;
            this.greenBar.Scroll += new System.EventHandler(this.greenBar_Scroll);
            // 
            // blueBar
            // 
            this.blueBar.BackColor = System.Drawing.Color.Black;
            this.blueBar.Location = new System.Drawing.Point(106, 583);
            this.blueBar.Maximum = 1000;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(472, 69);
            this.blueBar.TabIndex = 2;
            this.blueBar.TickFrequency = 100;
            this.blueBar.Scroll += new System.EventHandler(this.blueBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Green";
            // 
            // redUpDown
            // 
            this.redUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redUpDown.Location = new System.Drawing.Point(584, 433);
            this.redUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.redUpDown.Name = "redUpDown";
            this.redUpDown.Size = new System.Drawing.Size(120, 39);
            this.redUpDown.TabIndex = 6;
            this.redUpDown.ValueChanged += new System.EventHandler(this.redUpDown_ValueChanged);
            // 
            // blueUpDown
            // 
            this.blueUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueUpDown.Location = new System.Drawing.Point(584, 583);
            this.blueUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.blueUpDown.Name = "blueUpDown";
            this.blueUpDown.Size = new System.Drawing.Size(120, 39);
            this.blueUpDown.TabIndex = 7;
            this.blueUpDown.ValueChanged += new System.EventHandler(this.blueUpDown_ValueChanged);
            // 
            // greenUpDown
            // 
            this.greenUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenUpDown.Location = new System.Drawing.Point(584, 508);
            this.greenUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.greenUpDown.Name = "greenUpDown";
            this.greenUpDown.Size = new System.Drawing.Size(120, 39);
            this.greenUpDown.TabIndex = 8;
            this.greenUpDown.ValueChanged += new System.EventHandler(this.greenUpDown_ValueChanged);
            // 
            // normalizeBox
            // 
            this.normalizeBox.AutoSize = true;
            this.normalizeBox.BackColor = System.Drawing.Color.Transparent;
            this.normalizeBox.Checked = true;
            this.normalizeBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalizeBox.ForeColor = System.Drawing.Color.White;
            this.normalizeBox.Location = new System.Drawing.Point(18, 367);
            this.normalizeBox.Name = "normalizeBox";
            this.normalizeBox.Size = new System.Drawing.Size(169, 36);
            this.normalizeBox.TabIndex = 9;
            this.normalizeBox.Text = "Normalize";
            this.normalizeBox.UseVisualStyleBackColor = false;
            this.normalizeBox.CheckedChanged += new System.EventHandler(this.normalizeBox_CheckedChanged);
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(735, 664);
            this.Controls.Add(this.normalizeBox);
            this.Controls.Add(this.greenUpDown);
            this.Controls.Add(this.blueUpDown);
            this.Controls.Add(this.redUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueBar);
            this.Controls.Add(this.greenBar);
            this.Controls.Add(this.redBar);
            this.Name = "Colors";
            this.Text = "Colors!";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Colors_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown redUpDown;
        private System.Windows.Forms.NumericUpDown blueUpDown;
        private System.Windows.Forms.NumericUpDown greenUpDown;
        private System.Windows.Forms.CheckBox normalizeBox;
    }
}

