﻿
namespace Sistema.Visualizar
{
    partial class Tela_Finalizar_Compra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ComboCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 221);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Selecione o cliente";
            this.label2.Visible = false;
            // 
            // ComboCliente
            // 
            this.ComboCliente.FormattingEnabled = true;
            this.ComboCliente.Location = new System.Drawing.Point(149, 188);
            this.ComboCliente.Name = "ComboCliente";
            this.ComboCliente.Size = new System.Drawing.Size(185, 21);
            this.ComboCliente.TabIndex = 29;
            this.ComboCliente.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cliente:";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Não";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Sim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(158, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cliente já cadastrado?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(153, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "FINALIZAR COMPRA";
            // 
            // Tela_Finalizar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 216);
            this.Controls.Add(this.panel1);
            this.Name = "Tela_Finalizar_Compra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tela_Finalizar_Compra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}