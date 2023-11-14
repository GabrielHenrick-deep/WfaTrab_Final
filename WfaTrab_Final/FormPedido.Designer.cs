namespace WfaTrab_Final
{
    partial class FormPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtb_data_pedido = new System.Windows.Forms.MaskedTextBox();
            this.tb_situaPed = new System.Windows.Forms.TextBox();
            this.bt_cadPd = new System.Windows.Forms.Button();
            this.bt_clearPed = new System.Windows.Forms.Button();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.cb_modelo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nome_cliente = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite as informações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data do pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Situação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente";
            // 
            // mtb_data_pedido
            // 
            this.mtb_data_pedido.Location = new System.Drawing.Point(114, 105);
            this.mtb_data_pedido.Name = "mtb_data_pedido";
            this.mtb_data_pedido.Size = new System.Drawing.Size(205, 20);
            this.mtb_data_pedido.TabIndex = 7;
            // 
            // tb_situaPed
            // 
            this.tb_situaPed.Location = new System.Drawing.Point(114, 133);
            this.tb_situaPed.Name = "tb_situaPed";
            this.tb_situaPed.Size = new System.Drawing.Size(205, 20);
            this.tb_situaPed.TabIndex = 8;
            // 
            // bt_cadPd
            // 
            this.bt_cadPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadPd.Location = new System.Drawing.Point(99, 250);
            this.bt_cadPd.Name = "bt_cadPd";
            this.bt_cadPd.Size = new System.Drawing.Size(75, 23);
            this.bt_cadPd.TabIndex = 11;
            this.bt_cadPd.Text = "Cadastrar";
            this.bt_cadPd.UseVisualStyleBackColor = true;
            this.bt_cadPd.Click += new System.EventHandler(this.bt_cadPd_Click);
            // 
            // bt_clearPed
            // 
            this.bt_clearPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clearPed.Location = new System.Drawing.Point(217, 250);
            this.bt_clearPed.Name = "bt_clearPed";
            this.bt_clearPed.Size = new System.Drawing.Size(75, 23);
            this.bt_clearPed.TabIndex = 12;
            this.bt_clearPed.Text = "Limpar";
            this.bt_clearPed.UseVisualStyleBackColor = true;
            // 
            // cb_cliente
            // 
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(114, 47);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(205, 21);
            this.cb_cliente.TabIndex = 13;
            this.cb_cliente.SelectedIndexChanged += new System.EventHandler(this.cb_cliente_SelectedIndexChanged);
            // 
            // cb_modelo
            // 
            this.cb_modelo.FormattingEnabled = true;
            this.cb_modelo.Location = new System.Drawing.Point(114, 168);
            this.cb_modelo.Name = "cb_modelo";
            this.cb_modelo.Size = new System.Drawing.Size(205, 21);
            this.cb_modelo.TabIndex = 15;
            this.cb_modelo.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Modelo";
            // 
            // tb_nome_cliente
            // 
            this.tb_nome_cliente.Location = new System.Drawing.Point(114, 79);
            this.tb_nome_cliente.Name = "tb_nome_cliente";
            this.tb_nome_cliente.Size = new System.Drawing.Size(205, 20);
            this.tb_nome_cliente.TabIndex = 17;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(114, 205);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(205, 20);
            this.tb_preco.TabIndex = 18;
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(372, 313);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_nome_cliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_modelo);
            this.Controls.Add(this.cb_cliente);
            this.Controls.Add(this.bt_clearPed);
            this.Controls.Add(this.bt_cadPd);
            this.Controls.Add(this.tb_situaPed);
            this.Controls.Add(this.mtb_data_pedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPedido";
            this.Text = "Cadastro dos pedidos";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtb_data_pedido;
        private System.Windows.Forms.TextBox tb_situaPed;
        private System.Windows.Forms.Button bt_cadPd;
        private System.Windows.Forms.Button bt_clearPed;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.ComboBox cb_modelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nome_cliente;
        private System.Windows.Forms.TextBox tb_preco;
    }
}