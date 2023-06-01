namespace FinalProject
{
    partial class CHAIR
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
            this.dgvChair = new System.Windows.Forms.DataGridView();
            this.tbxSearchchair = new System.Windows.Forms.TextBox();
            this.btnSearchchair = new System.Windows.Forms.Button();
            this.btnPurchasechair = new System.Windows.Forms.Button();
            this.btnChback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChair)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 38);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHAIR FURNITURE AVAILABLE";
            // 
            // dgvChair
            // 
            this.dgvChair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChair.Location = new System.Drawing.Point(10, 129);
            this.dgvChair.Name = "dgvChair";
            this.dgvChair.RowHeadersWidth = 51;
            this.dgvChair.Size = new System.Drawing.Size(638, 273);
            this.dgvChair.TabIndex = 4;
            this.dgvChair.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChair_CellClick);
            this.dgvChair.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChair_CellContentClick);
            // 
            // tbxSearchchair
            // 
            this.tbxSearchchair.Location = new System.Drawing.Point(87, 98);
            this.tbxSearchchair.Name = "tbxSearchchair";
            this.tbxSearchchair.Size = new System.Drawing.Size(229, 20);
            this.tbxSearchchair.TabIndex = 7;
            // 
            // btnSearchchair
            // 
            this.btnSearchchair.BackColor = System.Drawing.Color.Peru;
            this.btnSearchchair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchchair.Location = new System.Drawing.Point(10, 97);
            this.btnSearchchair.Name = "btnSearchchair";
            this.btnSearchchair.Size = new System.Drawing.Size(71, 20);
            this.btnSearchchair.TabIndex = 11;
            this.btnSearchchair.Text = "SEARCH";
            this.btnSearchchair.UseVisualStyleBackColor = false;
            this.btnSearchchair.Click += new System.EventHandler(this.btnSearchchair_Click);
            // 
            // btnPurchasechair
            // 
            this.btnPurchasechair.BackColor = System.Drawing.Color.Peru;
            this.btnPurchasechair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasechair.Location = new System.Drawing.Point(247, 443);
            this.btnPurchasechair.Name = "btnPurchasechair";
            this.btnPurchasechair.Size = new System.Drawing.Size(181, 32);
            this.btnPurchasechair.TabIndex = 15;
            this.btnPurchasechair.Text = "PROCCED TO PURCHASE";
            this.btnPurchasechair.UseVisualStyleBackColor = false;
            this.btnPurchasechair.Click += new System.EventHandler(this.btnPurchasechair_Click);
            // 
            // btnChback
            // 
            this.btnChback.BackColor = System.Drawing.Color.Peru;
            this.btnChback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChback.Location = new System.Drawing.Point(583, 44);
            this.btnChback.Margin = new System.Windows.Forms.Padding(2);
            this.btnChback.Name = "btnChback";
            this.btnChback.Size = new System.Drawing.Size(65, 27);
            this.btnChback.TabIndex = 16;
            this.btnChback.Text = "BACK";
            this.btnChback.UseVisualStyleBackColor = false;
            this.btnChback.Click += new System.EventHandler(this.btnChback_Click);
            // 
            // CHAIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.il_fullxfull_734593945_7f69;
            this.ClientSize = new System.Drawing.Size(657, 515);
            this.Controls.Add(this.btnChback);
            this.Controls.Add(this.btnPurchasechair);
            this.Controls.Add(this.btnSearchchair);
            this.Controls.Add(this.tbxSearchchair);
            this.Controls.Add(this.dgvChair);
            this.Controls.Add(this.panel1);
            this.Name = "CHAIR";
            this.Text = "CHAIR";
            this.Load += new System.EventHandler(this.CHAIR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChair;
        private System.Windows.Forms.TextBox tbxSearchchair;
        private System.Windows.Forms.Button btnSearchchair;
        private System.Windows.Forms.Button btnPurchasechair;
        private System.Windows.Forms.Button btnChback;
    }
}