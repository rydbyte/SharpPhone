namespace SharpPhone
{
    partial class AddPhonePage
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
            btnCancel = new Button();
            btnOk = new Button();
            label1 = new Label();
            txtbrand = new TextBox();
            txtModel = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSize = new TextBox();
            txtPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtStock = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(434, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(279, 409);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Brand:";
            // 
            // txtbrand
            // 
            txtbrand.Location = new Point(357, 32);
            txtbrand.Name = "txtbrand";
            txtbrand.Size = new Size(125, 27);
            txtbrand.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(357, 85);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 88);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 5;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 136);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Size:";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(357, 133);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(125, 27);
            txtSize.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(357, 183);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 186);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 9;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 233);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 10;
            label5.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(357, 230);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 11;
            // 
            // AddPhonePage
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
            Name = "AddPhonePage";
            Text = "formAddPhone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private Label label1;
        private TextBox txtbrand;
        private TextBox txtModel;
        private Label label2;
        private Label label3;
        private TextBox txtSize;
        private TextBox txtPrice;
        private Label label4;
        private Label label5;
        private TextBox txtStock;
    }
}