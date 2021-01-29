
namespace RestaurantBillCalculator
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
            this.cmbBeverages = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbAppetizers = new System.Windows.Forms.ComboBox();
            this.cmbMainCourse = new System.Windows.Forms.ComboBox();
            this.cmbDesserts = new System.Windows.Forms.ComboBox();
            this.RestaurantBill = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBeverages
            // 
            this.cmbBeverages.DisplayMember = "name";
            this.cmbBeverages.FormattingEnabled = true;
            this.cmbBeverages.Items.AddRange(new object[] {
            "Soda $ 1.95",
            "Tea $ 1.50",
            "Coffee $ 1.25",
            "Mineral Water $ 2.95",
            "Jucie $ 2.50",
            "Milk $ 1.50"});
            this.cmbBeverages.Location = new System.Drawing.Point(438, 127);
            this.cmbBeverages.Name = "cmbBeverages";
            this.cmbBeverages.Size = new System.Drawing.Size(151, 28);
            this.cmbBeverages.TabIndex = 0;
            this.cmbBeverages.Text = "Beverage";
            this.cmbBeverages.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gabriola", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(182, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 81);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Restaurant Bill Calculator";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbAppetizers
            // 
            this.cmbAppetizers.DisplayMember = "name";
            this.cmbAppetizers.FormattingEnabled = true;
            this.cmbAppetizers.Items.AddRange(new object[] {
            "Buffalo Wings $ 5.95",
            "Bufflao Fingers $ 6.95",
            "Potato Skins $ 8.95",
            "Nachos $ 8.95",
            "Mushroom Caps $ 10.95",
            "Shrimp Cocktail $ 12.95",
            "Chips and Salsa $ 6.95"});
            this.cmbAppetizers.Location = new System.Drawing.Point(3, 127);
            this.cmbAppetizers.Name = "cmbAppetizers";
            this.cmbAppetizers.Size = new System.Drawing.Size(151, 28);
            this.cmbAppetizers.TabIndex = 2;
            this.cmbAppetizers.Text = "Appetizer";
            this.cmbAppetizers.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            this.cmbAppetizers.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbMainCourse
            // 
            this.cmbMainCourse.DisplayMember = "(name)";
            this.cmbMainCourse.FormattingEnabled = true;
            this.cmbMainCourse.Items.AddRange(new object[] {
            "Seafood Alfredo $ 15.95",
            "Chicken Alfredo $ 13.95",
            "Chicken Picatta $ 13.95",
            "Turkey Club $ 11.95",
            "Lobster Pie $ 19.95",
            "Prime Rib $ 20.95",
            "Shrimp Scampi $ 18.95",
            "Turkey Dinner $ 13.95",
            "Stuffed Chicken $ 14.95"});
            this.cmbMainCourse.Location = new System.Drawing.Point(218, 127);
            this.cmbMainCourse.Name = "cmbMainCourse";
            this.cmbMainCourse.Size = new System.Drawing.Size(151, 28);
            this.cmbMainCourse.TabIndex = 3;
            this.cmbMainCourse.Text = "Main Course";
            this.cmbMainCourse.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // cmbDesserts
            // 
            this.cmbDesserts.DisplayMember = "name";
            this.cmbDesserts.FormattingEnabled = true;
            this.cmbDesserts.Items.AddRange(new object[] {
            "Apple Pie $ 5.95",
            "Sundae $ 3.95",
            "Carrot Cake $ 5.95",
            "Mud Pie $ 4.95",
            "Apple Crisp $ 5.95"});
            this.cmbDesserts.Location = new System.Drawing.Point(658, 127);
            this.cmbDesserts.Name = "cmbDesserts";
            this.cmbDesserts.Size = new System.Drawing.Size(121, 28);
            this.cmbDesserts.TabIndex = 5;
            this.cmbDesserts.Text = "Dessert";
            this.cmbDesserts.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            this.cmbDesserts.SelectedValueChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // RestaurantBill
            // 
            this.RestaurantBill.FormattingEnabled = true;
            this.RestaurantBill.ItemHeight = 20;
            this.RestaurantBill.Location = new System.Drawing.Point(12, 174);
            this.RestaurantBill.Name = "RestaurantBill";
            this.RestaurantBill.Size = new System.Drawing.Size(497, 304);
            this.RestaurantBill.TabIndex = 6;
            this.RestaurantBill.SelectedIndexChanged += new System.EventHandler(this.RestaurantBill_SelectedIndexChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(597, 282);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(170, 29);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear Bill";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.RestaurantBill);
            this.Controls.Add(this.cmbDesserts);
            this.Controls.Add(this.cmbMainCourse);
            this.Controls.Add(this.cmbAppetizers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbBeverages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBeverages;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbAppetizers;
        private System.Windows.Forms.ComboBox cmbMainCourse;
        private System.Windows.Forms.ComboBox cmbDesserts;
        private System.Windows.Forms.ListBox RestaurantBill;
        private System.Windows.Forms.Button Clear;
    }
}

