namespace EMVQRDecoder
{
    partial class EMVQRDecoder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUtf8 = new System.Windows.Forms.TextBox();
            this.textHex = new System.Windows.Forms.TextBox();
            this.decodeUtf8QRBtn = new System.Windows.Forms.Button();
            this.decodeHexQRBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.decodedResultGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decodedResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 443);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decodeHexQRBtn);
            this.groupBox1.Controls.Add(this.decodeUtf8QRBtn);
            this.groupBox1.Controls.Add(this.textHex);
            this.groupBox1.Controls.Add(this.textUtf8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QR String";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QR String (UTF8):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "QR String (HEX):";
            // 
            // textUtf8
            // 
            this.textUtf8.Location = new System.Drawing.Point(115, 42);
            this.textUtf8.Name = "textUtf8";
            this.textUtf8.Size = new System.Drawing.Size(563, 20);
            this.textUtf8.TabIndex = 1;
            // 
            // textHex
            // 
            this.textHex.Location = new System.Drawing.Point(115, 83);
            this.textHex.Name = "textHex";
            this.textHex.Size = new System.Drawing.Size(563, 20);
            this.textHex.TabIndex = 2;
            // 
            // decodeUtf8QRBtn
            // 
            this.decodeUtf8QRBtn.Location = new System.Drawing.Point(684, 42);
            this.decodeUtf8QRBtn.Name = "decodeUtf8QRBtn";
            this.decodeUtf8QRBtn.Size = new System.Drawing.Size(75, 23);
            this.decodeUtf8QRBtn.TabIndex = 3;
            this.decodeUtf8QRBtn.Text = "Decode";
            this.decodeUtf8QRBtn.UseVisualStyleBackColor = true;
            this.decodeUtf8QRBtn.Click += new System.EventHandler(this.decodeUtf8QRBtn_Click);
            // 
            // decodeHexQRBtn
            // 
            this.decodeHexQRBtn.Location = new System.Drawing.Point(684, 80);
            this.decodeHexQRBtn.Name = "decodeHexQRBtn";
            this.decodeHexQRBtn.Size = new System.Drawing.Size(75, 23);
            this.decodeHexQRBtn.TabIndex = 4;
            this.decodeHexQRBtn.Text = "Decode";
            this.decodeHexQRBtn.UseVisualStyleBackColor = true;
            this.decodeHexQRBtn.Click += new System.EventHandler(this.decodeHexQRBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.decodedResultGrid);
            this.groupBox2.Location = new System.Drawing.Point(14, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decode Result";
            // 
            // decodedResultGrid
            // 
            this.decodedResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.decodedResultGrid.Location = new System.Drawing.Point(19, 32);
            this.decodedResultGrid.Name = "decodedResultGrid";
            this.decodedResultGrid.Size = new System.Drawing.Size(740, 210);
            this.decodedResultGrid.TabIndex = 0;
            // 
            // EMVQRDecoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 467);
            this.Controls.Add(this.panel1);
            this.Name = "EMVQRDecoder";
            this.Text = "EMV QR Decoder";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.decodedResultGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHex;
        private System.Windows.Forms.TextBox textUtf8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decodeHexQRBtn;
        private System.Windows.Forms.Button decodeUtf8QRBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView decodedResultGrid;
    }
}

