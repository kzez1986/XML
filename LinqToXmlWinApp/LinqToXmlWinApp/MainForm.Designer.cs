namespace LinqToXmlWinApp
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInventor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMakeToLookUp = new System.Windows.Forms.TextBox();
            this.btnLookUpColors = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInventor
            // 
            this.txtInventor.Location = new System.Drawing.Point(12, 53);
            this.txtInventor.Multiline = true;
            this.txtInventor.Name = "txtInventor";
            this.txtInventor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInventor.Size = new System.Drawing.Size(515, 281);
            this.txtInventor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Inventory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewItem);
            this.groupBox1.Controls.Add(this.txtPetName);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(612, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Inventory Item";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLookUpColors);
            this.groupBox2.Controls.Add(this.txtMakeToLookUp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(614, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 246);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Look up Colors for Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pet Name";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(87, 20);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(431, 20);
            this.txtMake.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(87, 61);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(431, 20);
            this.txtColor.TabIndex = 4;
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(87, 101);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(431, 20);
            this.txtPetName.TabIndex = 5;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(443, 161);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewItem.TabIndex = 6;
            this.btnAddNewItem.Text = "Add";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Make to Look Up";
            // 
            // txtMakeToLookUp
            // 
            this.txtMakeToLookUp.Location = new System.Drawing.Point(131, 91);
            this.txtMakeToLookUp.Name = "txtMakeToLookUp";
            this.txtMakeToLookUp.Size = new System.Drawing.Size(385, 20);
            this.txtMakeToLookUp.TabIndex = 1;
            // 
            // btnLookUpColors
            // 
            this.btnLookUpColors.Location = new System.Drawing.Point(366, 138);
            this.btnLookUpColors.Name = "btnLookUpColors";
            this.btnLookUpColors.Size = new System.Drawing.Size(150, 23);
            this.btnLookUpColors.TabIndex = 2;
            this.btnLookUpColors.Text = "Look Up Colors";
            this.btnLookUpColors.UseVisualStyleBackColor = true;
            this.btnLookUpColors.Click += new System.EventHandler(this.btnLookUpColors_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInventor);
            this.Name = "MainForm";
            this.Text = "Fun with LINQ to XML";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInventor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnLookUpColors;
        private System.Windows.Forms.TextBox txtMakeToLookUp;
        private System.Windows.Forms.Label label5;
    }
}

