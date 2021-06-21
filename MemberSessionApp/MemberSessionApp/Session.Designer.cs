
namespace MemberSessionApp
{
    partial class Session
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchDataGrid
            // 
            this.SearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDataGrid.Location = new System.Drawing.Point(72, 27);
            this.SearchDataGrid.Name = "SearchDataGrid";
            this.SearchDataGrid.RowTemplate.Height = 25;
            this.SearchDataGrid.Size = new System.Drawing.Size(399, 281);
            this.SearchDataGrid.TabIndex = 5;
            // 
            // Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchDataGrid);
            this.Name = "Session";
            this.Size = new System.Drawing.Size(494, 333);
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchDataGrid;
    }
}
