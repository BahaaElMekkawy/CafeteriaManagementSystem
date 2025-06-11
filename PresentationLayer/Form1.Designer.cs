
namespace PresentationLayer
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
            panel1 = new Panel();
            label1 = new Label();
            MenuGridView = new DataGridView();
            panel2 = new Panel();
            panel4 = new Panel();
            btnDel = new Button();
            txtBoxItemName = new TextBox();
            txtBoxItemPrice = new TextBox();
            itemTxtBoxLabel = new Label();
            PriceTxtBox = new Label();
            AddBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            NumAddStock = new NumericUpDown();
            numAddPrice = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            txtAddName = new TextBox();
            txtAddDesc = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            txtBoxTotalPrice = new TextBox();
            btnCheckout = new Button();
            orderGridView = new DataGridView();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuGridView).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumAddStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAddPrice).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderGridView).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuGridView);
            panel1.Location = new Point(91, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1229, 395);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // MenuGridView
            // 
            MenuGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MenuGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MenuGridView.Location = new Point(16, 62);
            MenuGridView.MaximumSize = new Size(1196, 321);
            MenuGridView.MinimumSize = new Size(1196, 321);
            MenuGridView.Name = "MenuGridView";
            MenuGridView.RowHeadersWidth = 51;
            MenuGridView.Size = new Size(1196, 321);
            MenuGridView.TabIndex = 2;
            MenuGridView.CellClick += MenuGridView_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(91, 477);
            panel2.Name = "panel2";
            panel2.Size = new Size(1229, 398);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(btnDel);
            panel4.Controls.Add(txtBoxItemName);
            panel4.Controls.Add(txtBoxItemPrice);
            panel4.Controls.Add(itemTxtBoxLabel);
            panel4.Controls.Add(PriceTxtBox);
            panel4.Controls.Add(AddBtn);
            panel4.Location = new Point(856, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(335, 312);
            panel4.TabIndex = 15;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.IndianRed;
            btnDel.Font = new Font("Segoe UI", 14F);
            btnDel.ForeColor = SystemColors.HighlightText;
            btnDel.Location = new Point(54, 222);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(222, 57);
            btnDel.TabIndex = 6;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // txtBoxItemName
            // 
            txtBoxItemName.Location = new Point(82, 86);
            txtBoxItemName.Margin = new Padding(3, 5, 3, 5);
            txtBoxItemName.Name = "txtBoxItemName";
            txtBoxItemName.Size = new Size(204, 27);
            txtBoxItemName.TabIndex = 2;
            // 
            // txtBoxItemPrice
            // 
            txtBoxItemPrice.Location = new Point(82, 25);
            txtBoxItemPrice.Name = "txtBoxItemPrice";
            txtBoxItemPrice.Size = new Size(204, 27);
            txtBoxItemPrice.TabIndex = 3;
            // 
            // itemTxtBoxLabel
            // 
            itemTxtBoxLabel.AutoSize = true;
            itemTxtBoxLabel.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemTxtBoxLabel.Location = new Point(16, 82);
            itemTxtBoxLabel.Name = "itemTxtBoxLabel";
            itemTxtBoxLabel.Size = new Size(60, 31);
            itemTxtBoxLabel.TabIndex = 4;
            itemTxtBoxLabel.Text = "Item";
            itemTxtBoxLabel.Click += itemTxtBoxLabel_Click;
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.AutoSize = true;
            PriceTxtBox.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceTxtBox.Location = new Point(8, 25);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.Size = new Size(64, 31);
            PriceTxtBox.TabIndex = 5;
            PriceTxtBox.Text = "Price";
            PriceTxtBox.Click += PriceTxtBox_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.Highlight;
            AddBtn.Font = new Font("Segoe UI", 14F);
            AddBtn.ForeColor = SystemColors.HighlightText;
            AddBtn.Location = new Point(54, 148);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(222, 57);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Order";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(405, 65);
            label5.Name = "label5";
            label5.Size = new Size(64, 31);
            label5.TabIndex = 14;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(409, 126);
            label6.Name = "label6";
            label6.Size = new Size(69, 31);
            label6.TabIndex = 13;
            label6.Text = "Stock";
            // 
            // NumAddStock
            // 
            NumAddStock.Location = new Point(505, 127);
            NumAddStock.Name = "NumAddStock";
            NumAddStock.Size = new Size(150, 27);
            NumAddStock.TabIndex = 12;
            // 
            // numAddPrice
            // 
            numAddPrice.Location = new Point(505, 66);
            numAddPrice.Name = "numAddPrice";
            numAddPrice.Size = new Size(150, 27);
            numAddPrice.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 65);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 117);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(181, 65);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(156, 27);
            txtAddName.TabIndex = 8;
            // 
            // txtAddDesc
            // 
            txtAddDesc.Location = new Point(181, 126);
            txtAddDesc.Margin = new Padding(3, 5, 3, 5);
            txtAddDesc.Name = "txtAddDesc";
            txtAddDesc.Size = new Size(152, 27);
            txtAddDesc.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(256, 207);
            button1.Name = "button1";
            button1.Size = new Size(222, 57);
            button1.TabIndex = 6;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtBoxTotalPrice);
            panel3.Controls.Add(btnCheckout);
            panel3.Controls.Add(orderGridView);
            panel3.Location = new Point(1400, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(392, 836);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 635);
            label2.Name = "label2";
            label2.Size = new Size(119, 31);
            label2.TabIndex = 6;
            label2.Text = "Total Price";
            // 
            // txtBoxTotalPrice
            // 
            txtBoxTotalPrice.Location = new Point(141, 641);
            txtBoxTotalPrice.Name = "txtBoxTotalPrice";
            txtBoxTotalPrice.Size = new Size(123, 27);
            txtBoxTotalPrice.TabIndex = 5;
            txtBoxTotalPrice.TextChanged += txtBoxTotalPrice_TextChanged;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = SystemColors.Highlight;
            btnCheckout.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = SystemColors.HighlightText;
            btnCheckout.Location = new Point(104, 716);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(204, 57);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // orderGridView
            // 
            orderGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGridView.Location = new Point(16, 62);
            orderGridView.Name = "orderGridView";
            orderGridView.RowHeadersWidth = 51;
            orderGridView.Size = new Size(360, 491);
            orderGridView.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(txtAddName);
            panel5.Controls.Add(txtAddDesc);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(NumAddStock);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(numAddPrice);
            panel5.Location = new Point(60, 23);
            panel5.Name = "panel5";
            panel5.Size = new Size(698, 312);
            panel5.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1924, 908);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuGridView).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumAddStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAddPrice).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderGridView).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView MenuGridView;
        private Panel panel3;
        private DataGridView orderGridView;
        private Label label1;
        private Label itemTxtBoxLabel;
        private TextBox txtBoxItemPrice;
        private TextBox txtBoxItemName;
        private Button AddBtn;
        private Label PriceTxtBox;
        private Button btnCheckout;
        private TextBox txtBoxTotalPrice;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private NumericUpDown NumAddStock;
        private NumericUpDown numAddPrice;
        private Label label3;
        private Label label4;
        private TextBox txtAddName;
        private TextBox txtAddDesc;
        private Button button1;
        private Panel panel4;
        private Button btnDel;
        private Panel panel5;
    }
}
