namespace WindowsFormsApp2
{
    partial class Divisao
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
            this.bt_caulcular = new System.Windows.Forms.Button();
            this.tx_valor_1 = new System.Windows.Forms.TextBox();
            this.tx_valor_2 = new System.Windows.Forms.TextBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_caulcular
            // 
            this.bt_caulcular.Location = new System.Drawing.Point(76, 144);
            this.bt_caulcular.Name = "bt_caulcular";
            this.bt_caulcular.Size = new System.Drawing.Size(75, 23);
            this.bt_caulcular.TabIndex = 0;
            this.bt_caulcular.Text = "calcular";
            this.bt_caulcular.UseVisualStyleBackColor = true;
            this.bt_caulcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_valor_1
            // 
            this.tx_valor_1.Location = new System.Drawing.Point(41, 33);
            this.tx_valor_1.Name = "tx_valor_1";
            this.tx_valor_1.Size = new System.Drawing.Size(167, 20);
            this.tx_valor_1.TabIndex = 1;
            // 
            // tx_valor_2
            // 
            this.tx_valor_2.Location = new System.Drawing.Point(41, 79);
            this.tx_valor_2.Name = "tx_valor_2";
            this.tx_valor_2.Size = new System.Drawing.Size(167, 20);
            this.tx_valor_2.TabIndex = 2;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(170, 120);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(35, 13);
            this.lb_resultado.TabIndex = 3;
            this.lb_resultado.Text = "label1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(440, 79);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(440, 116);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radio
            // 
            this.radio.Location = new System.Drawing.Point(440, 159);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(75, 23);
            this.radio.TabIndex = 6;
            this.radio.Text = "butao";
            this.radio.UseVisualStyleBackColor = true;
            this.radio.Click += new System.EventHandler(this.radio_Click);
            // 
            // Divisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 399);
            this.Controls.Add(this.radio);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.tx_valor_2);
            this.Controls.Add(this.tx_valor_1);
            this.Controls.Add(this.bt_caulcular);
            this.Name = "Divisao";
            this.Text = "divisao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_caulcular;
        private System.Windows.Forms.TextBox tx_valor_1;
        private System.Windows.Forms.TextBox tx_valor_2;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button radio;
    }
}