namespace WfaTrab_Final
{
    partial class FormAtualizaPijama
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
            this.bt_con_pijama = new System.Windows.Forms.Button();
            this.bt_exluir_pijama = new System.Windows.Forms.Button();
            this.bt_atu_pijama = new System.Windows.Forms.Button();
            this.data_atua_pijama = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_atua_pijama)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_con_pijama
            // 
            this.bt_con_pijama.Location = new System.Drawing.Point(713, 289);
            this.bt_con_pijama.Name = "bt_con_pijama";
            this.bt_con_pijama.Size = new System.Drawing.Size(75, 23);
            this.bt_con_pijama.TabIndex = 63;
            this.bt_con_pijama.Text = "Confirmar";
            this.bt_con_pijama.UseVisualStyleBackColor = true;
            this.bt_con_pijama.Click += new System.EventHandler(this.bt_con_pijama_Click);
            // 
            // bt_exluir_pijama
            // 
            this.bt_exluir_pijama.Location = new System.Drawing.Point(117, 289);
            this.bt_exluir_pijama.Name = "bt_exluir_pijama";
            this.bt_exluir_pijama.Size = new System.Drawing.Size(75, 23);
            this.bt_exluir_pijama.TabIndex = 62;
            this.bt_exluir_pijama.Text = "Excluir";
            this.bt_exluir_pijama.UseVisualStyleBackColor = true;
            this.bt_exluir_pijama.Click += new System.EventHandler(this.bt_exluir_pijama_Click);
            // 
            // bt_atu_pijama
            // 
            this.bt_atu_pijama.Location = new System.Drawing.Point(13, 289);
            this.bt_atu_pijama.Name = "bt_atu_pijama";
            this.bt_atu_pijama.Size = new System.Drawing.Size(75, 23);
            this.bt_atu_pijama.TabIndex = 61;
            this.bt_atu_pijama.Text = "Editar";
            this.bt_atu_pijama.UseVisualStyleBackColor = true;
            this.bt_atu_pijama.Click += new System.EventHandler(this.bt_atu_pijama_Click);
            // 
            // data_atua_pijama
            // 
            this.data_atua_pijama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_atua_pijama.Location = new System.Drawing.Point(13, 8);
            this.data_atua_pijama.Name = "data_atua_pijama";
            this.data_atua_pijama.Size = new System.Drawing.Size(775, 263);
            this.data_atua_pijama.TabIndex = 60;
            // 
            // FormAtualizaPijama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.bt_con_pijama);
            this.Controls.Add(this.bt_exluir_pijama);
            this.Controls.Add(this.bt_atu_pijama);
            this.Controls.Add(this.data_atua_pijama);
            this.Name = "FormAtualizaPijama";
            this.Text = "FormAtualizaPijama";
            ((System.ComponentModel.ISupportInitialize)(this.data_atua_pijama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_con_pijama;
        private System.Windows.Forms.Button bt_exluir_pijama;
        private System.Windows.Forms.Button bt_atu_pijama;
        private System.Windows.Forms.DataGridView data_atua_pijama;
    }
}