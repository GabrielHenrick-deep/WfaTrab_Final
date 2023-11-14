namespace WfaTrab_Final
{
    partial class FormAtualizaPedido
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
            this.bt_con_pedido = new System.Windows.Forms.Button();
            this.bt_exluir_pedido = new System.Windows.Forms.Button();
            this.bt_atu_pedido = new System.Windows.Forms.Button();
            this.data_atua_pedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_atua_pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_con_pedido
            // 
            this.bt_con_pedido.Location = new System.Drawing.Point(713, 289);
            this.bt_con_pedido.Name = "bt_con_pedido";
            this.bt_con_pedido.Size = new System.Drawing.Size(75, 23);
            this.bt_con_pedido.TabIndex = 59;
            this.bt_con_pedido.Text = "Confirmar";
            this.bt_con_pedido.UseVisualStyleBackColor = true;
            this.bt_con_pedido.Click += new System.EventHandler(this.bt_con_pedido_Click);
            // 
            // bt_exluir_pedido
            // 
            this.bt_exluir_pedido.Location = new System.Drawing.Point(117, 289);
            this.bt_exluir_pedido.Name = "bt_exluir_pedido";
            this.bt_exluir_pedido.Size = new System.Drawing.Size(75, 23);
            this.bt_exluir_pedido.TabIndex = 58;
            this.bt_exluir_pedido.Text = "Excluir";
            this.bt_exluir_pedido.UseVisualStyleBackColor = true;
            this.bt_exluir_pedido.Click += new System.EventHandler(this.bt_exluir_pedido_Click);
            // 
            // bt_atu_pedido
            // 
            this.bt_atu_pedido.Location = new System.Drawing.Point(13, 289);
            this.bt_atu_pedido.Name = "bt_atu_pedido";
            this.bt_atu_pedido.Size = new System.Drawing.Size(75, 23);
            this.bt_atu_pedido.TabIndex = 57;
            this.bt_atu_pedido.Text = "Editar";
            this.bt_atu_pedido.UseVisualStyleBackColor = true;
            this.bt_atu_pedido.Click += new System.EventHandler(this.bt_atu_pedido_Click);
            // 
            // data_atua_pedido
            // 
            this.data_atua_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_atua_pedido.Location = new System.Drawing.Point(13, 8);
            this.data_atua_pedido.Name = "data_atua_pedido";
            this.data_atua_pedido.Size = new System.Drawing.Size(775, 263);
            this.data_atua_pedido.TabIndex = 56;
            // 
            // FormAtualizaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.bt_con_pedido);
            this.Controls.Add(this.bt_exluir_pedido);
            this.Controls.Add(this.bt_atu_pedido);
            this.Controls.Add(this.data_atua_pedido);
            this.Name = "FormAtualizaPedido";
            this.Text = "FormAtualizaPedido";
            ((System.ComponentModel.ISupportInitialize)(this.data_atua_pedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_con_pedido;
        private System.Windows.Forms.Button bt_exluir_pedido;
        private System.Windows.Forms.Button bt_atu_pedido;
        private System.Windows.Forms.DataGridView data_atua_pedido;
    }
}