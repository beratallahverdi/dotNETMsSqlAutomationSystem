namespace GorselProgramlama_Proje
{
    partial class Homepage
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
            this.ayirici = new System.Windows.Forms.SplitContainer();
            this.casesView = new System.Windows.Forms.Panel();
            this.casesTable = new System.Windows.Forms.TableLayoutPanel();
            this.casesDataGrid = new System.Windows.Forms.DataGridView();
            this.casesInnerPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.casesSearch = new System.Windows.Forms.TextBox();
            this.searchlbl = new System.Windows.Forms.Label();
            this.caseslbl = new System.Windows.Forms.Label();
            this.quickLookView = new System.Windows.Forms.Panel();
            this.quickLookTable = new System.Windows.Forms.TableLayoutPanel();
            this.quickLookDataGrid = new System.Windows.Forms.DataGridView();
            this.quickLooklbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.quickLookBtn = new System.Windows.Forms.Button();
            this.casesBtn = new System.Windows.Forms.Button();
            this.caseAddBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ayirici)).BeginInit();
            this.ayirici.Panel1.SuspendLayout();
            this.ayirici.Panel2.SuspendLayout();
            this.ayirici.SuspendLayout();
            this.casesView.SuspendLayout();
            this.casesTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casesDataGrid)).BeginInit();
            this.casesInnerPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.quickLookView.SuspendLayout();
            this.quickLookTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quickLookDataGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ayirici
            // 
            this.ayirici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ayirici.Location = new System.Drawing.Point(0, 0);
            this.ayirici.Name = "ayirici";
            // 
            // ayirici.Panel1
            // 
            this.ayirici.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // ayirici.Panel2
            // 
            this.ayirici.Panel2.Controls.Add(this.casesView);
            this.ayirici.Panel2.Controls.Add(this.quickLookView);
            this.ayirici.Size = new System.Drawing.Size(1280, 720);
            this.ayirici.SplitterDistance = 150;
            this.ayirici.TabIndex = 0;
            // 
            // casesView
            // 
            this.casesView.Controls.Add(this.casesTable);
            this.casesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casesView.Location = new System.Drawing.Point(0, 0);
            this.casesView.Name = "casesView";
            this.casesView.Size = new System.Drawing.Size(1126, 720);
            this.casesView.TabIndex = 0;
            // 
            // casesTable
            // 
            this.casesTable.ColumnCount = 1;
            this.casesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.casesTable.Controls.Add(this.casesDataGrid, 0, 1);
            this.casesTable.Controls.Add(this.casesInnerPanel, 0, 0);
            this.casesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casesTable.Location = new System.Drawing.Point(0, 0);
            this.casesTable.Name = "casesTable";
            this.casesTable.RowCount = 2;
            this.casesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.casesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.casesTable.Size = new System.Drawing.Size(1126, 720);
            this.casesTable.TabIndex = 0;
            // 
            // casesDataGrid
            // 
            this.casesDataGrid.AllowUserToAddRows = false;
            this.casesDataGrid.AllowUserToDeleteRows = false;
            this.casesDataGrid.AllowUserToOrderColumns = true;
            this.casesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casesDataGrid.Location = new System.Drawing.Point(3, 39);
            this.casesDataGrid.Name = "casesDataGrid";
            this.casesDataGrid.ReadOnly = true;
            this.casesDataGrid.Size = new System.Drawing.Size(1120, 678);
            this.casesDataGrid.TabIndex = 1;
            this.casesDataGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SatirSec_DoubleClick);
            // 
            // casesInnerPanel
            // 
            this.casesInnerPanel.Controls.Add(this.tableLayoutPanel1);
            this.casesInnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casesInnerPanel.Location = new System.Drawing.Point(0, 0);
            this.casesInnerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.casesInnerPanel.Name = "casesInnerPanel";
            this.casesInnerPanel.Size = new System.Drawing.Size(1126, 36);
            this.casesInnerPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.casesSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchlbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.caseslbl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1126, 36);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // casesSearch
            // 
            this.casesSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.casesSearch.Location = new System.Drawing.Point(731, 3);
            this.casesSearch.Margin = new System.Windows.Forms.Padding(0);
            this.casesSearch.Name = "casesSearch";
            this.casesSearch.Size = new System.Drawing.Size(395, 30);
            this.casesSearch.TabIndex = 0;
            this.casesSearch.TextChanged += new System.EventHandler(this.casesSearch_TextChanged);
            // 
            // searchlbl
            // 
            this.searchlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchlbl.AutoSize = true;
            this.searchlbl.ForeColor = System.Drawing.Color.White;
            this.searchlbl.Location = new System.Drawing.Point(566, 0);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(162, 36);
            this.searchlbl.TabIndex = 1;
            this.searchlbl.Text = "Arama:";
            this.searchlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // caseslbl
            // 
            this.caseslbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.caseslbl.AutoSize = true;
            this.caseslbl.ForeColor = System.Drawing.Color.White;
            this.caseslbl.Location = new System.Drawing.Point(3, 0);
            this.caseslbl.Name = "caseslbl";
            this.caseslbl.Size = new System.Drawing.Size(74, 36);
            this.caseslbl.TabIndex = 2;
            this.caseslbl.Text = "Davalar";
            this.caseslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quickLookView
            // 
            this.quickLookView.Controls.Add(this.quickLookTable);
            this.quickLookView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickLookView.Location = new System.Drawing.Point(0, 0);
            this.quickLookView.Name = "quickLookView";
            this.quickLookView.Size = new System.Drawing.Size(1126, 720);
            this.quickLookView.TabIndex = 0;
            // 
            // quickLookTable
            // 
            this.quickLookTable.ColumnCount = 1;
            this.quickLookTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.quickLookTable.Controls.Add(this.quickLookDataGrid, 0, 1);
            this.quickLookTable.Controls.Add(this.quickLooklbl, 0, 0);
            this.quickLookTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickLookTable.Location = new System.Drawing.Point(0, 0);
            this.quickLookTable.Name = "quickLookTable";
            this.quickLookTable.RowCount = 2;
            this.quickLookTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.quickLookTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.quickLookTable.Size = new System.Drawing.Size(1126, 720);
            this.quickLookTable.TabIndex = 0;
            // 
            // quickLookDataGrid
            // 
            this.quickLookDataGrid.AllowUserToAddRows = false;
            this.quickLookDataGrid.AllowUserToDeleteRows = false;
            this.quickLookDataGrid.AllowUserToOrderColumns = true;
            this.quickLookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quickLookDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickLookDataGrid.Location = new System.Drawing.Point(3, 39);
            this.quickLookDataGrid.Name = "quickLookDataGrid";
            this.quickLookDataGrid.ReadOnly = true;
            this.quickLookDataGrid.Size = new System.Drawing.Size(1120, 678);
            this.quickLookDataGrid.TabIndex = 3;
            // 
            // quickLooklbl
            // 
            this.quickLooklbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quickLooklbl.AutoSize = true;
            this.quickLooklbl.ForeColor = System.Drawing.Color.White;
            this.quickLooklbl.Location = new System.Drawing.Point(3, 0);
            this.quickLooklbl.Name = "quickLooklbl";
            this.quickLooklbl.Size = new System.Drawing.Size(1120, 36);
            this.quickLooklbl.TabIndex = 2;
            this.quickLooklbl.Text = "Hızlı Bakış";
            this.quickLooklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.quickLookBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.casesBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.caseAddBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.logoutBtn, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 720);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // quickLookBtn
            // 
            this.quickLookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickLookBtn.Location = new System.Drawing.Point(3, 3);
            this.quickLookBtn.Name = "quickLookBtn";
            this.quickLookBtn.Size = new System.Drawing.Size(144, 174);
            this.quickLookBtn.TabIndex = 0;
            this.quickLookBtn.Text = "Hızlı Bakış";
            this.quickLookBtn.UseVisualStyleBackColor = true;
            this.quickLookBtn.Click += new System.EventHandler(this.quickLookButton_Click);
            // 
            // casesBtn
            // 
            this.casesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.casesBtn.Location = new System.Drawing.Point(3, 183);
            this.casesBtn.Name = "casesBtn";
            this.casesBtn.Size = new System.Drawing.Size(144, 174);
            this.casesBtn.TabIndex = 1;
            this.casesBtn.Text = "Davalar";
            this.casesBtn.UseVisualStyleBackColor = true;
            this.casesBtn.Click += new System.EventHandler(this.cases_Click);
            // 
            // caseAddBtn
            // 
            this.caseAddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caseAddBtn.Location = new System.Drawing.Point(3, 363);
            this.caseAddBtn.Name = "caseAddBtn";
            this.caseAddBtn.Size = new System.Drawing.Size(144, 174);
            this.caseAddBtn.TabIndex = 2;
            this.caseAddBtn.Text = "Dava Ekle";
            this.caseAddBtn.UseVisualStyleBackColor = true;
            this.caseAddBtn.Click += new System.EventHandler(this.caseAddBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutBtn.Location = new System.Drawing.Point(3, 543);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(144, 174);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Çıkış Yap";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logout_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.ayirici);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kapatma);
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ayirici.Panel1.ResumeLayout(false);
            this.ayirici.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ayirici)).EndInit();
            this.ayirici.ResumeLayout(false);
            this.casesView.ResumeLayout(false);
            this.casesTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.casesDataGrid)).EndInit();
            this.casesInnerPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.quickLookView.ResumeLayout(false);
            this.quickLookTable.ResumeLayout(false);
            this.quickLookTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quickLookDataGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ayirici;
        private System.Windows.Forms.Panel quickLookView;
        private System.Windows.Forms.TableLayoutPanel quickLookTable;
        private System.Windows.Forms.Panel casesView;
        private System.Windows.Forms.TableLayoutPanel casesTable;
        private System.Windows.Forms.Label quickLooklbl;
        private System.Windows.Forms.DataGridView quickLookDataGrid;
        private System.Windows.Forms.DataGridView casesDataGrid;
        private System.Windows.Forms.Panel casesInnerPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox casesSearch;
        private System.Windows.Forms.Label searchlbl;
        private System.Windows.Forms.Label caseslbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button quickLookBtn;
        private System.Windows.Forms.Button casesBtn;
        private System.Windows.Forms.Button caseAddBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}