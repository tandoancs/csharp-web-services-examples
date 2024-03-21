namespace ConsumeConvertWS
{

    partial class Form1
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
            this.lblQuyDoi = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnVND2USD = new System.Windows.Forms.Button();
            this.btnVND2EUR = new System.Windows.Forms.Button();
            this.btnUSD2VND = new System.Windows.Forms.Button();
            this.btnEUR2VND = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblQuyDoi
            // 
            this.lblQuyDoi.AutoSize = true;
            this.lblQuyDoi.Location = new System.Drawing.Point(32, 37);
            this.lblQuyDoi.Name = "lblQuyDoi";
            this.lblQuyDoi.Size = new System.Drawing.Size(44, 13);
            this.lblQuyDoi.TabIndex = 0;
            this.lblQuyDoi.Text = "Quy đổi";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(106, 34);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(387, 20);
            this.txtMoney.TabIndex = 1;

            // 
            // btnVND2USD
            // 
            this.btnVND2USD.Location = new System.Drawing.Point(35, 76);
            this.btnVND2USD.Name = "btnVND2USD";
            this.btnVND2USD.Size = new System.Drawing.Size(106, 23);
            this.btnVND2USD.TabIndex = 2;
            this.btnVND2USD.Text = "VND to USD";
            this.btnVND2USD.UseVisualStyleBackColor = true;
            this.btnVND2USD.Click += new System.EventHandler(this.btnVND2USD_Click);
            // 
            // btnVND2EUR
            // 
            this.btnVND2EUR.Location = new System.Drawing.Point(147, 76);
            this.btnVND2EUR.Name = "btnVND2EUR";
            this.btnVND2EUR.Size = new System.Drawing.Size(106, 23);
            this.btnVND2EUR.TabIndex = 2;
            this.btnVND2EUR.Text = "VND to EUR";
            this.btnVND2EUR.UseVisualStyleBackColor = true;
            this.btnVND2EUR.Click += new System.EventHandler(this.btnVND2EUR_Click);
            // 
            // btnUSD2VND
            // 
            this.btnUSD2VND.Location = new System.Drawing.Point(275, 76);
            this.btnUSD2VND.Name = "btnUSD2VND";
            this.btnUSD2VND.Size = new System.Drawing.Size(106, 23);
            this.btnUSD2VND.TabIndex = 2;
            this.btnUSD2VND.Text = "USD to VND";
            this.btnUSD2VND.UseVisualStyleBackColor = true;
            this.btnUSD2VND.Click += new System.EventHandler(this.btnUSD2VND_Click);
            // 
            // btnEUR2VND
            // 
            this.btnEUR2VND.Location = new System.Drawing.Point(387, 76);
            this.btnEUR2VND.Name = "btnEUR2VND";
            this.btnEUR2VND.Size = new System.Drawing.Size(106, 23);
            this.btnEUR2VND.TabIndex = 2;
            this.btnEUR2VND.Text = "EUR to VND";
            this.btnEUR2VND.UseVisualStyleBackColor = true;
            this.btnEUR2VND.Click += new System.EventHandler(this.btnEUR2VND_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(32, 131);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 13);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = "Kết quả";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(106, 128);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(387, 20);
            this.txtResult.TabIndex = 3;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 169);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEUR2VND);
            this.Controls.Add(this.btnUSD2VND);
            this.Controls.Add(this.btnVND2EUR);
            this.Controls.Add(this.btnVND2USD);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblQuyDoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuyDoi;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnVND2USD;
        private System.Windows.Forms.Button btnVND2EUR;
        private System.Windows.Forms.Button btnUSD2VND;
        private System.Windows.Forms.Button btnEUR2VND;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtResult;
    }
}

