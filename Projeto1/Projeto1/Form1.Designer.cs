namespace Projeto1
{
    partial class Form1
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
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblimposto = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbllucro = new System.Windows.Forms.Label();
            this.lblgeral = new System.Windows.Forms.Label();
            this.txtimposto = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtlucro = new System.Windows.Forms.TextBox();
            this.txtgeral = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(66, 92);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(111, 13);
            this.lblvalor.TabIndex = 0;
            this.lblvalor.Text = "Digite o valor do carro";
            this.lblvalor.Click += new System.EventHandler(this.lblvalor_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(216, 93);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(69, 320);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblimposto
            // 
            this.lblimposto.AutoSize = true;
            this.lblimposto.Location = new System.Drawing.Point(66, 130);
            this.lblimposto.Name = "lblimposto";
            this.lblimposto.Size = new System.Drawing.Size(85, 13);
            this.lblimposto.TabIndex = 3;
            this.lblimposto.Text = "Valor do imposto";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(66, 166);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(116, 13);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "Valor total com imposto";
            // 
            // lbllucro
            // 
            this.lbllucro.AutoSize = true;
            this.lbllucro.Location = new System.Drawing.Point(66, 201);
            this.lbllucro.Name = "lbllucro";
            this.lbllucro.Size = new System.Drawing.Size(72, 13);
            this.lbllucro.TabIndex = 5;
            this.lbllucro.Text = "Valor do lucro";
            // 
            // lblgeral
            // 
            this.lblgeral.AutoSize = true;
            this.lblgeral.Location = new System.Drawing.Point(66, 240);
            this.lblgeral.Name = "lblgeral";
            this.lblgeral.Size = new System.Drawing.Size(80, 13);
            this.lblgeral.TabIndex = 6;
            this.lblgeral.Text = "Valor total geral";
            // 
            // txtimposto
            // 
            this.txtimposto.Location = new System.Drawing.Point(216, 130);
            this.txtimposto.Name = "txtimposto";
            this.txtimposto.Size = new System.Drawing.Size(100, 20);
            this.txtimposto.TabIndex = 7;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(216, 166);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 8;
            // 
            // txtlucro
            // 
            this.txtlucro.Location = new System.Drawing.Point(216, 201);
            this.txtlucro.Name = "txtlucro";
            this.txtlucro.Size = new System.Drawing.Size(100, 20);
            this.txtlucro.TabIndex = 9;
            // 
            // txtgeral
            // 
            this.txtgeral.Location = new System.Drawing.Point(216, 240);
            this.txtgeral.Name = "txtgeral";
            this.txtgeral.Size = new System.Drawing.Size(100, 20);
            this.txtgeral.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtgeral);
            this.Controls.Add(this.txtlucro);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtimposto);
            this.Controls.Add(this.lblgeral);
            this.Controls.Add(this.lbllucro);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblimposto);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblimposto;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbllucro;
        private System.Windows.Forms.Label lblgeral;
        private System.Windows.Forms.TextBox txtimposto;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtlucro;
        private System.Windows.Forms.TextBox txtgeral;
    }
}

