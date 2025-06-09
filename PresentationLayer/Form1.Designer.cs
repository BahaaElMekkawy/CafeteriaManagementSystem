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
            PriceTxtBox = new Label();
            itemTxtBoxLabel = new Label();
            txtBoxItemPrice = new TextBox();
            txtBoxItemName = new TextBox();
            AddBtn = new Button();
            panel3 = new Panel();
            label2 = new Label();
            txtBoxTotalPrice = new TextBox();
            btnCheckout = new Button();
            orderGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderGridView).BeginInit();
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
            panel2.Controls.Add(PriceTxtBox);
            panel2.Controls.Add(itemTxtBoxLabel);
            panel2.Controls.Add(txtBoxItemPrice);
            panel2.Controls.Add(txtBoxItemName);
            panel2.Controls.Add(AddBtn);
            panel2.Location = new Point(91, 477);
            panel2.Name = "panel2";
            panel2.Size = new Size(1229, 398);
            panel2.TabIndex = 1;
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.AutoSize = true;
            PriceTxtBox.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceTxtBox.Location = new Point(711, 113);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.Size = new Size(64, 31);
            PriceTxtBox.TabIndex = 5;
            PriceTxtBox.Text = "Price";
            PriceTxtBox.Click += PriceTxtBox_Click;
            // 
            // itemTxtBoxLabel
            // 
            itemTxtBoxLabel.AutoSize = true;
            itemTxtBoxLabel.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemTxtBoxLabel.Location = new Point(161, 119);
            itemTxtBoxLabel.Name = "itemTxtBoxLabel";
            itemTxtBoxLabel.Size = new Size(60, 31);
            itemTxtBoxLabel.TabIndex = 4;
            itemTxtBoxLabel.Text = "Item";
            // 
            // txtBoxItemPrice
            // 
            txtBoxItemPrice.Location = new Point(781, 119);
            txtBoxItemPrice.Name = "txtBoxItemPrice";
            txtBoxItemPrice.Size = new Size(156, 27);
            txtBoxItemPrice.TabIndex = 3;
            // 
            // txtBoxItemName
            // 
            txtBoxItemName.Location = new Point(254, 119);
            txtBoxItemName.Margin = new Padding(3, 5, 3, 5);
            txtBoxItemName.Name = "txtBoxItemName";
            txtBoxItemName.Size = new Size(152, 27);
            txtBoxItemName.TabIndex = 2;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.Highlight;
            AddBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = SystemColors.HighlightText;
            AddBtn.Location = new Point(507, 278);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(162, 57);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
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
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderGridView).EndInit();
            ResumeLayout(false);
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
    }
}
