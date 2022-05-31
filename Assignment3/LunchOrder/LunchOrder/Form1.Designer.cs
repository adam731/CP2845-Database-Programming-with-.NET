namespace LunchOrder
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
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.radioSalad = new System.Windows.Forms.RadioButton();
            this.radioPizza = new System.Windows.Forms.RadioButton();
            this.radioHamburger = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxAddons = new System.Windows.Forms.GroupBox();
            this.checkFrench = new System.Windows.Forms.CheckBox();
            this.checkSauces = new System.Windows.Forms.CheckBox();
            this.checkIncredidents = new System.Windows.Forms.CheckBox();
            this.gbxMainCourse.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxAddons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.radioSalad);
            this.gbxMainCourse.Controls.Add(this.radioPizza);
            this.gbxMainCourse.Controls.Add(this.radioHamburger);
            this.gbxMainCourse.Location = new System.Drawing.Point(34, 17);
            this.gbxMainCourse.Margin = new System.Windows.Forms.Padding(2);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Padding = new System.Windows.Forms.Padding(2);
            this.gbxMainCourse.Size = new System.Drawing.Size(159, 98);
            this.gbxMainCourse.TabIndex = 0;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main Course";
            // 
            // radioSalad
            // 
            this.radioSalad.AutoSize = true;
            this.radioSalad.Location = new System.Drawing.Point(19, 71);
            this.radioSalad.Name = "radioSalad";
            this.radioSalad.Size = new System.Drawing.Size(91, 19);
            this.radioSalad.TabIndex = 2;
            this.radioSalad.Text = "Salad - $4.95";
            this.radioSalad.UseVisualStyleBackColor = true;
            this.radioSalad.CheckedChanged += new System.EventHandler(this.radioSalad_CheckedChanged);
            // 
            // radioPizza
            // 
            this.radioPizza.AutoSize = true;
            this.radioPizza.Location = new System.Drawing.Point(19, 46);
            this.radioPizza.Name = "radioPizza";
            this.radioPizza.Size = new System.Drawing.Size(89, 19);
            this.radioPizza.TabIndex = 1;
            this.radioPizza.Text = "Pizza - $5.95";
            this.radioPizza.UseVisualStyleBackColor = true;
            this.radioPizza.CheckedChanged += new System.EventHandler(this.radioPizza_CheckedChanged);
            // 
            // radioHamburger
            // 
            this.radioHamburger.AutoSize = true;
            this.radioHamburger.Checked = true;
            this.radioHamburger.Location = new System.Drawing.Point(19, 21);
            this.radioHamburger.Name = "radioHamburger";
            this.radioHamburger.Size = new System.Drawing.Size(124, 19);
            this.radioHamburger.TabIndex = 0;
            this.radioHamburger.TabStop = true;
            this.radioHamburger.Text = "Hamburger - $6.95";
            this.radioHamburger.UseVisualStyleBackColor = true;
            this.radioHamburger.CheckedChanged += new System.EventHandler(this.radioHamburger_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrderTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSalesTax);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(34, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(260, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(112, 76);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(106, 23);
            this.txtOrderTotal.TabIndex = 5;
            this.txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(112, 50);
            this.txtSalesTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(106, 23);
            this.txtSalesTax.TabIndex = 3;
            this.txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(112, 23);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(106, 23);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(320, 143);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(78, 25);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(320, 222);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxAddons
            // 
            this.gbxAddons.Controls.Add(this.checkFrench);
            this.gbxAddons.Controls.Add(this.checkSauces);
            this.gbxAddons.Controls.Add(this.checkIncredidents);
            this.gbxAddons.Location = new System.Drawing.Point(213, 18);
            this.gbxAddons.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAddons.Name = "gbxAddons";
            this.gbxAddons.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAddons.Size = new System.Drawing.Size(209, 97);
            this.gbxAddons.TabIndex = 4;
            this.gbxAddons.TabStop = false;
            this.gbxAddons.Text = "Add-on items ($.75/each)";
            // 
            // checkFrench
            // 
            this.checkFrench.AutoSize = true;
            this.checkFrench.Location = new System.Drawing.Point(14, 73);
            this.checkFrench.Name = "checkFrench";
            this.checkFrench.Size = new System.Drawing.Size(87, 19);
            this.checkFrench.TabIndex = 2;
            this.checkFrench.Text = "French fries";
            this.checkFrench.UseVisualStyleBackColor = true;
            // 
            // checkSauces
            // 
            this.checkSauces.AutoSize = true;
            this.checkSauces.Location = new System.Drawing.Point(14, 47);
            this.checkSauces.Name = "checkSauces";
            this.checkSauces.Size = new System.Drawing.Size(179, 19);
            this.checkSauces.TabIndex = 1;
            this.checkSauces.Text = "Ketchup, mustard, and mayo";
            this.checkSauces.UseVisualStyleBackColor = true;
            // 
            // checkIncredidents
            // 
            this.checkIncredidents.AutoSize = true;
            this.checkIncredidents.Location = new System.Drawing.Point(14, 22);
            this.checkIncredidents.Name = "checkIncredidents";
            this.checkIncredidents.Size = new System.Drawing.Size(179, 19);
            this.checkIncredidents.TabIndex = 0;
            this.checkIncredidents.Text = "Lettuce, tomator, and onions";
            this.checkIncredidents.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(433, 274);
            this.Controls.Add(this.gbxAddons);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxMainCourse);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxAddons.ResumeLayout(false);
            this.gbxAddons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioSalad;
        private System.Windows.Forms.RadioButton radioPizza;
        private System.Windows.Forms.RadioButton radioHamburger;
        private System.Windows.Forms.GroupBox gbxAddons;
        private System.Windows.Forms.CheckBox checkFrench;
        private System.Windows.Forms.CheckBox checkSauces;
        private System.Windows.Forms.CheckBox checkIncredidents;
    }
}

