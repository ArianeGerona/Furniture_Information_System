namespace FinalProject
{
    partial class CABINET
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCabinet = new System.Windows.Forms.DataGridView();
            this.tbxSearchcabinet = new System.Windows.Forms.TextBox();
            this.btnSearchcabinet = new System.Windows.Forms.Button();
            this.btnPurchasecabinet = new System.Windows.Forms.Button();
            this.btnCback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabinet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 38);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CABINET FURNITURE AVAILABLE";
            // 
            // dgvCabinet
            // 
            this.dgvCabinet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabinet.Location = new System.Drawing.Point(12, 132);
            this.dgvCabinet.Name = "dgvCabinet";
            this.dgvCabinet.RowHeadersWidth = 51;
            this.dgvCabinet.Size = new System.Drawing.Size(638, 273);
            this.dgvCabinet.TabIndex = 2;
            this.dgvCabinet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCabinet_CellClick);
            // 
            // tbxSearchcabinet
            // 
            this.tbxSearchcabinet.Location = new System.Drawing.Point(89, 93);
            this.tbxSearchcabinet.Name = "tbxSearchcabinet";
            this.tbxSearchcabinet.Size = new System.Drawing.Size(239, 20);
            this.tbxSearchcabinet.TabIndex = 3;
            // 
            // btnSearchcabinet
            // 
            this.btnSearchcabinet.BackColor = System.Drawing.Color.Peru;
            this.btnSearchcabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchcabinet.Location = new System.Drawing.Point(12, 90);
            this.btnSearchcabinet.Name = "btnSearchcabinet";
            this.btnSearchcabinet.Size = new System.Drawing.Size(71, 25);
            this.btnSearchcabinet.TabIndex = 9;
            this.btnSearchcabinet.Text = "SEARCH";
            this.btnSearchcabinet.UseVisualStyleBackColor = false;
            this.btnSearchcabinet.Click += new System.EventHandler(this.btnSearchcabinet_Click);
            // 
            // btnPurchasecabinet
            // 
            this.btnPurchasecabinet.BackColor = System.Drawing.Color.Peru;
            this.btnPurchasecabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasecabinet.Location = new System.Drawing.Point(226, 446);
            this.btnPurchasecabinet.Name = "btnPurchasecabinet";
            this.btnPurchasecabinet.Size = new System.Drawing.Size(203, 32);
            this.btnPurchasecabinet.TabIndex = 11;
            this.btnPurchasecabinet.Text = "PROCEED TO PURCHASE";
            this.btnPurchasecabinet.UseVisualStyleBackColor = false;
            this.btnPurchasecabinet.Click += new System.EventHandler(this.btnPurchasecabinet_Click);
            // 
            // btnCback
            // 
            this.btnCback.BackColor = System.Drawing.Color.Peru;
            this.btnCback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCback.Location = new System.Drawing.Point(585, 44);
            this.btnCback.Margin = new System.Windows.Forms.Padding(2);
            this.btnCback.Name = "btnCback";
            this.btnCback.Size = new System.Drawing.Size(65, 27);
            this.btnCback.TabIndex = 15;
            this.btnCback.Text = "BACK";
            this.btnCback.UseVisualStyleBackColor = false;
            this.btnCback.Click += new System.EventHandler(this.btnCback_Click);
            // 
            // CABINET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.il_fullxfull_734593945_7f69;
            this.ClientSize = new System.Drawing.Size(662, 509);
            this.Controls.Add(this.btnCback);
            this.Controls.Add(this.btnPurchasecabinet);
            this.Controls.Add(this.btnSearchcabinet);
            this.Controls.Add(this.tbxSearchcabinet);
            this.Controls.Add(this.dgvCabinet);
            this.Controls.Add(this.panel1);
            this.Name = "CABINET";
            this.Text = "CABINET";
            this.Load += new System.EventHandler(this.CABINET_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabinet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCabinet;
        private System.Windows.Forms.TextBox tbxSearchcabinet;
        private System.Windows.Forms.Button btnSearchcabinet;
        private System.Windows.Forms.Button btnPurchasecabinet;
        private System.Windows.Forms.Button btnCback;
    }
}