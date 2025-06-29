namespace Lab5
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.tbFilterCriteria = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbFilterCriteria = new System.Windows.Forms.ComboBox();
            this.btnFindNearestRoute = new System.Windows.Forms.Button();
            this.routesListView = new System.Windows.Forms.ListView();
            this.RouteNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinalDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IntermediatePoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvailableSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DriverName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbFindNearestRoute = new System.Windows.Forms.TextBox();
            this.btnOpenTicketList = new System.Windows.Forms.Button();
            this.btnCreateManifest = new System.Windows.Forms.Button();
            this.btnLastTicket = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.toolStripSeparator1,
            this.btnDel,
            this.toolStripSeparator3,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1318, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 24);
            this.btnAdd.Text = "Додати запис про велосипед";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 28);
            this.btnEdit.Text = "Редагувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(29, 28);
            this.btnDel.Text = "Видалити запис";
            this.btnDel.Click += new System.EventHandler(this.btnDeleteRoute_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 28);
            this.btnExit.Text = "Вийти з програми";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Location = new System.Drawing.Point(291, 30);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(100, 64);
            this.btnBuyTicket.TabIndex = 4;
            this.btnBuyTicket.Text = "Створити квиток";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveFilter);
            this.groupBox2.Controls.Add(this.tbFilterCriteria);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.cmbFilterCriteria);
            this.groupBox2.Location = new System.Drawing.Point(12, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 89);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фільтрація";
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Location = new System.Drawing.Point(133, 59);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(101, 24);
            this.btnRemoveFilter.TabIndex = 7;
            this.btnRemoveFilter.Text = "Відмінити";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // tbFilterCriteria
            // 
            this.tbFilterCriteria.Location = new System.Drawing.Point(6, 61);
            this.tbFilterCriteria.Name = "tbFilterCriteria";
            this.tbFilterCriteria.Size = new System.Drawing.Size(121, 22);
            this.tbFilterCriteria.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(133, 21);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(101, 24);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Фільтрувати";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbFilterCriteria
            // 
            this.cmbFilterCriteria.FormattingEnabled = true;
            this.cmbFilterCriteria.Items.AddRange(new object[] {
            "За вільними місцями",
            "За місцем прибуття"});
            this.cmbFilterCriteria.Location = new System.Drawing.Point(6, 21);
            this.cmbFilterCriteria.Name = "cmbFilterCriteria";
            this.cmbFilterCriteria.Size = new System.Drawing.Size(121, 24);
            this.cmbFilterCriteria.TabIndex = 0;
            // 
            // btnFindNearestRoute
            // 
            this.btnFindNearestRoute.Location = new System.Drawing.Point(735, 32);
            this.btnFindNearestRoute.Name = "btnFindNearestRoute";
            this.btnFindNearestRoute.Size = new System.Drawing.Size(100, 61);
            this.btnFindNearestRoute.TabIndex = 7;
            this.btnFindNearestRoute.Text = "Знайти найближчий маршрут";
            this.btnFindNearestRoute.UseVisualStyleBackColor = true;
            this.btnFindNearestRoute.Click += new System.EventHandler(this.btnFindNearestRoute_Click);
            // 
            // routesListView
            // 
            this.routesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RouteNumber,
            this.StartPoint,
            this.FinalDestination,
            this.IntermediatePoint,
            this.DepartureTime,
            this.ArrivalTime,
            this.TotalSeats,
            this.AvailableSeats,
            this.Bus,
            this.DriverName});
            this.routesListView.FullRowSelect = true;
            this.routesListView.HideSelection = false;
            this.routesListView.Location = new System.Drawing.Point(0, 138);
            this.routesListView.Name = "routesListView";
            this.routesListView.Size = new System.Drawing.Size(1306, 331);
            this.routesListView.TabIndex = 8;
            this.routesListView.UseCompatibleStateImageBehavior = false;
            this.routesListView.View = System.Windows.Forms.View.Details;
            this.routesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.routesListView_ColumnClick);
            // 
            // RouteNumber
            // 
            this.RouteNumber.Text = "RouteNumber";
            this.RouteNumber.Width = 115;
            // 
            // StartPoint
            // 
            this.StartPoint.Text = "StartPoint";
            this.StartPoint.Width = 94;
            // 
            // FinalDestination
            // 
            this.FinalDestination.Text = "FinalDestination";
            this.FinalDestination.Width = 137;
            // 
            // IntermediatePoint
            // 
            this.IntermediatePoint.Text = "IntermediatePoints";
            this.IntermediatePoint.Width = 153;
            // 
            // DepartureTime
            // 
            this.DepartureTime.Text = "DepartureTime";
            this.DepartureTime.Width = 103;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Text = "ArrivalTime";
            this.ArrivalTime.Width = 124;
            // 
            // TotalSeats
            // 
            this.TotalSeats.Text = "TotalSeats";
            this.TotalSeats.Width = 114;
            // 
            // AvailableSeats
            // 
            this.AvailableSeats.Text = "AvailableSeats";
            this.AvailableSeats.Width = 128;
            // 
            // Bus
            // 
            this.Bus.Text = "Bus";
            // 
            // DriverName
            // 
            this.DriverName.Text = "DriverName";
            // 
            // tbFindNearestRoute
            // 
            this.tbFindNearestRoute.Location = new System.Drawing.Point(857, 50);
            this.tbFindNearestRoute.Name = "tbFindNearestRoute";
            this.tbFindNearestRoute.Size = new System.Drawing.Size(106, 22);
            this.tbFindNearestRoute.TabIndex = 9;
            // 
            // btnOpenTicketList
            // 
            this.btnOpenTicketList.Location = new System.Drawing.Point(445, 30);
            this.btnOpenTicketList.Name = "btnOpenTicketList";
            this.btnOpenTicketList.Size = new System.Drawing.Size(106, 66);
            this.btnOpenTicketList.TabIndex = 10;
            this.btnOpenTicketList.Text = "Відкрити список квитків";
            this.btnOpenTicketList.UseVisualStyleBackColor = true;
            this.btnOpenTicketList.Click += new System.EventHandler(this.btnOpenTicketList_Click);
            // 
            // btnCreateManifest
            // 
            this.btnCreateManifest.Location = new System.Drawing.Point(594, 32);
            this.btnCreateManifest.Name = "btnCreateManifest";
            this.btnCreateManifest.Size = new System.Drawing.Size(104, 63);
            this.btnCreateManifest.TabIndex = 11;
            this.btnCreateManifest.Text = "Створити посадкову відомість";
            this.btnCreateManifest.UseVisualStyleBackColor = true;
            this.btnCreateManifest.Click += new System.EventHandler(this.btnCreateManifest_Click);
            // 
            // btnLastTicket
            // 
            this.btnLastTicket.Location = new System.Drawing.Point(1017, 33);
            this.btnLastTicket.Name = "btnLastTicket";
            this.btnLastTicket.Size = new System.Drawing.Size(102, 61);
            this.btnLastTicket.TabIndex = 8;
            this.btnLastTicket.Text = "Останній квиток";
            this.btnLastTicket.UseVisualStyleBackColor = true;
            this.btnLastTicket.Click += new System.EventHandler(this.btnLastTicket_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 495);
            this.Controls.Add(this.btnLastTicket);
            this.Controls.Add(this.btnCreateManifest);
            this.Controls.Add(this.btnOpenTicketList);
            this.Controls.Add(this.tbFindNearestRoute);
            this.Controls.Add(this.routesListView);
            this.Controls.Add(this.btnFindNearestRoute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fMain";
            this.Text = "Каса автовокзалу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.Resize += new System.EventHandler(this.fMain_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbFilterCriteria;
        private System.Windows.Forms.Button btnFindNearestRoute;
        private System.Windows.Forms.TextBox tbFilterCriteria;
        private System.Windows.Forms.ListView routesListView;
        private System.Windows.Forms.ColumnHeader RouteNumber;
        private System.Windows.Forms.ColumnHeader StartPoint;
        private System.Windows.Forms.ColumnHeader FinalDestination;
        private System.Windows.Forms.ColumnHeader IntermediatePoint;
        private System.Windows.Forms.ColumnHeader DepartureTime;
        private System.Windows.Forms.ColumnHeader ArrivalTime;
        private System.Windows.Forms.ColumnHeader TotalSeats;
        private System.Windows.Forms.ColumnHeader AvailableSeats;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.TextBox tbFindNearestRoute;
        private System.Windows.Forms.ColumnHeader Bus;
        private System.Windows.Forms.ColumnHeader DriverName;
        private System.Windows.Forms.Button btnOpenTicketList;
        private System.Windows.Forms.Button btnCreateManifest;
        private System.Windows.Forms.Button btnLastTicket;
    }
}

