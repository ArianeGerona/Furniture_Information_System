namespace FinalProject
{
    partial class SOFA
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
            this.tbxSearchsofa = new System.Windows.Forms.TextBox();
            this.btnSearchsofa = new System.Windows.Forms.Button();
            this.dgvSofa = new System.Windows.Forms.DataGridView();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnSback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSofa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "SOFA FURNITURE AVAILABLE";
            // 
            // tbxSearchsofa
            // 
            this.tbxSearchsofa.Location = new System.Drawing.Point(89, 80);
            this.tbxSearchsofa.Name = "tbxSearchsofa";
            this.tbxSearchsofa.Size = new System.Drawing.Size(232, 20);
            this.tbxSearchsofa.TabIndex = 1;
            // 
            // btnSearchsofa
            // 
            this.btnSearchsofa.BackColor = System.Drawing.Color.Peru;
            this.btnSearchsofa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchsofa.Location = new System.Drawing.Point(12, 76);
            this.btnSearchsofa.Name = "btnSearchsofa";
            this.btnSearchsofa.Size = new System.Drawing.Size(71, 23);
            this.btnSearchsofa.TabIndex = 2;
            this.btnSearchsofa.Text = "SEARCH";
            this.btnSearchsofa.UseVisualStyleBackColor = false;
            this.btnSearchsofa.Click += new System.EventHandler(this.btnSearchsofa_Click);
            // 
            // dgvSofa
            // 
            this.dgvSofa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSofa.Location = new System.Drawing.Point(12, 113);
            this.dgvSofa.Name = "dgvSofa";
            this.dgvSofa.RowHeadersWidth = 51;
            this.dgvSofa.Size = new System.Drawing.Size(628, 282);
            this.dgvSofa.TabIndex = 3;
            this.dgvSofa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSofa_CellClick);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Peru;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(233, 430);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(182, 32);
            this.btnPurchase.TabIndex = 7;
            this.btnPurchase.Text = "PROCEED TO PURCHASE";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchasesofa_Click);
            // 
            // btnSback
            // 
            this.btnSback.BackColor = System.Drawing.Color.Peru;
            this.btnSback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSback.Location = new System.Drawing.Point(574, 41);
            this.btnSback.Margin = new System.Windows.Forms.Padding(2);
            this.btnSback.Name = "btnSback";
            this.btnSback.Size = new System.Drawing.Size(65, 27);
            this.btnSback.TabIndex = 15;
            this.btnSback.Text = "BACK";
            this.btnSback.UseVisualStyleBackColor = false;
            this.btnSback.Click += new System.EventHandler(this.btnSback_Click);
            // 
            // SOFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.il_fullxfull_734593945_7f69;
            this.ClientSize = new System.Drawing.Size(652, 495);
            this.Controls.Add(this.btnSback);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.dgvSofa);
            this.Controls.Add(this.btnSearchsofa);
            this.Controls.Add(this.tbxSearchsofa);
            this.Controls.Add(this.panel1);
            this.Name = "SOFA";
            this.Text = "SOFA";
            this.Load += new System.EventHandler(this.SOFA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSofa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchsofa;
        private System.Windows.Forms.Button btnSearchsofa;
        private System.Windows.Forms.DataGridView dgvSofa;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnSback;
    }
}