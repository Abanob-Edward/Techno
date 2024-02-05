namespace Presentation.User_Role
{
    partial class productsInOrder
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
            ProudectInorderDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ProudectInorderDGV).BeginInit();
            SuspendLayout();
            // 
            // ProudectInorderDGV
            // 
            ProudectInorderDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProudectInorderDGV.BackgroundColor = Color.Linen;
            ProudectInorderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProudectInorderDGV.Location = new Point(9, 31);
            ProudectInorderDGV.Margin = new Padding(4);
            ProudectInorderDGV.Name = "ProudectInorderDGV";
            ProudectInorderDGV.RowHeadersWidth = 51;
            ProudectInorderDGV.Size = new Size(1409, 551);
            ProudectInorderDGV.TabIndex = 3;
            // 
            // productsInOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 611);
            Controls.Add(ProudectInorderDGV);
            Name = "productsInOrder";
            Text = "productsInOrder";
            ((System.ComponentModel.ISupportInitialize)ProudectInorderDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProudectInorderDGV;
    }
}