
namespace StockInfoW
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStockInfo = new System.Windows.Forms.TabPage();
            this.tabStocks = new System.Windows.Forms.TabControl();
            this.textStock1 = new System.Windows.Forms.TextBox();
            this.btnGetStock1 = new System.Windows.Forms.Button();
            this.tabWatchList = new System.Windows.Forms.TabPage();
            this.tabWLExtensive = new System.Windows.Forms.TabPage();
            this.tabMyPortfolio = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabStockInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabStockInfo);
            this.tabControl1.Controls.Add(this.tabWatchList);
            this.tabControl1.Controls.Add(this.tabWLExtensive);
            this.tabControl1.Controls.Add(this.tabMyPortfolio);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 528);
            this.tabControl1.TabIndex = 7;
            // 
            // tabStockInfo
            // 
            this.tabStockInfo.Controls.Add(this.tabStocks);
            this.tabStockInfo.Controls.Add(this.textStock1);
            this.tabStockInfo.Controls.Add(this.btnGetStock1);
            this.tabStockInfo.Location = new System.Drawing.Point(4, 29);
            this.tabStockInfo.Name = "tabStockInfo";
            this.tabStockInfo.Size = new System.Drawing.Size(1009, 495);
            this.tabStockInfo.TabIndex = 0;
            this.tabStockInfo.Text = "Stock Information";
            this.tabStockInfo.UseVisualStyleBackColor = true;
            // 
            // tabStocks
            // 
            this.tabStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabStocks.Location = new System.Drawing.Point(228, 13);
            this.tabStocks.Name = "tabStocks";
            this.tabStocks.SelectedIndex = 0;
            this.tabStocks.Size = new System.Drawing.Size(728, 448);
            this.tabStocks.TabIndex = 2;
            // 
            // textStock1
            // 
            this.textStock1.Location = new System.Drawing.Point(43, 49);
            this.textStock1.Name = "textStock1";
            this.textStock1.Size = new System.Drawing.Size(142, 27);
            this.textStock1.TabIndex = 1;
            // 
            // btnGetStock1
            // 
            this.btnGetStock1.Location = new System.Drawing.Point(42, 82);
            this.btnGetStock1.Name = "btnGetStock1";
            this.btnGetStock1.Size = new System.Drawing.Size(143, 51);
            this.btnGetStock1.TabIndex = 0;
            this.btnGetStock1.Text = "Get Stock Info";
            this.btnGetStock1.UseVisualStyleBackColor = true;
            this.btnGetStock1.Click += new System.EventHandler(this.btnGetStock1_Click);
            // 
            // tabWatchList
            // 
            this.tabWatchList.Location = new System.Drawing.Point(4, 29);
            this.tabWatchList.Name = "tabWatchList";
            this.tabWatchList.Size = new System.Drawing.Size(1009, 495);
            this.tabWatchList.TabIndex = 1;
            this.tabWatchList.Text = "My Watch List";
            this.tabWatchList.UseVisualStyleBackColor = true;
            // 
            // tabWLExtensive
            // 
            this.tabWLExtensive.Location = new System.Drawing.Point(4, 29);
            this.tabWLExtensive.Name = "tabWLExtensive";
            this.tabWLExtensive.Size = new System.Drawing.Size(1009, 495);
            this.tabWLExtensive.TabIndex = 3;
            this.tabWLExtensive.Text = "Watch List Extensive";
            this.tabWLExtensive.UseVisualStyleBackColor = true;
            // 
            // tabMyPortfolio
            // 
            this.tabMyPortfolio.Location = new System.Drawing.Point(4, 29);
            this.tabMyPortfolio.Name = "tabMyPortfolio";
            this.tabMyPortfolio.Size = new System.Drawing.Size(1009, 495);
            this.tabMyPortfolio.TabIndex = 2;
            this.tabMyPortfolio.Text = "My Portfolio";
            this.tabMyPortfolio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStockInfo.ResumeLayout(false);
            this.tabStockInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStockInfo;
        private System.Windows.Forms.TabPage tabWatchList;
        private System.Windows.Forms.TabPage tabWLExtensive;
        private System.Windows.Forms.TabPage tabMyPortfolio;
        private System.Windows.Forms.Button btnGetStock1;
        private System.Windows.Forms.TextBox textStock1;
        private System.Windows.Forms.TabControl tabStocks;
    }
}

