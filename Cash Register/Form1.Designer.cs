namespace Cash_Register
{
    partial class cashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashRegister));
            this.titleLabel = new System.Windows.Forms.Label();
            this.receiptOutputLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.burgersLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.burgersInputTextBox = new System.Windows.Forms.TextBox();
            this.drinksInputTextBox = new System.Windows.Forms.TextBox();
            this.friesInputTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.labelDividingLine1 = new System.Windows.Forms.Label();
            this.subtotalOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.textBoxTenderedInput = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutputLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Navy;
            this.titleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-2, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(710, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Big Boy Burgers";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiptOutputLabel
            // 
            this.receiptOutputLabel.BackColor = System.Drawing.Color.White;
            this.receiptOutputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutputLabel.Location = new System.Drawing.Point(307, 73);
            this.receiptOutputLabel.Name = "receiptOutputLabel";
            this.receiptOutputLabel.Size = new System.Drawing.Size(252, 333);
            this.receiptOutputLabel.TabIndex = 1;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.White;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 207);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(67, 16);
            this.subtotalLabel.TabIndex = 2;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // burgersLabel
            // 
            this.burgersLabel.AutoSize = true;
            this.burgersLabel.BackColor = System.Drawing.Color.Black;
            this.burgersLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgersLabel.ForeColor = System.Drawing.Color.White;
            this.burgersLabel.Location = new System.Drawing.Point(12, 58);
            this.burgersLabel.Name = "burgersLabel";
            this.burgersLabel.Size = new System.Drawing.Size(152, 18);
            this.burgersLabel.TabIndex = 3;
            this.burgersLabel.Text = "Number Of Burgers";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.ForeColor = System.Drawing.Color.White;
            this.drinksLabel.Location = new System.Drawing.Point(12, 130);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(147, 18);
            this.drinksLabel.TabIndex = 4;
            this.drinksLabel.Text = "Number Of Drinks";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.ForeColor = System.Drawing.Color.White;
            this.friesLabel.Location = new System.Drawing.Point(12, 92);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(133, 18);
            this.friesLabel.TabIndex = 5;
            this.friesLabel.Text = "Number Of Fries";
            // 
            // burgersInputTextBox
            // 
            this.burgersInputTextBox.Location = new System.Drawing.Point(165, 59);
            this.burgersInputTextBox.Name = "burgersInputTextBox";
            this.burgersInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.burgersInputTextBox.TabIndex = 6;
            // 
            // drinksInputTextBox
            // 
            this.drinksInputTextBox.Location = new System.Drawing.Point(165, 93);
            this.drinksInputTextBox.Name = "drinksInputTextBox";
            this.drinksInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.drinksInputTextBox.TabIndex = 7;
            // 
            // friesInputTextBox
            // 
            this.friesInputTextBox.Location = new System.Drawing.Point(165, 128);
            this.friesInputTextBox.Name = "friesInputTextBox";
            this.friesInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.friesInputTextBox.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(15, 164);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(250, 26);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(12, 265);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(45, 16);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(12, 236);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(35, 16);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "Tax";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.White;
            this.tenderedLabel.Location = new System.Drawing.Point(12, 316);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(75, 16);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered";
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
            // subtotalOutputLabel
            // 
            this.subtotalOutputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutputLabel.ForeColor = System.Drawing.Color.White;
            this.subtotalOutputLabel.Location = new System.Drawing.Point(100, 207);
            this.subtotalOutputLabel.Name = "subtotalOutputLabel";
            this.subtotalOutputLabel.Size = new System.Drawing.Size(103, 16);
            this.subtotalOutputLabel.TabIndex = 14;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutputLabel.ForeColor = System.Drawing.Color.White;
            this.totalOutputLabel.Location = new System.Drawing.Point(100, 265);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(103, 16);
            this.totalOutputLabel.TabIndex = 15;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutputLabel.ForeColor = System.Drawing.Color.White;
            this.taxOutputLabel.Location = new System.Drawing.Point(100, 236);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(103, 16);
            this.taxOutputLabel.TabIndex = 16;
            // 
            // textBoxTenderedInput
            // 
            this.textBoxTenderedInput.Location = new System.Drawing.Point(103, 315);
            this.textBoxTenderedInput.Name = "textBoxTenderedInput";
            this.textBoxTenderedInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxTenderedInput.TabIndex = 17;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.White;
            this.calculateChangeButton.Enabled = false;
            this.calculateChangeButton.Location = new System.Drawing.Point(15, 341);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(250, 26);
            this.calculateChangeButton.TabIndex = 18;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.buttonCalculateChange_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(12, 379);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(62, 16);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change";
            // 
            // changeOutputLabel
            // 
            this.changeOutputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutputLabel.ForeColor = System.Drawing.Color.White;
            this.changeOutputLabel.Location = new System.Drawing.Point(103, 379);
            this.changeOutputLabel.Name = "changeOutputLabel";
            this.changeOutputLabel.Size = new System.Drawing.Size(198, 16);
            this.changeOutputLabel.TabIndex = 20;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.White;
            this.printButton.Enabled = false;
            this.printButton.Location = new System.Drawing.Point(15, 412);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(250, 26);
            this.printButton.TabIndex = 21;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.White;
            this.newOrderButton.Location = new System.Drawing.Point(586, 73);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(107, 333);
            this.newOrderButton.TabIndex = 22;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(705, 454);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutputLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.textBoxTenderedInput);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.subtotalOutputLabel);
            this.Controls.Add(this.labelDividingLine1);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.friesInputTextBox);
            this.Controls.Add(this.drinksInputTextBox);
            this.Controls.Add(this.burgersInputTextBox);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.burgersLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.receiptOutputLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashRegister";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label receiptOutputLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label burgersLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.TextBox burgersInputTextBox;
        private System.Windows.Forms.TextBox drinksInputTextBox;
        private System.Windows.Forms.TextBox friesInputTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label labelDividingLine1;
        private System.Windows.Forms.Label subtotalOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.TextBox textBoxTenderedInput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutputLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button newOrderButton;
    }
}

