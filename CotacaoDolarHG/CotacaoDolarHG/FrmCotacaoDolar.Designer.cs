
namespace CotacaoDolarHG
{
    partial class FrmCotacaoDolar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Buy = new System.Windows.Forms.Label();
            this.lb_Sell = new System.Windows.Forms.Label();
            this.lb_Var = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dólar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compra:";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(338, 378);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 34);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Pesquisar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Venda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Variação:";
            // 
            // lb_Buy
            // 
            this.lb_Buy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Buy.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_Buy.Location = new System.Drawing.Point(147, 113);
            this.lb_Buy.Name = "lb_Buy";
            this.lb_Buy.Size = new System.Drawing.Size(291, 49);
            this.lb_Buy.TabIndex = 5;
            this.lb_Buy.Text = "0,0";
            this.lb_Buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Sell
            // 
            this.lb_Sell.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sell.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_Sell.Location = new System.Drawing.Point(147, 193);
            this.lb_Sell.Name = "lb_Sell";
            this.lb_Sell.Size = new System.Drawing.Size(291, 49);
            this.lb_Sell.TabIndex = 6;
            this.lb_Sell.Text = "0,0";
            this.lb_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Var
            // 
            this.lb_Var.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_Var.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Var.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lb_Var.Location = new System.Drawing.Point(147, 275);
            this.lb_Var.Name = "lb_Var";
            this.lb_Var.Size = new System.Drawing.Size(291, 49);
            this.lb_Var.TabIndex = 7;
            this.lb_Var.Text = "0,0";
            this.lb_Var.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 424);
            this.Controls.Add(this.lb_Var);
            this.Controls.Add(this.lb_Sell);
            this.Controls.Add(this.lb_Buy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Buy;
        private System.Windows.Forms.Label lb_Sell;
        private System.Windows.Forms.Label lb_Var;
    }
}

