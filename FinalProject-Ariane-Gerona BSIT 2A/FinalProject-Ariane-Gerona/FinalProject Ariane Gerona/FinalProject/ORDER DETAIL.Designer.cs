namespace FinalProject
{
    partial class ORDER_DETAIL
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
            this.dgvOrderdetail = new System.Windows.Forms.DataGridView();
            this.tbxOrderdetail = new System.Windows.Forms.TextBox();
            this.btnSearchdetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnViewdetail = new System.Windows.Forms.Button();
            this.btnBackdetail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderdetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderdetail
            // 
            this.dgvOrderdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderdetail.Location = new System.Drawing.Point(27, 187);
            this.dgvOrderdetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrderdetail.Name = "dgvOrderdetail";
            this.dgvOrderdetail.RowHeadersWidth = 51;
            this.dgvOrderdetail.RowTemplate.Height = 24;
            this.dgvOrderdetail.Size = new System.Drawing.Size(947, 340);
            this.dgvOrderdetail.TabIndex = 0;
            this.dgvOrderdetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderdetail_CellClick);
            // 
            // tbxOrderdetail
            // 
            this.tbxOrderdetail.Location = new System.Drawing.Point(223, 143);
            this.tbxOrderdetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxOrderdetail.Name = "tbxOrderdetail";
            this.tbxOrderdetail.Size = new System.Drawing.Size(296, 22);
            this.tbxOrderdetail.TabIndex = 1;
            // 
            // btnSearchdetail
            // 
            this.btnSearchdetail.BackColor = System.Drawing.Color.Peru;
            this.btnSearchdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchdetail.Location = new System.Drawing.Point(123, 142);
            this.btnSearchdetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchdetail.Name = "btnSearchdetail";
            this.btnSearchdetail.Size = new System.Drawing.Size(96, 26);
            this.btnSearchdetail.TabIndex = 10;
            this.btnSearchdetail.Text = "SEARCH";
            this.btnSearchdetail.UseVisualStyleBackColor = false;
            this.btnSearchdetail.Click += new System.EventHandler(this.btnSearchdetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "View Order";
            // 
            // btnPaid
            // 
            this.btnPaid.BackColor = System.Drawing.Color.Peru;
            this.btnPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaid.Location = new System.Drawing.Point(853, 555);
            this.btnPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(103, 50);
            this.btnPaid.TabIndex = 14;
            this.btnPaid.Text = "PAID";
            this.btnPaid.UseVisualStyleBackColor = false;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // btnViewdetail
            // 
            this.btnViewdetail.BackColor = System.Drawing.Color.Peru;
            this.btnViewdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewdetail.Location = new System.Drawing.Point(27, 142);
            this.btnViewdetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewdetail.Name = "btnViewdetail";
            this.btnViewdetail.Size = new System.Drawing.Size(95, 26);
            this.btnViewdetail.TabIndex = 15;
            this.btnViewdetail.Text = "View All";
            this.btnViewdetail.UseVisualStyleBackColor = false;
            this.btnViewdetail.Click += new System.EventHandler(this.btnViewdetail_Click);
            // 
            // btnBackdetail
            // 
            this.btnBackdetail.BackColor = System.Drawing.Color.Peru;
            this.btnBackdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackdetail.Location = new System.Drawing.Point(885, 55);
            this.btnBackdetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackdetail.Name = "btnBackdetail";
            this.btnBackdetail.Size = new System.Drawing.Size(87, 33);
            this.btnBackdetail.TabIndex = 18;
            this.btnBackdetail.Text = "BACK";
            this.btnBackdetail.UseVisualStyleBackColor = false;
            this.btnBackdetail.Click += new System.EventHandler(this.btnBackdetail_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 47);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Furniture Information System";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(769, 555);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 29);
            this.lblId.TabIndex = 20;
            // 
            // ORDER_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.Silvertop_Ash_Cladding_Shiplap_Sawn_Face_Display_636x795;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 642);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackdetail);
            this.Controls.Add(this.btnViewdetail);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchdetail);
            this.Controls.Add(this.tbxOrderdetail);
            this.Controls.Add(this.dgvOrderdetail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ORDER_DETAIL";
            this.Text = "ORDER_DETAIL";
            this.Load += new System.EventHandler(this.ORDER_DETAIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderdetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderdetail;
        private System.Windows.Forms.TextBox tbxOrderdetail;
        private System.Windows.Forms.Button btnSearchdetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnViewdetail;
        private System.Windows.Forms.Button btnBackdetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
    }
}