namespace Presentation.User_Role
{
    partial class OrderPanel
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
            OrderDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)OrderDGV).BeginInit();
            SuspendLayout();
            // 
            // OrderDGV
            // 
            OrderDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderDGV.BackgroundColor = Color.Linen;
            OrderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDGV.Location = new Point(30, 73);
            OrderDGV.Margin = new Padding(4);
            OrderDGV.Name = "OrderDGV";
            OrderDGV.RowHeadersWidth = 51;
            OrderDGV.Size = new Size(1409, 600);
            OrderDGV.TabIndex = 2;
            OrderDGV.CellContentClick += OrderDGV_CellContentClick;
            // 
            // OrderPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 920);
            Controls.Add(OrderDGV);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "OrderPanel";
            Text = "OrderPanel";
            ((System.ComponentModel.ISupportInitialize)OrderDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OrderDGV;
    }
}