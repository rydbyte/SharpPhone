namespace SharpPhone
{
    partial class ModifyPhonePage
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
            txtStock = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtPrice = new TextBox();
            txtSize = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtModel = new TextBox();
            txtbrand = new TextBox();
            label1 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(354, 220);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 223);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 22;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 176);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 21;
            label4.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(354, 173);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 20;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(354, 123);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(125, 27);
            txtSize.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 126);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 18;
            label3.Text = "Size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 78);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 17;
            label2.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(354, 75);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 16;
            // 
            // txtbrand
            // 
            txtbrand.Location = new Point(354, 22);
            txtbrand.Name = "txtbrand";
            txtbrand.Size = new Size(125, 27);
            txtbrand.TabIndex = 15;
            txtbrand.TextChanged += txtbrand_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 14;
            label1.Text = "Brand:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(276, 399);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 13;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(431, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ModifyPhonePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(txtSize);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtModel);
            Controls.Add(txtbrand);
            Controls.Add(label1);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Name = "ModifyPhonePage";
            Text = "modifyPhone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStock;
        private Label label5;
        private Label label4;
        private TextBox txtPrice;
        private TextBox txtSize;
        private Label label3;
        private Label label2;
        private TextBox txtModel;
        private TextBox txtbrand;
        private Label label1;
        private Button btnOk;
        private Button btnCancel;
    }
}