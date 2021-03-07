
namespace Cliente
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
            this.btnHora = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(282, 29);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(90, 37);
            this.btnHora.TabIndex = 0;
            this.btnHora.Text = "HORA";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(30, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 210);
            this.textBox1.TabIndex = 1;
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(282, 88);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(90, 37);
            this.btnFecha.TabIndex = 2;
            this.btnFecha.Text = "FECHA";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(282, 146);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(90, 37);
            this.btnTodo.TabIndex = 3;
            this.btnTodo.Text = "TODO";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(282, 202);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 37);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(30, 255);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(342, 36);
            this.btnConfigurar.TabIndex = 5;
            this.btnConfigurar.Text = "Configurar conexión";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 371);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnHora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnConfigurar;
    }
}

