namespace Presentation
{
    partial class OrderStatusPanel
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
            AllOrdersDGV = new DataGridView();
            label6 = new Label();
            processingradio = new RadioButton();
            shippedradio = new RadioButton();
            deliveredradio = new RadioButton();
            label2 = new Label();
            IDMessage = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)AllOrdersDGV).BeginInit();
            SuspendLayout();
            // 
            // AllOrdersDGV
            // 
            AllOrdersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllOrdersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllOrdersDGV.Location = new Point(12, 284);
            AllOrdersDGV.Name = "AllOrdersDGV";
            AllOrdersDGV.RowHeadersWidth = 51;
            AllOrdersDGV.Size = new Size(1078, 394);
            AllOrdersDGV.TabIndex = 3;
            AllOrdersDGV.RowHeaderMouseClick += AllOrdersDGV_RowHeaderMouseClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(33, 42, 81);
            label6.Location = new Point(23, 153);
            label6.Name = "label6";
            label6.Size = new Size(206, 41);
            label6.TabIndex = 20;
            label6.Text = "Select Status :";
            // 
            // processingradio
            // 
            processingradio.AutoSize = true;
            processingradio.BackColor = Color.FromArgb(214, 90, 49);
            processingradio.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            processingradio.ForeColor = Color.FromArgb(238, 238, 238);
            processingradio.Location = new Point(235, 149);
            processingradio.Name = "processingradio";
            processingradio.Padding = new Padding(5);
            processingradio.Size = new Size(155, 45);
            processingradio.TabIndex = 21;
            processingradio.TabStop = true;
            processingradio.Text = "processing";
            processingradio.UseVisualStyleBackColor = false;
            processingradio.CheckedChanged += processingradio_CheckedChanged;
            // 
            // shippedradio
            // 
            shippedradio.AutoSize = true;
            shippedradio.BackColor = Color.FromArgb(214, 90, 49);
            shippedradio.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            shippedradio.ForeColor = Color.FromArgb(238, 238, 238);
            shippedradio.Location = new Point(438, 149);
            shippedradio.Name = "shippedradio";
            shippedradio.Padding = new Padding(5);
            shippedradio.Size = new Size(126, 45);
            shippedradio.TabIndex = 22;
            shippedradio.TabStop = true;
            shippedradio.Text = "shipped";
            shippedradio.UseVisualStyleBackColor = false;
            shippedradio.CheckedChanged += shippedradio_CheckedChanged;
            // 
            // deliveredradio
            // 
            deliveredradio.AutoSize = true;
            deliveredradio.BackColor = Color.FromArgb(214, 90, 49);
            deliveredradio.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            deliveredradio.ForeColor = Color.FromArgb(238, 238, 238);
            deliveredradio.Location = new Point(615, 149);
            deliveredradio.Name = "deliveredradio";
            deliveredradio.Padding = new Padding(5);
            deliveredradio.Size = new Size(142, 45);
            deliveredradio.TabIndex = 24;
            deliveredradio.TabStop = true;
            deliveredradio.Text = "delivered";
            deliveredradio.UseVisualStyleBackColor = false;
            deliveredradio.CheckedChanged += deliveredradio_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(33, 42, 81);
            label2.Location = new Point(23, 76);
            label2.Name = "label2";
            label2.Size = new Size(151, 41);
            label2.TabIndex = 25;
            label2.Text = "Order ID :";
            // 
            // IDMessage
            // 
            IDMessage.AutoSize = true;
            IDMessage.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDMessage.ForeColor = Color.FromArgb(214, 90, 49);
            IDMessage.Location = new Point(687, 76);
            IDMessage.Name = "IDMessage";
            IDMessage.Size = new Size(379, 41);
            IDMessage.TabIndex = 26;
            IDMessage.Text = "Select Order row Header";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(33, 42, 81);
            label1.Location = new Point(367, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 57);
            label1.TabIndex = 27;
            label1.Text = "Order Status ";
            // 
            // OrderStatusPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 690);
            Controls.Add(label1);
            Controls.Add(IDMessage);
            Controls.Add(label2);
            Controls.Add(deliveredradio);
            Controls.Add(shippedradio);
            Controls.Add(processingradio);
            Controls.Add(label6);
            Controls.Add(AllOrdersDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderStatusPanel";
            Text = "change the status of order from waiting to charged";
            ((System.ComponentModel.ISupportInitialize)AllOrdersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView AllOrdersDGV;
        private Label label6;
        private RadioButton processingradio;
        private RadioButton shippedradio;
        private RadioButton deliveredradio;
        private Label label2;
        private Label IDMessage;
        private Label label1;
    }
}