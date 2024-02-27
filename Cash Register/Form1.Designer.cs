namespace Cash_Register
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelReceiptOutput = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelBurgers = new System.Windows.Forms.Label();
            this.labelDrinks = new System.Windows.Forms.Label();
            this.labelFries = new System.Windows.Forms.Label();
            this.textBoxBurgersInput = new System.Windows.Forms.TextBox();
            this.textBoxDrinksInput = new System.Windows.Forms.TextBox();
            this.textBoxFriesInput = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTendered = new System.Windows.Forms.Label();
            this.labelDividingLine1 = new System.Windows.Forms.Label();
            this.labelSubtotalOutput = new System.Windows.Forms.Label();
            this.labelTotalOutput = new System.Windows.Forms.Label();
            this.labelTaxOutput = new System.Windows.Forms.Label();
            this.textBoxTenderedInput = new System.Windows.Forms.TextBox();
            this.buttonCalculateChange = new System.Windows.Forms.Button();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelChangeOutput = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Navy;
            this.labelTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(-2, -1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(710, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Big Boy Burgers";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelReceiptOutput
            // 
            this.labelReceiptOutput.BackColor = System.Drawing.Color.White;
            this.labelReceiptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiptOutput.Location = new System.Drawing.Point(307, 73);
            this.labelReceiptOutput.Name = "labelReceiptOutput";
            this.labelReceiptOutput.Size = new System.Drawing.Size(252, 333);
            this.labelReceiptOutput.TabIndex = 1;
            this.labelReceiptOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.ForeColor = System.Drawing.Color.White;
            this.labelSubtotal.Location = new System.Drawing.Point(12, 207);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(67, 16);
            this.labelSubtotal.TabIndex = 2;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // labelBurgers
            // 
            this.labelBurgers.AutoSize = true;
            this.labelBurgers.BackColor = System.Drawing.Color.Black;
            this.labelBurgers.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBurgers.ForeColor = System.Drawing.Color.White;
            this.labelBurgers.Location = new System.Drawing.Point(12, 58);
            this.labelBurgers.Name = "labelBurgers";
            this.labelBurgers.Size = new System.Drawing.Size(152, 18);
            this.labelBurgers.TabIndex = 3;
            this.labelBurgers.Text = "Number Of Burgers";
            // 
            // labelDrinks
            // 
            this.labelDrinks.AutoSize = true;
            this.labelDrinks.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrinks.ForeColor = System.Drawing.Color.White;
            this.labelDrinks.Location = new System.Drawing.Point(12, 130);
            this.labelDrinks.Name = "labelDrinks";
            this.labelDrinks.Size = new System.Drawing.Size(147, 18);
            this.labelDrinks.TabIndex = 4;
            this.labelDrinks.Text = "Number Of Drinks";
            // 
            // labelFries
            // 
            this.labelFries.AutoSize = true;
            this.labelFries.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFries.ForeColor = System.Drawing.Color.White;
            this.labelFries.Location = new System.Drawing.Point(12, 92);
            this.labelFries.Name = "labelFries";
            this.labelFries.Size = new System.Drawing.Size(133, 18);
            this.labelFries.TabIndex = 5;
            this.labelFries.Text = "Number Of Fries";
            // 
            // textBoxBurgersInput
            // 
            this.textBoxBurgersInput.Location = new System.Drawing.Point(165, 59);
            this.textBoxBurgersInput.Name = "textBoxBurgersInput";
            this.textBoxBurgersInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxBurgersInput.TabIndex = 6;
            // 
            // textBoxDrinksInput
            // 
            this.textBoxDrinksInput.Location = new System.Drawing.Point(165, 93);
            this.textBoxDrinksInput.Name = "textBoxDrinksInput";
            this.textBoxDrinksInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrinksInput.TabIndex = 7;
            // 
            // textBoxFriesInput
            // 
            this.textBoxFriesInput.Location = new System.Drawing.Point(165, 128);
            this.textBoxFriesInput.Name = "textBoxFriesInput";
            this.textBoxFriesInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxFriesInput.TabIndex = 8;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(15, 164);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(250, 26);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate Totals";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(12, 265);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(45, 16);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "Total";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.ForeColor = System.Drawing.Color.White;
            this.labelTax.Location = new System.Drawing.Point(12, 236);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(35, 16);
            this.labelTax.TabIndex = 11;
            this.labelTax.Text = "Tax";
            // 
            // labelTendered
            // 
            this.labelTendered.AutoSize = true;
            this.labelTendered.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTendered.ForeColor = System.Drawing.Color.White;
            this.labelTendered.Location = new System.Drawing.Point(12, 316);
            this.labelTendered.Name = "labelTendered";
            this.labelTendered.Size = new System.Drawing.Size(75, 16);
            this.labelTendered.TabIndex = 12;
            this.labelTendered.Text = "Tendered";
            // 
            // labelDividingLine1
            // 
            this.labelDividingLine1.BackColor = System.Drawing.Color.Black;
            this.labelDividingLine1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDividingLine1.Location = new System.Drawing.Point(12, 293);
            this.labelDividingLine1.Name = "labelDividingLine1";
            this.labelDividingLine1.Size = new System.Drawing.Size(253, 10);
            this.labelDividingLine1.TabIndex = 13;
            // 
            // labelSubtotalOutput
            // 
            this.labelSubtotalOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotalOutput.ForeColor = System.Drawing.Color.White;
            this.labelSubtotalOutput.Location = new System.Drawing.Point(100, 207);
            this.labelSubtotalOutput.Name = "labelSubtotalOutput";
            this.labelSubtotalOutput.Size = new System.Drawing.Size(103, 16);
            this.labelSubtotalOutput.TabIndex = 14;
            // 
            // labelTotalOutput
            // 
            this.labelTotalOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalOutput.ForeColor = System.Drawing.Color.White;
            this.labelTotalOutput.Location = new System.Drawing.Point(100, 265);
            this.labelTotalOutput.Name = "labelTotalOutput";
            this.labelTotalOutput.Size = new System.Drawing.Size(103, 16);
            this.labelTotalOutput.TabIndex = 15;
            // 
            // labelTaxOutput
            // 
            this.labelTaxOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxOutput.ForeColor = System.Drawing.Color.White;
            this.labelTaxOutput.Location = new System.Drawing.Point(100, 236);
            this.labelTaxOutput.Name = "labelTaxOutput";
            this.labelTaxOutput.Size = new System.Drawing.Size(103, 16);
            this.labelTaxOutput.TabIndex = 16;
            // 
            // textBoxTenderedInput
            // 
            this.textBoxTenderedInput.Location = new System.Drawing.Point(103, 315);
            this.textBoxTenderedInput.Name = "textBoxTenderedInput";
            this.textBoxTenderedInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxTenderedInput.TabIndex = 17;
            // 
            // buttonCalculateChange
            // 
            this.buttonCalculateChange.BackColor = System.Drawing.Color.White;
            this.buttonCalculateChange.Enabled = false;
            this.buttonCalculateChange.Location = new System.Drawing.Point(15, 341);
            this.buttonCalculateChange.Name = "buttonCalculateChange";
            this.buttonCalculateChange.Size = new System.Drawing.Size(250, 26);
            this.buttonCalculateChange.TabIndex = 18;
            this.buttonCalculateChange.Text = "Calculate Change";
            this.buttonCalculateChange.UseVisualStyleBackColor = false;
            this.buttonCalculateChange.Click += new System.EventHandler(this.buttonCalculateChange_Click);
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.ForeColor = System.Drawing.Color.White;
            this.labelChange.Location = new System.Drawing.Point(12, 379);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(62, 16);
            this.labelChange.TabIndex = 19;
            this.labelChange.Text = "Change";
            // 
            // labelChangeOutput
            // 
            this.labelChangeOutput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeOutput.ForeColor = System.Drawing.Color.White;
            this.labelChangeOutput.Location = new System.Drawing.Point(103, 379);
            this.labelChangeOutput.Name = "labelChangeOutput";
            this.labelChangeOutput.Size = new System.Drawing.Size(198, 16);
            this.labelChangeOutput.TabIndex = 20;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.White;
            this.buttonPrint.Enabled = false;
            this.buttonPrint.Location = new System.Drawing.Point(15, 412);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(250, 26);
            this.buttonPrint.TabIndex = 21;
            this.buttonPrint.Text = "Print Receipt";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.BackColor = System.Drawing.Color.White;
            this.buttonNewOrder.Location = new System.Drawing.Point(586, 73);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(107, 333);
            this.buttonNewOrder.TabIndex = 22;
            this.buttonNewOrder.Text = "New Order";
            this.buttonNewOrder.UseVisualStyleBackColor = false;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(705, 454);
            this.Controls.Add(this.buttonNewOrder);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelChangeOutput);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.buttonCalculateChange);
            this.Controls.Add(this.textBoxTenderedInput);
            this.Controls.Add(this.labelTaxOutput);
            this.Controls.Add(this.labelTotalOutput);
            this.Controls.Add(this.labelSubtotalOutput);
            this.Controls.Add(this.labelDividingLine1);
            this.Controls.Add(this.labelTendered);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxFriesInput);
            this.Controls.Add(this.textBoxDrinksInput);
            this.Controls.Add(this.textBoxBurgersInput);
            this.Controls.Add(this.labelFries);
            this.Controls.Add(this.labelDrinks);
            this.Controls.Add(this.labelBurgers);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.labelReceiptOutput);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelReceiptOutput;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelBurgers;
        private System.Windows.Forms.Label labelDrinks;
        private System.Windows.Forms.Label labelFries;
        private System.Windows.Forms.TextBox textBoxBurgersInput;
        private System.Windows.Forms.TextBox textBoxDrinksInput;
        private System.Windows.Forms.TextBox textBoxFriesInput;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTendered;
        private System.Windows.Forms.Label labelDividingLine1;
        private System.Windows.Forms.Label labelSubtotalOutput;
        private System.Windows.Forms.Label labelTotalOutput;
        private System.Windows.Forms.Label labelTaxOutput;
        private System.Windows.Forms.TextBox textBoxTenderedInput;
        private System.Windows.Forms.Button buttonCalculateChange;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label labelChangeOutput;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonNewOrder;
    }
}

