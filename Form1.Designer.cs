
namespace teamProject1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMargherita = new System.Windows.Forms.RadioButton();
            this.rbMeetlover = new System.Windows.Forms.RadioButton();
            this.rbCheese = new System.Windows.Forms.RadioButton();
            this.rbVeggie = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cheeseBox = new System.Windows.Forms.CheckBox();
            this.veggieBox = new System.Windows.Forms.CheckBox();
            this.pineappleBox = new System.Windows.Forms.CheckBox();
            this.pepperBox = new System.Windows.Forms.CheckBox();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adding Topings";
            // 
            // rbMargherita
            // 
            this.rbMargherita.AutoSize = true;
            this.rbMargherita.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMargherita.Location = new System.Drawing.Point(35, 89);
            this.rbMargherita.Name = "rbMargherita";
            this.rbMargherita.Size = new System.Drawing.Size(158, 28);
            this.rbMargherita.TabIndex = 2;
            this.rbMargherita.TabStop = true;
            this.rbMargherita.Text = "Margherita";
            this.rbMargherita.UseVisualStyleBackColor = true;
            // 
            // rbMeetlover
            // 
            this.rbMeetlover.AutoSize = true;
            this.rbMeetlover.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeetlover.Location = new System.Drawing.Point(35, 118);
            this.rbMeetlover.Name = "rbMeetlover";
            this.rbMeetlover.Size = new System.Drawing.Size(154, 28);
            this.rbMeetlover.TabIndex = 3;
            this.rbMeetlover.TabStop = true;
            this.rbMeetlover.Text = "Meat Lover";
            this.rbMeetlover.UseVisualStyleBackColor = true;
            this.rbMeetlover.CheckedChanged += new System.EventHandler(this.rbMeetlover_CheckedChanged);
            // 
            // rbCheese
            // 
            this.rbCheese.AutoSize = true;
            this.rbCheese.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCheese.Location = new System.Drawing.Point(36, 152);
            this.rbCheese.Name = "rbCheese";
            this.rbCheese.Size = new System.Drawing.Size(108, 28);
            this.rbCheese.TabIndex = 4;
            this.rbCheese.TabStop = true;
            this.rbCheese.Text = "Cheese";
            this.rbCheese.UseVisualStyleBackColor = true;
            this.rbCheese.CheckedChanged += new System.EventHandler(this.rbCheese_CheckedChanged);
            // 
            // rbVeggie
            // 
            this.rbVeggie.AutoSize = true;
            this.rbVeggie.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVeggie.Location = new System.Drawing.Point(35, 186);
            this.rbVeggie.Name = "rbVeggie";
            this.rbVeggie.Size = new System.Drawing.Size(102, 28);
            this.rbVeggie.TabIndex = 5;
            this.rbVeggie.TabStop = true;
            this.rbVeggie.Text = "Veggie";
            this.rbVeggie.UseVisualStyleBackColor = true;
            this.rbVeggie.CheckedChanged += new System.EventHandler(this.rbVeggie_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Calories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price";
            // 
            // cheeseBox
            // 
            this.cheeseBox.AutoSize = true;
            this.cheeseBox.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheeseBox.Location = new System.Drawing.Point(35, 264);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.Size = new System.Drawing.Size(178, 28);
            this.cheeseBox.TabIndex = 13;
            this.cheeseBox.Text = "Extra Cheese";
            this.cheeseBox.UseVisualStyleBackColor = true;
            // 
            // veggieBox
            // 
            this.veggieBox.AutoSize = true;
            this.veggieBox.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veggieBox.Location = new System.Drawing.Point(35, 301);
            this.veggieBox.Name = "veggieBox";
            this.veggieBox.Size = new System.Drawing.Size(182, 28);
            this.veggieBox.TabIndex = 14;
            this.veggieBox.Text = "Extra Veggies";
            this.veggieBox.UseVisualStyleBackColor = true;
            // 
            // pineappleBox
            // 
            this.pineappleBox.AutoSize = true;
            this.pineappleBox.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pineappleBox.Location = new System.Drawing.Point(35, 338);
            this.pineappleBox.Name = "pineappleBox";
            this.pineappleBox.Size = new System.Drawing.Size(158, 28);
            this.pineappleBox.TabIndex = 15;
            this.pineappleBox.Text = "Pineapples";
            this.pineappleBox.UseVisualStyleBackColor = true;
            // 
            // pepperBox
            // 
            this.pepperBox.AutoSize = true;
            this.pepperBox.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pepperBox.Location = new System.Drawing.Point(35, 375);
            this.pepperBox.Name = "pepperBox";
            this.pepperBox.Size = new System.Drawing.Size(122, 28);
            this.pepperBox.TabIndex = 16;
            this.pepperBox.Text = "Peppers";
            this.pepperBox.UseVisualStyleBackColor = true;
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesTextBox.Location = new System.Drawing.Point(181, 479);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.ReadOnly = true;
            this.caloriesTextBox.Size = new System.Drawing.Size(100, 38);
            this.caloriesTextBox.TabIndex = 17;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(181, 529);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 38);
            this.priceTextBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 720);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.pepperBox);
            this.Controls.Add(this.pineappleBox);
            this.Controls.Add(this.veggieBox);
            this.Controls.Add(this.cheeseBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbVeggie);
            this.Controls.Add(this.rbCheese);
            this.Controls.Add(this.rbMeetlover);
            this.Controls.Add(this.rbMargherita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PizzaApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMargherita;
        private System.Windows.Forms.RadioButton rbMeetlover;
        private System.Windows.Forms.RadioButton rbCheese;
        private System.Windows.Forms.RadioButton rbVeggie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cheeseBox;
        private System.Windows.Forms.CheckBox veggieBox;
        private System.Windows.Forms.CheckBox pineappleBox;
        private System.Windows.Forms.CheckBox pepperBox;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}

