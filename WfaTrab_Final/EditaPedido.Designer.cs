namespace WfaTrab_Final
{
    partial class EditaPedido
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
            this.label7 = new System.Windows.Forms.Label();
            this.cb_modelo = new System.Windows.Forms.ComboBox();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.bt_cadPd = new System.Windows.Forms.Button();
            this.tb_situaPed = new System.Windows.Forms.TextBox();
            this.mtb_data_pedido = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome_cliente2 = new System.Windows.Forms.TextBox();
            this.tb_preco2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Modelo";
            // 
            // cb_modelo
            // 
            this.cb_modelo.FormattingEnabled = true;
            this.cb_modelo.Location = new System.Drawing.Point(135, 183);
            this.cb_modelo.Name = "cb_modelo";
            this.cb_modelo.Size = new System.Drawing.Size(205, 21);
            this.cb_modelo.TabIndex = 30;
            this.cb_modelo.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_SelectedIndexChanged);
            // 
            // cb_cliente
            // 
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(135, 62);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(205, 21);
            this.cb_cliente.TabIndex = 28;
            this.cb_cliente.SelectedIndexChanged += new System.EventHandler(this.cb_cliente_SelectedIndexChanged);
            // 
            // bt_cadPd
            // 
            this.bt_cadPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadPd.Location = new System.Drawing.Point(189, 266);
            this.bt_cadPd.Name = "bt_cadPd";
            this.bt_cadPd.Size = new System.Drawing.Size(75, 23);
            this.bt_cadPd.TabIndex = 26;
            this.bt_cadPd.Text = "Cadastrar";
            this.bt_cadPd.UseVisualStyleBackColor = true;
            this.bt_cadPd.Click += new System.EventHandler(this.bt_cadPd_Click);
            // 
            // tb_situaPed
            // 
            this.tb_situaPed.Location = new System.Drawing.Point(135, 148);
            this.tb_situaPed.Name = "tb_situaPed";
            this.tb_situaPed.Size = new System.Drawing.Size(205, 20);
            this.tb_situaPed.TabIndex = 25;
            // 
            // mtb_data_pedido
            // 
            this.mtb_data_pedido.Location = new System.Drawing.Point(135, 120);
            this.mtb_data_pedido.Name = "mtb_data_pedido";
            this.mtb_data_pedido.Size = new System.Drawing.Size(205, 20);
            this.mtb_data_pedido.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Situação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data do pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "CPF do cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Digite as informações";
            // 
            // tb_nome_cliente2
            // 
            this.tb_nome_cliente2.Location = new System.Drawing.Point(135, 89);
            this.tb_nome_cliente2.Name = "tb_nome_cliente2";
            this.tb_nome_cliente2.Size = new System.Drawing.Size(205, 20);
            this.tb_nome_cliente2.TabIndex = 32;
            // 
            // tb_preco2
            // 
            this.tb_preco2.Location = new System.Drawing.Point(135, 220);
            this.tb_preco2.Name = "tb_preco2";
            this.tb_preco2.Size = new System.Drawing.Size(205, 20);
            this.tb_preco2.TabIndex = 33;
            // 
            // EditaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(372, 313);
            this.Controls.Add(this.tb_preco2);
            this.Controls.Add(this.tb_nome_cliente2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_modelo);
            this.Controls.Add(this.cb_cliente);
            this.Controls.Add(this.bt_cadPd);
            this.Controls.Add(this.tb_situaPed);
            this.Controls.Add(this.mtb_data_pedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditaPedido";
            this.Text = "EditaPedido";
            this.Load += new System.EventHandler(this.EditaPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_modelo;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.Button bt_cadPd;
        private System.Windows.Forms.TextBox tb_situaPed;
        private System.Windows.Forms.MaskedTextBox mtb_data_pedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome_cliente2;
        private System.Windows.Forms.TextBox tb_preco2;
    }
}