namespace SharpPhone
{
    partial class MainPage
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
            listPhones = new ListBox();
            btnAddphone = new Button();
            btnModify = new Button();
            label2 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listPhones
            // 
            listPhones.FormattingEnabled = true;
            listPhones.Location = new Point(12, 49);
            listPhones.Name = "listPhones";
            listPhones.Size = new Size(236, 484);
            listPhones.TabIndex = 1;
            listPhones.SelectedIndexChanged += listPhones_SelectedIndexChanged;
            // 
            // btnAddphone
            // 
            btnAddphone.Location = new Point(254, 49);
            btnAddphone.Name = "btnAddphone";
            btnAddphone.Size = new Size(94, 29);
            btnAddphone.TabIndex = 2;
            btnAddphone.Text = "+";
            btnAddphone.UseVisualStyleBackColor = true;
            btnAddphone.Click += btnAddphone_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(254, 84);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 3;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 4;
            label2.Text = "Smartphones";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(254, 119);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1062, 673);
            Controls.Add(btnDelete);
            Controls.Add(label2);
            Controls.Add(btnModify);
            Controls.Add(btnAddphone);
            Controls.Add(listPhones);
            Name = "MainPage";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ListBox listPhones;
        private Button btnAddphone;
        private Button btnModify;
        private Label label2;
        private Button btnDelete;
    }
}
