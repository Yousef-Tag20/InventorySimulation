namespace InventorySimulation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysWithinCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginningInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitForDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitForLead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysUntilOrderArrives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Cycle,
            this.DaysWithinCycle,
            this.BeginningInventory,
            this.RandomDigitForDemand,
            this.Demand,
            this.EndingInventory,
            this.ShortageQuantity,
            this.OrderQuantity,
            this.RandomDigitForLead,
            this.LeadTime,
            this.DaysUntilOrderArrives});
            this.dataGridView1.Location = new System.Drawing.Point(2, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(2026, 784);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 62;
            // 
            // Cycle
            // 
            this.Cycle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.MinimumWidth = 6;
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            this.Cycle.Width = 71;
            // 
            // DaysWithinCycle
            // 
            this.DaysWithinCycle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DaysWithinCycle.HeaderText = "DaysWithinCycle";
            this.DaysWithinCycle.MinimumWidth = 6;
            this.DaysWithinCycle.Name = "DaysWithinCycle";
            this.DaysWithinCycle.ReadOnly = true;
            this.DaysWithinCycle.Width = 142;
            // 
            // BeginningInventory
            // 
            this.BeginningInventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BeginningInventory.HeaderText = "Beginning Inventory";
            this.BeginningInventory.MinimumWidth = 6;
            this.BeginningInventory.Name = "BeginningInventory";
            this.BeginningInventory.ReadOnly = true;
            this.BeginningInventory.Width = 148;
            // 
            // RandomDigitForDemand
            // 
            this.RandomDigitForDemand.HeaderText = "Random Digit for Demand";
            this.RandomDigitForDemand.MinimumWidth = 6;
            this.RandomDigitForDemand.Name = "RandomDigitForDemand";
            this.RandomDigitForDemand.ReadOnly = true;
            this.RandomDigitForDemand.Width = 125;
            // 
            // Demand
            // 
            this.Demand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Demand.HeaderText = "Demand";
            this.Demand.MinimumWidth = 6;
            this.Demand.Name = "Demand";
            this.Demand.ReadOnly = true;
            this.Demand.Width = 90;
            // 
            // EndingInventory
            // 
            this.EndingInventory.HeaderText = "EndingInventory";
            this.EndingInventory.MinimumWidth = 6;
            this.EndingInventory.Name = "EndingInventory";
            this.EndingInventory.ReadOnly = true;
            this.EndingInventory.Width = 125;
            // 
            // ShortageQuantity
            // 
            this.ShortageQuantity.HeaderText = "Shortage Quantity";
            this.ShortageQuantity.MinimumWidth = 6;
            this.ShortageQuantity.Name = "ShortageQuantity";
            this.ShortageQuantity.ReadOnly = true;
            this.ShortageQuantity.Width = 125;
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.HeaderText = "Order Quantity";
            this.OrderQuantity.MinimumWidth = 6;
            this.OrderQuantity.Name = "OrderQuantity";
            this.OrderQuantity.ReadOnly = true;
            this.OrderQuantity.Width = 125;
            // 
            // RandomDigitForLead
            // 
            this.RandomDigitForLead.HeaderText = "Random Digit for Lead";
            this.RandomDigitForLead.MinimumWidth = 6;
            this.RandomDigitForLead.Name = "RandomDigitForLead";
            this.RandomDigitForLead.ReadOnly = true;
            this.RandomDigitForLead.Width = 125;
            // 
            // LeadTime
            // 
            this.LeadTime.HeaderText = "Lead Time";
            this.LeadTime.MinimumWidth = 6;
            this.LeadTime.Name = "LeadTime";
            this.LeadTime.ReadOnly = true;
            this.LeadTime.Width = 125;
            // 
            // DaysUntilOrderArrives
            // 
            this.DaysUntilOrderArrives.HeaderText = "Days until Order arrives";
            this.DaysUntilOrderArrives.MinimumWidth = 6;
            this.DaysUntilOrderArrives.Name = "DaysUntilOrderArrives";
            this.DaysUntilOrderArrives.ReadOnly = true;
            this.DaysUntilOrderArrives.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 817);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysWithinCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginningInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitForDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortageQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitForLead;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysUntilOrderArrives;
    }
}

