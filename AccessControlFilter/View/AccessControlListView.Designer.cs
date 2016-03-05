namespace AccessControlFilter.View
{
    partial class AccessControlListView
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_filterEnable = new System.Windows.Forms.RadioButton();
            this.radioButton_filterDisable = new System.Windows.Forms.RadioButton();
            this.radioButton_modeManual = new System.Windows.Forms.RadioButton();
            this.radioButton_modeWhiteList = new System.Windows.Forms.RadioButton();
            this.radioButton_modeBlackList = new System.Windows.Forms.RadioButton();
            this.groupBox_modeSetting = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_hideSessionEnable = new System.Windows.Forms.RadioButton();
            this.radioButton_hideSessionDisable = new System.Windows.Forms.RadioButton();
            this.groupBox_allowList = new System.Windows.Forms.GroupBox();
            this.button_allowListMoveDeny = new System.Windows.Forms.Button();
            this.button_allowListAdd = new System.Windows.Forms.Button();
            this.button_allowListDelete = new System.Windows.Forms.Button();
            this.button_allowListClear = new System.Windows.Forms.Button();
            this.dataGridView_AllowList = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox_denyList = new System.Windows.Forms.GroupBox();
            this.button_denyListMoveAllow = new System.Windows.Forms.Button();
            this.button_denyListAdd = new System.Windows.Forms.Button();
            this.button_denyListDelete = new System.Windows.Forms.Button();
            this.button_denyListClear = new System.Windows.Forms.Button();
            this.dataGridView_DenyList = new System.Windows.Forms.DataGridView();
            this.domainColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_modeSetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_allowList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllowList)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox_denyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DenyList)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_filterEnable
            // 
            this.radioButton_filterEnable.AutoSize = true;
            this.radioButton_filterEnable.Location = new System.Drawing.Point(4, 19);
            this.radioButton_filterEnable.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_filterEnable.Name = "radioButton_filterEnable";
            this.radioButton_filterEnable.Size = new System.Drawing.Size(83, 22);
            this.radioButton_filterEnable.TabIndex = 0;
            this.radioButton_filterEnable.Text = "Enable";
            this.radioButton_filterEnable.UseVisualStyleBackColor = true;
            this.radioButton_filterEnable.CheckedChanged += new System.EventHandler(this.radioButton_filterEnable_CheckedChanged);
            // 
            // radioButton_filterDisable
            // 
            this.radioButton_filterDisable.AutoSize = true;
            this.radioButton_filterDisable.Checked = true;
            this.radioButton_filterDisable.Location = new System.Drawing.Point(4, 42);
            this.radioButton_filterDisable.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_filterDisable.Name = "radioButton_filterDisable";
            this.radioButton_filterDisable.Size = new System.Drawing.Size(88, 22);
            this.radioButton_filterDisable.TabIndex = 1;
            this.radioButton_filterDisable.TabStop = true;
            this.radioButton_filterDisable.Text = "Disable";
            this.radioButton_filterDisable.UseVisualStyleBackColor = true;
            this.radioButton_filterDisable.CheckedChanged += new System.EventHandler(this.radioButton_filterDisable_CheckedChanged);
            // 
            // radioButton_modeManual
            // 
            this.radioButton_modeManual.AutoSize = true;
            this.radioButton_modeManual.Checked = true;
            this.radioButton_modeManual.Location = new System.Drawing.Point(4, 19);
            this.radioButton_modeManual.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_modeManual.Name = "radioButton_modeManual";
            this.radioButton_modeManual.Size = new System.Drawing.Size(86, 22);
            this.radioButton_modeManual.TabIndex = 2;
            this.radioButton_modeManual.TabStop = true;
            this.radioButton_modeManual.Text = "Manual";
            this.radioButton_modeManual.UseVisualStyleBackColor = true;
            this.radioButton_modeManual.CheckedChanged += new System.EventHandler(this.radioButton_modeManual_CheckedChanged);
            // 
            // radioButton_modeWhiteList
            // 
            this.radioButton_modeWhiteList.AutoSize = true;
            this.radioButton_modeWhiteList.Location = new System.Drawing.Point(4, 42);
            this.radioButton_modeWhiteList.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_modeWhiteList.Name = "radioButton_modeWhiteList";
            this.radioButton_modeWhiteList.Size = new System.Drawing.Size(107, 22);
            this.radioButton_modeWhiteList.TabIndex = 3;
            this.radioButton_modeWhiteList.Text = "White List";
            this.radioButton_modeWhiteList.UseVisualStyleBackColor = true;
            this.radioButton_modeWhiteList.CheckedChanged += new System.EventHandler(this.radioButton_modeWhiteList_CheckedChanged);
            // 
            // radioButton_modeBlackList
            // 
            this.radioButton_modeBlackList.AutoSize = true;
            this.radioButton_modeBlackList.Location = new System.Drawing.Point(4, 65);
            this.radioButton_modeBlackList.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_modeBlackList.Name = "radioButton_modeBlackList";
            this.radioButton_modeBlackList.Size = new System.Drawing.Size(107, 22);
            this.radioButton_modeBlackList.TabIndex = 4;
            this.radioButton_modeBlackList.Text = "Black List";
            this.radioButton_modeBlackList.UseVisualStyleBackColor = true;
            this.radioButton_modeBlackList.CheckedChanged += new System.EventHandler(this.radioButton_modeBlackList_CheckedChanged);
            // 
            // groupBox_modeSetting
            // 
            this.groupBox_modeSetting.Controls.Add(this.radioButton_modeManual);
            this.groupBox_modeSetting.Controls.Add(this.radioButton_modeBlackList);
            this.groupBox_modeSetting.Controls.Add(this.radioButton_modeWhiteList);
            this.groupBox_modeSetting.Location = new System.Drawing.Point(224, 22);
            this.groupBox_modeSetting.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_modeSetting.Name = "groupBox_modeSetting";
            this.groupBox_modeSetting.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_modeSetting.Size = new System.Drawing.Size(196, 96);
            this.groupBox_modeSetting.TabIndex = 5;
            this.groupBox_modeSetting.TabStop = false;
            this.groupBox_modeSetting.Text = "Mode Setting";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_filterEnable);
            this.groupBox2.Controls.Add(this.radioButton_filterDisable);
            this.groupBox2.Location = new System.Drawing.Point(7, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(196, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Activate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox_modeSetting);
            this.groupBox3.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(4, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1271, 125);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setting";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_hideSessionEnable);
            this.groupBox1.Controls.Add(this.radioButton_hideSessionDisable);
            this.groupBox1.Location = new System.Drawing.Point(438, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(196, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hide Session";
            // 
            // radioButton_hideSessionEnable
            // 
            this.radioButton_hideSessionEnable.AutoSize = true;
            this.radioButton_hideSessionEnable.Location = new System.Drawing.Point(4, 19);
            this.radioButton_hideSessionEnable.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_hideSessionEnable.Name = "radioButton_hideSessionEnable";
            this.radioButton_hideSessionEnable.Size = new System.Drawing.Size(83, 22);
            this.radioButton_hideSessionEnable.TabIndex = 0;
            this.radioButton_hideSessionEnable.Text = "Enable";
            this.radioButton_hideSessionEnable.UseVisualStyleBackColor = true;
            this.radioButton_hideSessionEnable.CheckedChanged += new System.EventHandler(this.radioButton_hideSessionEnable_CheckedChanged);
            // 
            // radioButton_hideSessionDisable
            // 
            this.radioButton_hideSessionDisable.AutoSize = true;
            this.radioButton_hideSessionDisable.Checked = true;
            this.radioButton_hideSessionDisable.Location = new System.Drawing.Point(4, 42);
            this.radioButton_hideSessionDisable.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_hideSessionDisable.Name = "radioButton_hideSessionDisable";
            this.radioButton_hideSessionDisable.Size = new System.Drawing.Size(88, 22);
            this.radioButton_hideSessionDisable.TabIndex = 1;
            this.radioButton_hideSessionDisable.TabStop = true;
            this.radioButton_hideSessionDisable.Text = "Disable";
            this.radioButton_hideSessionDisable.UseVisualStyleBackColor = true;
            this.radioButton_hideSessionDisable.CheckedChanged += new System.EventHandler(this.radioButton_hideSessionDisable_CheckedChanged);
            // 
            // groupBox_allowList
            // 
            this.groupBox_allowList.Controls.Add(this.button_allowListMoveDeny);
            this.groupBox_allowList.Controls.Add(this.button_allowListAdd);
            this.groupBox_allowList.Controls.Add(this.button_allowListDelete);
            this.groupBox_allowList.Controls.Add(this.button_allowListClear);
            this.groupBox_allowList.Controls.Add(this.dataGridView_AllowList);
            this.groupBox_allowList.Enabled = false;
            this.groupBox_allowList.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox_allowList.Location = new System.Drawing.Point(4, 134);
            this.groupBox_allowList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_allowList.Name = "groupBox_allowList";
            this.groupBox_allowList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_allowList.Size = new System.Drawing.Size(1271, 332);
            this.groupBox_allowList.TabIndex = 7;
            this.groupBox_allowList.TabStop = false;
            this.groupBox_allowList.Text = "Allow List";
            // 
            // button_allowListMoveDeny
            // 
            this.button_allowListMoveDeny.Location = new System.Drawing.Point(658, 296);
            this.button_allowListMoveDeny.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_allowListMoveDeny.Name = "button_allowListMoveDeny";
            this.button_allowListMoveDeny.Size = new System.Drawing.Size(146, 29);
            this.button_allowListMoveDeny.TabIndex = 4;
            this.button_allowListMoveDeny.Text = "Move Deny";
            this.button_allowListMoveDeny.UseVisualStyleBackColor = true;
            this.button_allowListMoveDeny.Click += new System.EventHandler(this.button_allowListMoveDeny_Click);
            // 
            // button_allowListAdd
            // 
            this.button_allowListAdd.Location = new System.Drawing.Point(811, 296);
            this.button_allowListAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_allowListAdd.Name = "button_allowListAdd";
            this.button_allowListAdd.Size = new System.Drawing.Size(146, 29);
            this.button_allowListAdd.TabIndex = 3;
            this.button_allowListAdd.Text = "Add";
            this.button_allowListAdd.UseVisualStyleBackColor = true;
            // 
            // button_allowListDelete
            // 
            this.button_allowListDelete.Location = new System.Drawing.Point(964, 296);
            this.button_allowListDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_allowListDelete.Name = "button_allowListDelete";
            this.button_allowListDelete.Size = new System.Drawing.Size(146, 29);
            this.button_allowListDelete.TabIndex = 2;
            this.button_allowListDelete.Text = "Delete";
            this.button_allowListDelete.UseVisualStyleBackColor = true;
            this.button_allowListDelete.Click += new System.EventHandler(this.button_allowListDelete_Click);
            // 
            // button_allowListClear
            // 
            this.button_allowListClear.Location = new System.Drawing.Point(1117, 296);
            this.button_allowListClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_allowListClear.Name = "button_allowListClear";
            this.button_allowListClear.Size = new System.Drawing.Size(146, 29);
            this.button_allowListClear.TabIndex = 1;
            this.button_allowListClear.Text = "Clear";
            this.button_allowListClear.UseVisualStyleBackColor = true;
            this.button_allowListClear.Click += new System.EventHandler(this.button_allowListClear_Click);
            // 
            // dataGridView_AllowList
            // 
            this.dataGridView_AllowList.AllowUserToAddRows = false;
            this.dataGridView_AllowList.AllowUserToDeleteRows = false;
            this.dataGridView_AllowList.AllowUserToResizeColumns = false;
            this.dataGridView_AllowList.AllowUserToResizeRows = false;
            this.dataGridView_AllowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllowList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domainColumn});
            this.dataGridView_AllowList.Location = new System.Drawing.Point(11, 21);
            this.dataGridView_AllowList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_AllowList.Name = "dataGridView_AllowList";
            this.dataGridView_AllowList.ReadOnly = true;
            this.dataGridView_AllowList.RowHeadersVisible = false;
            this.dataGridView_AllowList.RowTemplate.Height = 24;
            this.dataGridView_AllowList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_AllowList.Size = new System.Drawing.Size(1252, 269);
            this.dataGridView_AllowList.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(160, 31);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 29);
            this.button9.TabIndex = 5;
            this.button9.Text = "Import";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(7, 31);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(146, 29);
            this.button10.TabIndex = 6;
            this.button10.Text = "Export";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button9);
            this.groupBox6.Controls.Add(this.button10);
            this.groupBox6.Location = new System.Drawing.Point(960, 810);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(315, 78);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data";
            // 
            // groupBox_denyList
            // 
            this.groupBox_denyList.Controls.Add(this.button_denyListMoveAllow);
            this.groupBox_denyList.Controls.Add(this.button_denyListAdd);
            this.groupBox_denyList.Controls.Add(this.button_denyListDelete);
            this.groupBox_denyList.Controls.Add(this.button_denyListClear);
            this.groupBox_denyList.Controls.Add(this.dataGridView_DenyList);
            this.groupBox_denyList.Enabled = false;
            this.groupBox_denyList.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox_denyList.Location = new System.Drawing.Point(4, 472);
            this.groupBox_denyList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_denyList.Name = "groupBox_denyList";
            this.groupBox_denyList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_denyList.Size = new System.Drawing.Size(1271, 332);
            this.groupBox_denyList.TabIndex = 8;
            this.groupBox_denyList.TabStop = false;
            this.groupBox_denyList.Text = "Deny List";
            // 
            // button_denyListMoveAllow
            // 
            this.button_denyListMoveAllow.Location = new System.Drawing.Point(658, 296);
            this.button_denyListMoveAllow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_denyListMoveAllow.Name = "button_denyListMoveAllow";
            this.button_denyListMoveAllow.Size = new System.Drawing.Size(146, 29);
            this.button_denyListMoveAllow.TabIndex = 4;
            this.button_denyListMoveAllow.Text = "Move Allow";
            this.button_denyListMoveAllow.UseVisualStyleBackColor = true;
            this.button_denyListMoveAllow.Click += new System.EventHandler(this.button_denyListMoveAllow_Click);
            // 
            // button_denyListAdd
            // 
            this.button_denyListAdd.Location = new System.Drawing.Point(811, 296);
            this.button_denyListAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_denyListAdd.Name = "button_denyListAdd";
            this.button_denyListAdd.Size = new System.Drawing.Size(146, 29);
            this.button_denyListAdd.TabIndex = 3;
            this.button_denyListAdd.Text = "Add";
            this.button_denyListAdd.UseVisualStyleBackColor = true;
            // 
            // button_denyListDelete
            // 
            this.button_denyListDelete.Location = new System.Drawing.Point(964, 296);
            this.button_denyListDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_denyListDelete.Name = "button_denyListDelete";
            this.button_denyListDelete.Size = new System.Drawing.Size(146, 29);
            this.button_denyListDelete.TabIndex = 2;
            this.button_denyListDelete.Text = "Delete";
            this.button_denyListDelete.UseVisualStyleBackColor = true;
            this.button_denyListDelete.Click += new System.EventHandler(this.button_denyListDelete_Click);
            // 
            // button_denyListClear
            // 
            this.button_denyListClear.Location = new System.Drawing.Point(1117, 296);
            this.button_denyListClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_denyListClear.Name = "button_denyListClear";
            this.button_denyListClear.Size = new System.Drawing.Size(146, 29);
            this.button_denyListClear.TabIndex = 1;
            this.button_denyListClear.Text = "Clear";
            this.button_denyListClear.UseVisualStyleBackColor = true;
            this.button_denyListClear.Click += new System.EventHandler(this.button_denyListClear_Click);
            // 
            // dataGridView_DenyList
            // 
            this.dataGridView_DenyList.AllowUserToAddRows = false;
            this.dataGridView_DenyList.AllowUserToDeleteRows = false;
            this.dataGridView_DenyList.AllowUserToResizeColumns = false;
            this.dataGridView_DenyList.AllowUserToResizeRows = false;
            this.dataGridView_DenyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DenyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView_DenyList.Location = new System.Drawing.Point(11, 21);
            this.dataGridView_DenyList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_DenyList.Name = "dataGridView_DenyList";
            this.dataGridView_DenyList.ReadOnly = true;
            this.dataGridView_DenyList.RowHeadersVisible = false;
            this.dataGridView_DenyList.RowTemplate.Height = 24;
            this.dataGridView_DenyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_DenyList.Size = new System.Drawing.Size(1252, 269);
            this.dataGridView_DenyList.TabIndex = 0;
            // 
            // domainColumn
            // 
            this.domainColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.domainColumn.DividerWidth = 1;
            this.domainColumn.HeaderText = "Domain";
            this.domainColumn.Name = "domainColumn";
            this.domainColumn.ReadOnly = true;
            this.domainColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.domainColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.domainColumn.ToolTipText = "アクセスを許可するドメインのリストです";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DividerWidth = 1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Domain";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AccessControlListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox_denyList);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox_allowList);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccessControlListView";
            this.Size = new System.Drawing.Size(1285, 898);
            this.groupBox_modeSetting.ResumeLayout(false);
            this.groupBox_modeSetting.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_allowList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllowList)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox_denyList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DenyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_modeSetting;
        private System.Windows.Forms.RadioButton radioButton_modeBlackList;
        private System.Windows.Forms.RadioButton radioButton_modeWhiteList;
        private System.Windows.Forms.RadioButton radioButton_modeManual;
        private System.Windows.Forms.RadioButton radioButton_filterDisable;
        private System.Windows.Forms.RadioButton radioButton_filterEnable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_allowList;
        private System.Windows.Forms.DataGridView dataGridView_AllowList;
        private System.Windows.Forms.Button button_allowListClear;
        private System.Windows.Forms.Button button_allowListMoveDeny;
        private System.Windows.Forms.Button button_allowListAdd;
        private System.Windows.Forms.Button button_allowListDelete;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox_denyList;
        private System.Windows.Forms.Button button_denyListMoveAllow;
        private System.Windows.Forms.Button button_denyListAdd;
        private System.Windows.Forms.Button button_denyListDelete;
        private System.Windows.Forms.Button button_denyListClear;
        private System.Windows.Forms.DataGridView dataGridView_DenyList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_hideSessionEnable;
        private System.Windows.Forms.RadioButton radioButton_hideSessionDisable;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
