namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCateto1 = new TextBox();
            txtCateto2 = new TextBox();
            btnCalcular = new Button();
            lblCateto1 = new Label();
            lblCateto2 = new Label();
            SuspendLayout();
            // 
            // txtCateto1
            // 
            txtCateto1.Location = new Point(160, 68);
            txtCateto1.Name = "txtCateto1";
            txtCateto1.Size = new Size(75, 23);
            txtCateto1.TabIndex = 0;
            // 
            // txtCateto2
            // 
            txtCateto2.Location = new Point(160, 126);
            txtCateto2.Name = "txtCateto2";
            txtCateto2.Size = new Size(75, 23);
            txtCateto2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(90, 195);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCateto1
            // 
            lblCateto1.AutoSize = true;
            lblCateto1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCateto1.Location = new Point(16, 67);
            lblCateto1.Name = "lblCateto1";
            lblCateto1.Size = new Size(130, 40);
            lblCateto1.TabIndex = 3;
            lblCateto1.Text = "Digite la longitud \r\ndel Cateto 1:";
            // 
            // lblCateto2
            // 
            lblCateto2.AutoSize = true;
            lblCateto2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCateto2.Location = new Point(16, 125);
            lblCateto2.Name = "lblCateto2";
            lblCateto2.Size = new Size(130, 40);
            lblCateto2.TabIndex = 4;
            lblCateto2.Text = "Digite la longitud \r\ndel  csteto 2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 247);
            Controls.Add(lblCateto2);
            Controls.Add(lblCateto1);
            Controls.Add(btnCalcular);
            Controls.Add(txtCateto2);
            Controls.Add(txtCateto1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCateto1;
        private TextBox txtCateto2;
        private Button btnCalcular;
        private Label lblCateto1;
        private Label lblCateto2;
    }
}