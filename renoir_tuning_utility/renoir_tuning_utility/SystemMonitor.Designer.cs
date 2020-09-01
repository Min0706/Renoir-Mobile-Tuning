﻿namespace renoir_tuning_utility
{
    partial class SystemMonitor
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
            this.CpuData = new System.Windows.Forms.DataGridView();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRefreshInterval = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CpuData)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // CpuData
            // 
            this.CpuData.AllowUserToAddRows = false;
            this.CpuData.AllowUserToDeleteRows = false;
            this.CpuData.AllowUserToResizeRows = false;
            this.CpuData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CpuData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CpuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CpuData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Offset,
            this.Sensor,
            this.Value});
            this.tableLayoutPanel1.SetColumnSpan(this.CpuData, 4);
            this.CpuData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CpuData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CpuData.GridColor = System.Drawing.SystemColors.ControlLight;
            this.CpuData.Location = new System.Drawing.Point(3, 3);
            this.CpuData.MultiSelect = false;
            this.CpuData.Name = "CpuData";
            this.CpuData.ReadOnly = true;
            this.CpuData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CpuData.RowHeadersVisible = false;
            this.CpuData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CpuData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CpuData.ShowCellToolTips = false;
            this.CpuData.ShowEditingIcon = false;
            this.CpuData.ShowRowErrors = false;
            this.CpuData.Size = new System.Drawing.Size(258, 427);
            this.CpuData.TabIndex = 0;
            this.CpuData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cpuData_CellContentClick);
            // 
            // Offset
            // 
            this.Offset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Offset.DataPropertyName = "Offset";
            this.Offset.HeaderText = "Offset";
            this.Offset.Name = "Offset";
            this.Offset.ReadOnly = true;
            this.Offset.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Offset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Offset.Width = 41;
            // 
            // Sensor
            // 
            this.Sensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sensor.DataPropertyName = "Sensor";
            this.Sensor.HeaderText = "Sensor";
            this.Sensor.MinimumWidth = 100;
            this.Sensor.Name = "Sensor";
            this.Sensor.ReadOnly = true;
            this.Sensor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sensor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 100;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelRefreshInterval, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CpuData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonApply, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownInterval, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 462);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelRefreshInterval
            // 
            this.labelRefreshInterval.AutoSize = true;
            this.labelRefreshInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRefreshInterval.Location = new System.Drawing.Point(3, 433);
            this.labelRefreshInterval.Name = "labelRefreshInterval";
            this.labelRefreshInterval.Size = new System.Drawing.Size(82, 29);
            this.labelRefreshInterval.TabIndex = 0;
            this.labelRefreshInterval.Text = "Refresh Interval";
            this.labelRefreshInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonApply
            // 
            this.buttonApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonApply.Location = new System.Drawing.Point(150, 436);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.AutoSize = true;
            this.numericUpDownInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownInterval.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownInterval.Location = new System.Drawing.Point(91, 438);
            this.numericUpDownInterval.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownInterval.TabIndex = 2;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // SystemMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(280, 39);
            this.Name = "SystemMonitor";
            this.Text = "SystemMonitor";
            ((System.ComponentModel.ISupportInitialize)(this.CpuData)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CpuData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelRefreshInterval;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}