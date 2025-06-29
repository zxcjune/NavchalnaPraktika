namespace Lab5
{
    partial class fTicketsList
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
            this.ticketsListView = new System.Windows.Forms.ListView();
            this.TicketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RouteID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassengerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DriverName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReturnTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticketsListView
            // 
            this.ticketsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TicketID,
            this.RouteID,
            this.PassengerName,
            this.Bus,
            this.DepartureTime,
            this.Destination,
            this.DriverName,
            this.Cost});
            this.ticketsListView.FullRowSelect = true;
            this.ticketsListView.HideSelection = false;
            this.ticketsListView.Location = new System.Drawing.Point(0, 55);
            this.ticketsListView.Name = "ticketsListView";
            this.ticketsListView.Size = new System.Drawing.Size(800, 394);
            this.ticketsListView.TabIndex = 0;
            this.ticketsListView.UseCompatibleStateImageBehavior = false;
            this.ticketsListView.View = System.Windows.Forms.View.Details;
            // 
            // TicketID
            // 
            this.TicketID.Text = "Ticket ID";
            this.TicketID.Width = 88;
            // 
            // RouteID
            // 
            this.RouteID.Text = "Route ID";
            this.RouteID.Width = 88;
            // 
            // PassengerName
            // 
            this.PassengerName.Text = "Passenger Name";
            this.PassengerName.Width = 77;
            // 
            // Bus
            // 
            this.Bus.Text = "Bus";
            this.Bus.Width = 50;
            // 
            // DepartureTime
            // 
            this.DepartureTime.Text = "DepartureTime";
            this.DepartureTime.Width = 117;
            // 
            // Destination
            // 
            this.Destination.Text = "Destination";
            this.Destination.Width = 89;
            // 
            // DriverName
            // 
            this.DriverName.Text = "DriverName";
            this.DriverName.Width = 94;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            // 
            // btnReturnTicket
            // 
            this.btnReturnTicket.Location = new System.Drawing.Point(12, 5);
            this.btnReturnTicket.Name = "btnReturnTicket";
            this.btnReturnTicket.Size = new System.Drawing.Size(94, 44);
            this.btnReturnTicket.TabIndex = 1;
            this.btnReturnTicket.Text = "Повернути квиток";
            this.btnReturnTicket.UseVisualStyleBackColor = true;
            this.btnReturnTicket.Click += new System.EventHandler(this.btnReturnTicket_Click);
            // 
            // fTicketsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnTicket);
            this.Controls.Add(this.ticketsListView);
            this.Name = "fTicketsList";
            this.Text = "Список квитків";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ticketsListView;
        private System.Windows.Forms.ColumnHeader TicketID;
        private System.Windows.Forms.ColumnHeader RouteID;
        private System.Windows.Forms.ColumnHeader PassengerName;
        private System.Windows.Forms.ColumnHeader DepartureTime;
        private System.Windows.Forms.ColumnHeader Destination;
        private System.Windows.Forms.ColumnHeader Bus;
        private System.Windows.Forms.ColumnHeader DriverName;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Button btnReturnTicket;
    }
}