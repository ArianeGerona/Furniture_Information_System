namespace FinalProject
{
    partial class TABLE
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
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.tbxSearchtable = new System.Windows.Forms.TextBox();
            this.btnSearchtable = new System.Windows.Forms.Button();
            this.btnPurchasetable = new System.Windows.Forms.Button();
            this.btnTback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 38);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLE FURNITURE AVAILABLE";
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(16, 129);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.Size = new System.Drawing.Size(638, 273);
            this.dgvTable.TabIndex = 3;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            // 
            // tbxSearchtable
            // 
            this.tbxSearchtable.Location = new System.Drawing.Point(93, 100);
            this.tbxSearchtable.Name = "tbxSearchtable";
            this.tbxSearchtable.Size = new System.Drawing.Size(237, 20);
            this.tbxSearchtable.TabIndex = 5;
            // 
            // btnSearchtable
            // 
            this.btnSearchtable.BackColor = System.Drawing.Color.Peru;
            this.btnSearchtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchtable.Location = new System.Drawing.Point(16, 98);
            this.btnSearchtable.Name = "btnSearchtable";
            this.btnSearchtable.Size = new System.Drawing.Size(71, 23);
            this.btnSearchtable.TabIndex = 10;
            this.btnSearchtable.Text = "SEARCH";
            this.btnSearchtable.UseVisualStyleBackColor = false;
            this.btnSearchtable.Click += new System.EventHandler(this.btnSearchtable_Click);
            // 
            // btnPurchasetable
            // 
            this.btnPurchasetable.BackColor = System.Drawing.Color.Peru;
            this.btnPurchasetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasetable.Location = new System.Drawing.Point(220, 452);
            this.btnPurchasetable.Name = "btnPurchasetable";
            this.btnPurchasetable.Size = new System.Drawing.Size(206, 32);
            this.btnPurchasetable.TabIndex = 12;
            this.btnPurchasetable.Text = "PROCEED TO PURCHASE";
            this.btnPurchasetable.UseVisualStyleBackColor = false;
            this.btnPurchasetable.Click += new System.EventHandler(this.btnPurchasetable_Click);
            // 
            // btnTback
            // 
            this.btnTback.BackColor = System.Drawing.Color.Peru;
            this.btnTback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTback.Location = new System.Drawing.Point(589, 44);
            this.btnTback.Margin = new System.Windows.Forms.Padding(2);
            this.btnTback.Name = "btnTback";
            this.btnTback.Size = new System.Drawing.Size(65, 27);
            this.btnTback.TabIndex = 14;
            this.btnTback.Text = "BACK";
            this.btnTback.UseVisualStyleBackColor = false;
            this.btnTback.Click += new System.EventHandler(this.btnTback_Click);
            // 
            // TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.il_fullxfull_734593945_7f69;
            this.ClientSize = new System.Drawing.Size(666, 513);
            this.Controls.Add(this.btnTback);
            this.Controls.Add(this.btnPurchasetable);
            this.Controls.Add(this.btnSearchtable);
            this.Controls.Add(this.tbxSearchtable);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.panel1);
            this.Name = "TABLE";
            this.Text = "TABLE";
            this.Load += new System.EventHandler(this.TABLE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TextBox tbxSearchtable;
        private System.Windows.Forms.Button btnSearchtable;
        private System.Windows.Forms.Button btnPurchasetable;
        private System.Windows.Forms.Button btnTback;
    }
}