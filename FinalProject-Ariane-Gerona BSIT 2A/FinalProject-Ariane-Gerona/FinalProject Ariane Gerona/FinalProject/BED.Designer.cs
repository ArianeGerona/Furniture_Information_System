namespace FinalProject
{
    partial class BED
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
            this.dgvBed = new System.Windows.Forms.DataGridView();
            this.tbxSearchbed = new System.Windows.Forms.TextBox();
            this.btnSearchbed = new System.Windows.Forms.Button();
            this.btnPurchasebed = new System.Windows.Forms.Button();
            this.btnBback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "BED FURNITURE AVAILABLE";
            // 
            // dgvBed
            // 
            this.dgvBed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBed.Location = new System.Drawing.Point(12, 127);
            this.dgvBed.Name = "dgvBed";
            this.dgvBed.RowHeadersWidth = 51;
            this.dgvBed.Size = new System.Drawing.Size(632, 273);
            this.dgvBed.TabIndex = 1;
            this.dgvBed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBed_CellClick);
            // 
            // tbxSearchbed
            // 
            this.tbxSearchbed.Location = new System.Drawing.Point(82, 90);
            this.tbxSearchbed.Name = "tbxSearchbed";
            this.tbxSearchbed.Size = new System.Drawing.Size(239, 20);
            this.tbxSearchbed.TabIndex = 2;
            // 
            // btnSearchbed
            // 
            this.btnSearchbed.BackColor = System.Drawing.Color.Peru;
            this.btnSearchbed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchbed.Location = new System.Drawing.Point(12, 88);
            this.btnSearchbed.Name = "btnSearchbed";
            this.btnSearchbed.Size = new System.Drawing.Size(64, 20);
            this.btnSearchbed.TabIndex = 8;
            this.btnSearchbed.Text = "SEARCH";
            this.btnSearchbed.UseVisualStyleBackColor = false;
            this.btnSearchbed.Click += new System.EventHandler(this.btnSearchbed_Click);
            // 
            // btnPurchasebed
            // 
            this.btnPurchasebed.BackColor = System.Drawing.Color.Peru;
            this.btnPurchasebed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasebed.Location = new System.Drawing.Point(244, 450);
            this.btnPurchasebed.Name = "btnPurchasebed";
            this.btnPurchasebed.Size = new System.Drawing.Size(190, 32);
            this.btnPurchasebed.TabIndex = 10;
            this.btnPurchasebed.Text = "PROCEED TO PURCHASE";
            this.btnPurchasebed.UseVisualStyleBackColor = false;
            this.btnPurchasebed.Click += new System.EventHandler(this.btnPurchasebed_Click);
            // 
            // btnBback
            // 
            this.btnBback.BackColor = System.Drawing.Color.Peru;
            this.btnBback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBback.Location = new System.Drawing.Point(579, 44);
            this.btnBback.Margin = new System.Windows.Forms.Padding(2);
            this.btnBback.Name = "btnBback";
            this.btnBback.Size = new System.Drawing.Size(65, 27);
            this.btnBback.TabIndex = 15;
            this.btnBback.Text = "BACK";
            this.btnBback.UseVisualStyleBackColor = false;
            this.btnBback.Click += new System.EventHandler(this.btnBback_Click);
            // 
            // BED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.il_fullxfull_734593945_7f69;
            this.ClientSize = new System.Drawing.Size(656, 504);
            this.Controls.Add(this.btnBback);
            this.Controls.Add(this.btnPurchasebed);
            this.Controls.Add(this.btnSearchbed);
            this.Controls.Add(this.tbxSearchbed);
            this.Controls.Add(this.dgvBed);
            this.Controls.Add(this.panel1);
            this.Name = "BED";
            this.Text = "BED";
            this.Load += new System.EventHandler(this.BED_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBed;
        private System.Windows.Forms.TextBox tbxSearchbed;
        private System.Windows.Forms.Button btnSearchbed;
        private System.Windows.Forms.Button btnPurchasebed;
        private System.Windows.Forms.Button btnBback;
    }
}