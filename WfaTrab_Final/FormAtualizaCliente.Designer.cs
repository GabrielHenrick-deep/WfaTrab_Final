namespace WfaTrab_Final
{
    partial class FormAtualizaCliente
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
            this.data_atua_cliente = new System.Windows.Forms.DataGridView();
            this.bt_atu_cliente = new System.Windows.Forms.Button();
            this.bt_exluir_cliente = new System.Windows.Forms.Button();
            this.bt_conClinete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_atua_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // data_atua_cliente
            // 
            this.data_atua_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_atua_cliente.Location = new System.Drawing.Point(12, 12);
            this.data_atua_cliente.Name = "data_atua_cliente";
            this.data_atua_cliente.Size = new System.Drawing.Size(775, 263);
            this.data_atua_cliente.TabIndex = 52;
            // 
            // bt_atu_cliente
            // 
            this.bt_atu_cliente.Location = new System.Drawing.Point(12, 293);
            this.bt_atu_cliente.Name = "bt_atu_cliente";
            this.bt_atu_cliente.Size = new System.Drawing.Size(75, 23);
            this.bt_atu_cliente.TabIndex = 53;
            this.bt_atu_cliente.Text = "Atualizar";
            this.bt_atu_cliente.UseVisualStyleBackColor = true;
            this.bt_atu_cliente.Click += new System.EventHandler(this.bt_atu_cliente_Click);
            // 
            // bt_exluir_cliente
            // 
            this.bt_exluir_cliente.Location = new System.Drawing.Point(116, 293);
            this.bt_exluir_cliente.Name = "bt_exluir_cliente";
            this.bt_exluir_cliente.Size = new System.Drawing.Size(75, 23);
            this.bt_exluir_cliente.TabIndex = 54;
            this.bt_exluir_cliente.Text = "Excluir";
            this.bt_exluir_cliente.UseVisualStyleBackColor = true;
            this.bt_exluir_cliente.Click += new System.EventHandler(this.bt_exluir_cliente_Click);
            // 
            // bt_conClinete
            // 
            this.bt_conClinete.Location = new System.Drawing.Point(712, 293);
            this.bt_conClinete.Name = "bt_conClinete";
            this.bt_conClinete.Size = new System.Drawing.Size(75, 23);
            this.bt_conClinete.TabIndex = 55;
            this.bt_conClinete.Text = "Confirmar";
            this.bt_conClinete.UseVisualStyleBackColor = true;
            this.bt_conClinete.Click += new System.EventHandler(this.bt_conClinete_Click);
            // 
            // FormAtualizaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.bt_conClinete);
            this.Controls.Add(this.bt_exluir_cliente);
            this.Controls.Add(this.bt_atu_cliente);
            this.Controls.Add(this.data_atua_cliente);
            this.Name = "FormAtualizaCliente";
            this.Text = "AtualizaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.data_atua_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView data_atua_cliente;
        private System.Windows.Forms.Button bt_atu_cliente;
        private System.Windows.Forms.Button bt_exluir_cliente;
        private System.Windows.Forms.Button bt_conClinete;
    }
}