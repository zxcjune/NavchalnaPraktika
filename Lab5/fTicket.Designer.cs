namespace Lab5
{
    partial class fTicket
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRouteID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labl124 = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbPassengerName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbTicketType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDriverName = new System.Windows.Forms.TextBox();
            this.tbBus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(349, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "RouteID";
            // 
            // tbRouteID
            // 
            this.tbRouteID.Location = new System.Drawing.Point(147, 27);
            this.tbRouteID.Name = "tbRouteID";
            this.tbRouteID.Size = new System.Drawing.Size(100, 22);
            this.tbRouteID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Місце прибуття";
            // 
            // labl124
            // 
            this.labl124.AutoSize = true;
            this.labl124.Location = new System.Drawing.Point(24, 66);
            this.labl124.Name = "labl124";
            this.labl124.Size = new System.Drawing.Size(29, 16);
            this.labl124.TabIndex = 15;
            this.labl124.Text = "Ім\'я";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(147, 103);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(100, 22);
            this.tbDestination.TabIndex = 16;
            // 
            // tbPassengerName
            // 
            this.tbPassengerName.Location = new System.Drawing.Point(147, 63);
            this.tbPassengerName.Name = "tbPassengerName";
            this.tbPassengerName.Size = new System.Drawing.Size(100, 22);
            this.tbPassengerName.TabIndex = 17;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(349, 27);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 25);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Створити ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbTicketType
            // 
            this.cmbTicketType.FormattingEnabled = true;
            this.cmbTicketType.Items.AddRange(new object[] {
            "Standart Ticket",
            "Discount Ticket"});
            this.cmbTicketType.Location = new System.Drawing.Point(147, 228);
            this.cmbTicketType.Name = "cmbTicketType";
            this.cmbTicketType.Size = new System.Drawing.Size(100, 24);
            this.cmbTicketType.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ім\'я водія";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Автобус";
            // 
            // tbDriverName
            // 
            this.tbDriverName.Location = new System.Drawing.Point(147, 185);
            this.tbDriverName.Name = "tbDriverName";
            this.tbDriverName.Size = new System.Drawing.Size(100, 22);
            this.tbDriverName.TabIndex = 22;
            // 
            // tbBus
            // 
            this.tbBus.Location = new System.Drawing.Point(147, 142);
            this.tbBus.Name = "tbBus";
            this.tbBus.Size = new System.Drawing.Size(100, 22);
            this.tbBus.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Тип квитка";
            // 
            // fTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(457, 264);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBus);
            this.Controls.Add(this.tbDriverName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTicketType);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbPassengerName);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.labl124);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRouteID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.Name = "fTicket";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про квиток";
            this.Load += new System.EventHandler(this.fPhone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRouteID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labl124;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbPassengerName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbTicketType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDriverName;
        private System.Windows.Forms.TextBox tbBus;
        private System.Windows.Forms.Label label5;
    }
}