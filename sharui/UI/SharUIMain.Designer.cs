namespace sharui.UI
{
    partial class SharUIMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharUIMain));
            this.appMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.appStatus = new System.Windows.Forms.StatusStrip();
            this.itemsCounterLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.actionBar = new System.Windows.Forms.Panel();
            this.tview = new System.Windows.Forms.TreeView();
            this.gnome_images_small = new System.Windows.Forms.ImageList(this.components);
            this.explorerIconsView = new System.Windows.Forms.ListView();
            this.navButtons = new System.Windows.Forms.Panel();
            this.backNavBtn = new System.Windows.Forms.Button();
            this.fwdNavButton = new System.Windows.Forms.Button();
            this.appStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.actionBar.SuspendLayout();
            this.navButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // appMenu
            // 
            this.appMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem9});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem8});
            this.menuItem1.Text = "&File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "&New";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "&Open";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "&Save";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "Save &As";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 5;
            this.menuItem7.Text = "-";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 6;
            this.menuItem8.Text = "E&xit";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10});
            this.menuItem9.Text = "&Help";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.Text = "&About";
            // 
            // appStatus
            // 
            this.appStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsCounterLabel});
            this.appStatus.Location = new System.Drawing.Point(0, 428);
            this.appStatus.Name = "appStatus";
            this.appStatus.Size = new System.Drawing.Size(800, 22);
            this.appStatus.TabIndex = 0;
            this.appStatus.Text = "statusStrip1";
            // 
            // itemsCounterLabel
            // 
            this.itemsCounterLabel.Name = "itemsCounterLabel";
            this.itemsCounterLabel.Size = new System.Drawing.Size(45, 17);
            this.itemsCounterLabel.Text = "0 items";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 22);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tview);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.explorerIconsView);
            this.splitContainer.Size = new System.Drawing.Size(800, 406);
            this.splitContainer.SplitterDistance = 206;
            this.splitContainer.TabIndex = 1;
            // 
            // actionBar
            // 
            this.actionBar.Controls.Add(this.navButtons);
            this.actionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionBar.Location = new System.Drawing.Point(0, 0);
            this.actionBar.Name = "actionBar";
            this.actionBar.Size = new System.Drawing.Size(800, 22);
            this.actionBar.TabIndex = 2;
            // 
            // tview
            // 
            this.tview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tview.Location = new System.Drawing.Point(0, 0);
            this.tview.Name = "tview";
            this.tview.Size = new System.Drawing.Size(206, 406);
            this.tview.TabIndex = 0;
            // 
            // gnome_images_small
            // 
            this.gnome_images_small.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("gnome_images_small.ImageStream")));
            this.gnome_images_small.TransparentColor = System.Drawing.Color.Transparent;
            this.gnome_images_small.Images.SetKeyName(0, "doc");
            this.gnome_images_small.Images.SetKeyName(1, "xls");
            this.gnome_images_small.Images.SetKeyName(2, "ppt");
            this.gnome_images_small.Images.SetKeyName(3, "bmp");
            this.gnome_images_small.Images.SetKeyName(4, "gif");
            this.gnome_images_small.Images.SetKeyName(5, "jpeg");
            this.gnome_images_small.Images.SetKeyName(6, "png");
            this.gnome_images_small.Images.SetKeyName(7, "svg");
            this.gnome_images_small.Images.SetKeyName(8, "tiff");
            this.gnome_images_small.Images.SetKeyName(9, "wmf");
            this.gnome_images_small.Images.SetKeyName(10, "html");
            this.gnome_images_small.Images.SetKeyName(11, "lnk");
            this.gnome_images_small.Images.SetKeyName(12, "inaccessible");
            this.gnome_images_small.Images.SetKeyName(13, "file");
            this.gnome_images_small.Images.SetKeyName(14, "htmlfile");
            this.gnome_images_small.Images.SetKeyName(15, "script");
            this.gnome_images_small.Images.SetKeyName(16, "readme");
            this.gnome_images_small.Images.SetKeyName(17, "special_folder");
            this.gnome_images_small.Images.SetKeyName(18, "folder");
            this.gnome_images_small.Images.SetKeyName(19, "folder_open");
            this.gnome_images_small.Images.SetKeyName(20, "music");
            // 
            // explorerIconsView
            // 
            this.explorerIconsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerIconsView.HideSelection = false;
            this.explorerIconsView.Location = new System.Drawing.Point(0, 0);
            this.explorerIconsView.Name = "explorerIconsView";
            this.explorerIconsView.Size = new System.Drawing.Size(590, 406);
            this.explorerIconsView.TabIndex = 0;
            this.explorerIconsView.UseCompatibleStateImageBehavior = false;
            // 
            // navButtons
            // 
            this.navButtons.Controls.Add(this.fwdNavButton);
            this.navButtons.Controls.Add(this.backNavBtn);
            this.navButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.navButtons.Location = new System.Drawing.Point(0, 0);
            this.navButtons.Name = "navButtons";
            this.navButtons.Size = new System.Drawing.Size(44, 22);
            this.navButtons.TabIndex = 0;
            // 
            // backNavBtn
            // 
            this.backNavBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backNavBtn.Image = global::sharui.Properties.Resources.stock_left;
            this.backNavBtn.Location = new System.Drawing.Point(0, 0);
            this.backNavBtn.Name = "backNavBtn";
            this.backNavBtn.Size = new System.Drawing.Size(22, 22);
            this.backNavBtn.TabIndex = 0;
            this.backNavBtn.UseVisualStyleBackColor = true;
            // 
            // fwdNavButton
            // 
            this.fwdNavButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.fwdNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fwdNavButton.Image = global::sharui.Properties.Resources.stock_right;
            this.fwdNavButton.Location = new System.Drawing.Point(22, 0);
            this.fwdNavButton.Name = "fwdNavButton";
            this.fwdNavButton.Size = new System.Drawing.Size(22, 22);
            this.fwdNavButton.TabIndex = 1;
            this.fwdNavButton.UseVisualStyleBackColor = true;
            // 
            // SharUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.appStatus);
            this.Controls.Add(this.actionBar);
            this.Menu = this.appMenu;
            this.Name = "SharUIMain";
            this.Text = "Untitled - Sharptron Archive (SHAR) Manager";
            this.appStatus.ResumeLayout(false);
            this.appStatus.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.actionBar.ResumeLayout(false);
            this.navButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu appMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.StatusStrip appStatus;
        private System.Windows.Forms.ToolStripStatusLabel itemsCounterLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView tview;
        private System.Windows.Forms.Panel actionBar;
        private System.Windows.Forms.ImageList gnome_images_small;
        private System.Windows.Forms.ListView explorerIconsView;
        private System.Windows.Forms.Panel navButtons;
        private System.Windows.Forms.Button backNavBtn;
        private System.Windows.Forms.Button fwdNavButton;
    }
}