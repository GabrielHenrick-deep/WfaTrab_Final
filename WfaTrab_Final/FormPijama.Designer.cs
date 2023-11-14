namespace WfaTrab_Final
{
    partial class FormPijama
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
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.tb_precoPj = new System.Windows.Forms.TextBox();
            this.tb_tamanho = new System.Windows.Forms.TextBox();
            this.tb_material = new System.Windows.Forms.TextBox();
            this.tb_estoq = new System.Windows.Forms.TextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_clearPj = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tamanho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estoque";
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(95, 47);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(205, 20);
            this.tb_desc.TabIndex = 6;
            // 
            // tb_precoPj
            // 
            this.tb_precoPj.Location = new System.Drawing.Point(95, 80);
            this.tb_precoPj.Name = "tb_precoPj";
            this.tb_precoPj.Size = new System.Drawing.Size(205, 20);
            this.tb_precoPj.TabIndex = 7;
            // 
            // tb_tamanho
            // 
            this.tb_tamanho.Location = new System.Drawing.Point(95, 113);
            this.tb_tamanho.Name = "tb_tamanho";
            this.tb_tamanho.Size = new System.Drawing.Size(205, 20);
            this.tb_tamanho.TabIndex = 8;
            // 
            // tb_material
            // 
            this.tb_material.Location = new System.Drawing.Point(95, 146);
            this.tb_material.Name = "tb_material";
            this.tb_material.Size = new System.Drawing.Size(205, 20);
            this.tb_material.TabIndex = 9;
            // 
            // tb_estoq
            // 
            this.tb_estoq.Location = new System.Drawing.Point(95, 182);
            this.tb_estoq.Name = "tb_estoq";
            this.tb_estoq.Size = new System.Drawing.Size(205, 20);
            this.tb_estoq.TabIndex = 10;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.Location = new System.Drawing.Point(95, 227);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_cadastrar.TabIndex = 11;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // bt_clearPj
            // 
            this.bt_clearPj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clearPj.Location = new System.Drawing.Point(209, 227);
            this.bt_clearPj.Name = "bt_clearPj";
            this.bt_clearPj.Size = new System.Drawing.Size(75, 23);
            this.bt_clearPj.TabIndex = 12;
            this.bt_clearPj.Text = "Limpar";
            this.bt_clearPj.UseVisualStyleBackColor = true;
            // 
            // FormPijama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(372, 313);
            this.Controls.Add(this.bt_clearPj);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.tb_estoq);
            this.Controls.Add(this.tb_material);
            this.Controls.Add(this.tb_tamanho);
            this.Controls.Add(this.tb_precoPj);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPijama";
            this.Text = "Cadastro dos pijamas";
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
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.TextBox tb_precoPj;
        private System.Windows.Forms.TextBox tb_tamanho;
        private System.Windows.Forms.TextBox tb_material;
        private System.Windows.Forms.TextBox tb_estoq;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_clearPj;
    }
}