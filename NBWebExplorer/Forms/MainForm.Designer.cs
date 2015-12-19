namespace NBWebExplorer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.backToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.forwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.historyListToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.navigateToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.homeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.controlToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.favoritesToolStripSpiltButton = new System.Windows.Forms.ToolStripSplitButton();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeFavoritesToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.urlToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.pageSwitchToolStripSpiltButton = new System.Windows.Forms.ToolStripSplitButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInNewTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTabPageToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.pageToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findInPageToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processPageToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPageToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.viewSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.importExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExportToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabControlContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabsOnTheLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabsOnTheRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOtherTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabsToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabPage = new System.Windows.Forms.TabPage();
            this.mainToolStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabControlContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AllowDrop = true;
            this.mainToolStrip.CanOverflow = false;
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripButton,
            this.forwardToolStripButton,
            this.historyListToolStripDropDownButton,
            this.navigateToolStripSeparator,
            this.refreshToolStripButton,
            this.homeToolStripButton,
            this.controlToolStripSeparator,
            this.favoritesToolStripSpiltButton,
            this.urlToolStripComboBox,
            this.pageSwitchToolStripSpiltButton,
            this.urlToolStripSeparator,
            this.pageToolStripDropDownButton,
            this.toolsToolStripDropDownButton});
            resources.ApplyResources(this.mainToolStrip, "mainToolStrip");
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainToolStrip_ItemClicked);
            this.mainToolStrip.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.mainToolStrip.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // backToolStripButton
            // 
            this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.backToolStripButton, "backToolStripButton");
            this.backToolStripButton.Image = global::NBWebExplorer.Properties.Resources.Back;
            this.backToolStripButton.Name = "backToolStripButton";
            this.backToolStripButton.Tag = "Back to {0}";
            // 
            // forwardToolStripButton
            // 
            this.forwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.forwardToolStripButton, "forwardToolStripButton");
            this.forwardToolStripButton.Image = global::NBWebExplorer.Properties.Resources.Forward;
            this.forwardToolStripButton.Name = "forwardToolStripButton";
            this.forwardToolStripButton.Tag = "Forward to {0}";
            // 
            // historyListToolStripDropDownButton
            // 
            this.historyListToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.historyListToolStripDropDownButton, "historyListToolStripDropDownButton");
            this.historyListToolStripDropDownButton.Name = "historyListToolStripDropDownButton";
            this.historyListToolStripDropDownButton.DropDownOpening += new System.EventHandler(this.historyListToolStripDropDownButton_DropDownOpening);
            this.historyListToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.historyListToolStripDropDownButton_DropDownItemClicked);
            // 
            // navigateToolStripSeparator
            // 
            this.navigateToolStripSeparator.Name = "navigateToolStripSeparator";
            resources.ApplyResources(this.navigateToolStripSeparator, "navigateToolStripSeparator");
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshToolStripButton.Image = global::NBWebExplorer.Properties.Resources.Refresh;
            resources.ApplyResources(this.refreshToolStripButton, "refreshToolStripButton");
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            // 
            // homeToolStripButton
            // 
            this.homeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeToolStripButton.Image = global::NBWebExplorer.Properties.Resources.Home;
            resources.ApplyResources(this.homeToolStripButton, "homeToolStripButton");
            this.homeToolStripButton.Name = "homeToolStripButton";
            // 
            // controlToolStripSeparator
            // 
            this.controlToolStripSeparator.Name = "controlToolStripSeparator";
            resources.ApplyResources(this.controlToolStripSeparator, "controlToolStripSeparator");
            // 
            // favoritesToolStripSpiltButton
            // 
            this.favoritesToolStripSpiltButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.favoritesToolStripSpiltButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavoritesToolStripMenuItem,
            this.organizeFavoritesToolStripMenuItem,
            this.organizeFavoritesToolStripSeparator});
            this.favoritesToolStripSpiltButton.Image = global::NBWebExplorer.Properties.Resources.Favorites;
            resources.ApplyResources(this.favoritesToolStripSpiltButton, "favoritesToolStripSpiltButton");
            this.favoritesToolStripSpiltButton.Name = "favoritesToolStripSpiltButton";
            this.favoritesToolStripSpiltButton.ButtonClick += new System.EventHandler(this.mainToolStrip_ButtonClick);
            this.favoritesToolStripSpiltButton.DropDownOpening += new System.EventHandler(this.favoritesToolStripSpiltButton_DropDownOpening);
            this.favoritesToolStripSpiltButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.favoritesToolStripSpiltButton_DropDownItemClicked);
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.Favorites_Small;
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            resources.ApplyResources(this.addToFavoritesToolStripMenuItem, "addToFavoritesToolStripMenuItem");
            // 
            // organizeFavoritesToolStripMenuItem
            // 
            this.organizeFavoritesToolStripMenuItem.Name = "organizeFavoritesToolStripMenuItem";
            resources.ApplyResources(this.organizeFavoritesToolStripMenuItem, "organizeFavoritesToolStripMenuItem");
            // 
            // organizeFavoritesToolStripSeparator
            // 
            this.organizeFavoritesToolStripSeparator.Name = "organizeFavoritesToolStripSeparator";
            resources.ApplyResources(this.organizeFavoritesToolStripSeparator, "organizeFavoritesToolStripSeparator");
            // 
            // urlToolStripComboBox
            // 
            this.urlToolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.urlToolStripComboBox, "urlToolStripComboBox");
            this.urlToolStripComboBox.Name = "urlToolStripComboBox";
            this.urlToolStripComboBox.DropDown += new System.EventHandler(this.urlToolStripComboBox_DropDown);
            this.urlToolStripComboBox.Enter += new System.EventHandler(this.urlToolStripComboBox_Enter);
            this.urlToolStripComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlToolStripComboBox_KeyPress);
            this.urlToolStripComboBox.TextChanged += new System.EventHandler(this.urlToolStripComboBox_TextChanged);
            // 
            // pageSwitchToolStripSpiltButton
            // 
            this.pageSwitchToolStripSpiltButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageSwitchToolStripSpiltButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openInNewTabToolStripMenuItem,
            this.openTabPageToolStripSeparator,
            this.searchToolStripMenuItem,
            this.searchToolStripSeparator,
            this.stopToolStripMenuItem});
            this.pageSwitchToolStripSpiltButton.Image = global::NBWebExplorer.Properties.Resources.Forward;
            resources.ApplyResources(this.pageSwitchToolStripSpiltButton, "pageSwitchToolStripSpiltButton");
            this.pageSwitchToolStripSpiltButton.Name = "pageSwitchToolStripSpiltButton";
            this.pageSwitchToolStripSpiltButton.Tag = "";
            this.pageSwitchToolStripSpiltButton.ButtonClick += new System.EventHandler(this.mainToolStrip_ButtonClick);
            this.pageSwitchToolStripSpiltButton.DropDownOpening += new System.EventHandler(this.pageSwitchToolStripSpiltButton_DropDownOpening);
            this.pageSwitchToolStripSpiltButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pageSwitchToolStripSpiltButton_DropDownItemClicked);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.Forward_Small;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Tag = "Go to {0}";
            // 
            // openInNewTabToolStripMenuItem
            // 
            this.openInNewTabToolStripMenuItem.Name = "openInNewTabToolStripMenuItem";
            resources.ApplyResources(this.openInNewTabToolStripMenuItem, "openInNewTabToolStripMenuItem");
            // 
            // openTabPageToolStripSeparator
            // 
            this.openTabPageToolStripSeparator.Name = "openTabPageToolStripSeparator";
            resources.ApplyResources(this.openTabPageToolStripSeparator, "openTabPageToolStripSeparator");
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.Search_Small;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
            this.searchToolStripMenuItem.Tag = "Search \"{0}\"";
            // 
            // searchToolStripSeparator
            // 
            this.searchToolStripSeparator.Name = "searchToolStripSeparator";
            resources.ApplyResources(this.searchToolStripSeparator, "searchToolStripSeparator");
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.Stop_Small;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            // 
            // urlToolStripSeparator
            // 
            this.urlToolStripSeparator.Name = "urlToolStripSeparator";
            resources.ApplyResources(this.urlToolStripSeparator, "urlToolStripSeparator");
            // 
            // pageToolStripDropDownButton
            // 
            this.pageToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.findInPageToolStripSeparator,
            this.saveAsToolStripMenuItem,
            this.sendToToolStripMenuItem,
            this.processPageToolStripSeparator,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.printPageToolStripSeparator,
            this.viewSourceToolStripMenuItem});
            this.pageToolStripDropDownButton.Image = global::NBWebExplorer.Properties.Resources.Page;
            resources.ApplyResources(this.pageToolStripDropDownButton, "pageToolStripDropDownButton");
            this.pageToolStripDropDownButton.Name = "pageToolStripDropDownButton";
            this.pageToolStripDropDownButton.DropDownOpening += new System.EventHandler(this.pageToolStripDropDownButton_DropDownOpening);
            this.pageToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pageToolStripDropDownButton_DropDownItemClicked);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.Find_Small;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            resources.ApplyResources(this.findToolStripMenuItem, "findToolStripMenuItem");
            // 
            // findInPageToolStripSeparator
            // 
            this.findInPageToolStripSeparator.Name = "findInPageToolStripSeparator";
            resources.ApplyResources(this.findInPageToolStripSeparator, "findInPageToolStripSeparator");
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            // 
            // sendToToolStripMenuItem
            // 
            this.sendToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desktopShortcutToolStripMenuItem});
            this.sendToToolStripMenuItem.Name = "sendToToolStripMenuItem";
            resources.ApplyResources(this.sendToToolStripMenuItem, "sendToToolStripMenuItem");
            this.sendToToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pageToolStripDropDownButton_DropDownItemClicked);
            // 
            // desktopShortcutToolStripMenuItem
            // 
            this.desktopShortcutToolStripMenuItem.Name = "desktopShortcutToolStripMenuItem";
            resources.ApplyResources(this.desktopShortcutToolStripMenuItem, "desktopShortcutToolStripMenuItem");
            // 
            // processPageToolStripSeparator
            // 
            this.processPageToolStripSeparator.Name = "processPageToolStripSeparator";
            resources.ApplyResources(this.processPageToolStripSeparator, "processPageToolStripSeparator");
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.Print_Small;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            resources.ApplyResources(this.pageSetupToolStripMenuItem, "pageSetupToolStripMenuItem");
            // 
            // printPageToolStripSeparator
            // 
            this.printPageToolStripSeparator.Name = "printPageToolStripSeparator";
            resources.ApplyResources(this.printPageToolStripSeparator, "printPageToolStripSeparator");
            // 
            // viewSourceToolStripMenuItem
            // 
            this.viewSourceToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.Source_Small;
            this.viewSourceToolStripMenuItem.Name = "viewSourceToolStripMenuItem";
            resources.ApplyResources(this.viewSourceToolStripMenuItem, "viewSourceToolStripMenuItem");
            // 
            // toolsToolStripDropDownButton
            // 
            this.toolsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importExportToolStripMenuItem,
            this.importExportToolStripSeparator,
            this.optionsToolStripMenuItem,
            this.optionsToolStripSeparator,
            this.aboutToolStripMenuItem});
            this.toolsToolStripDropDownButton.Image = global::NBWebExplorer.Properties.Resources.Tools;
            resources.ApplyResources(this.toolsToolStripDropDownButton, "toolsToolStripDropDownButton");
            this.toolsToolStripDropDownButton.Name = "toolsToolStripDropDownButton";
            this.toolsToolStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolsToolStripDropDownButton_DropDownItemClicked);
            // 
            // importExportToolStripMenuItem
            // 
            this.importExportToolStripMenuItem.Name = "importExportToolStripMenuItem";
            resources.ApplyResources(this.importExportToolStripMenuItem, "importExportToolStripMenuItem");
            // 
            // importExportToolStripSeparator
            // 
            this.importExportToolStripSeparator.Name = "importExportToolStripSeparator";
            resources.ApplyResources(this.importExportToolStripSeparator, "importExportToolStripSeparator");
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // optionsToolStripSeparator
            // 
            this.optionsToolStripSeparator.Name = "optionsToolStripSeparator";
            resources.ApplyResources(this.optionsToolStripSeparator, "optionsToolStripSeparator");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.About_Small;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripStatusLabel,
            this.mainToolStripProgressBar});
            resources.ApplyResources(this.mainStatusStrip, "mainStatusStrip");
            this.mainStatusStrip.Name = "mainStatusStrip";
            // 
            // mainToolStripStatusLabel
            // 
            this.mainToolStripStatusLabel.Name = "mainToolStripStatusLabel";
            resources.ApplyResources(this.mainToolStripStatusLabel, "mainToolStripStatusLabel");
            this.mainToolStripStatusLabel.Spring = true;
            // 
            // mainToolStripProgressBar
            // 
            resources.ApplyResources(this.mainToolStripProgressBar, "mainToolStripProgressBar");
            this.mainToolStripProgressBar.Name = "mainToolStripProgressBar";
            // 
            // mainTabControl
            // 
            this.mainTabControl.ContextMenuStrip = this.tabControlContextMenuStrip;
            this.mainTabControl.Controls.Add(this.newTabPage);
            resources.ApplyResources(this.mainTabControl, "mainTabControl");
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            this.mainTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTabControl_Selecting);
            this.mainTabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainTabControl_MouseDoubleClick);
            // 
            // tabControlContextMenuStrip
            // 
            this.tabControlContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeTabsOnTheLeftToolStripMenuItem,
            this.closeTabsOnTheRightToolStripMenuItem,
            this.closeOtherTabsToolStripMenuItem,
            this.closeTabsToolStripSeparator,
            this.refreshToolStripMenuItem,
            this.refreshAllToolStripMenuItem,
            this.refreshToolStripSeparator,
            this.newTabToolStripMenuItem,
            this.repeatTabToolStripMenuItem});
            this.tabControlContextMenuStrip.Name = "tabControlContextMenuStrip";
            resources.ApplyResources(this.tabControlContextMenuStrip, "tabControlContextMenuStrip");
            this.tabControlContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.tabControlContextMenuStrip_Opening);
            this.tabControlContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tabControlContextMenuStrip_ItemClicked);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            // 
            // closeTabsOnTheLeftToolStripMenuItem
            // 
            this.closeTabsOnTheLeftToolStripMenuItem.Name = "closeTabsOnTheLeftToolStripMenuItem";
            resources.ApplyResources(this.closeTabsOnTheLeftToolStripMenuItem, "closeTabsOnTheLeftToolStripMenuItem");
            // 
            // closeTabsOnTheRightToolStripMenuItem
            // 
            this.closeTabsOnTheRightToolStripMenuItem.Name = "closeTabsOnTheRightToolStripMenuItem";
            resources.ApplyResources(this.closeTabsOnTheRightToolStripMenuItem, "closeTabsOnTheRightToolStripMenuItem");
            // 
            // closeOtherTabsToolStripMenuItem
            // 
            this.closeOtherTabsToolStripMenuItem.Name = "closeOtherTabsToolStripMenuItem";
            resources.ApplyResources(this.closeOtherTabsToolStripMenuItem, "closeOtherTabsToolStripMenuItem");
            // 
            // closeTabsToolStripSeparator
            // 
            this.closeTabsToolStripSeparator.Name = "closeTabsToolStripSeparator";
            resources.ApplyResources(this.closeTabsToolStripSeparator, "closeTabsToolStripSeparator");
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.Refresh_Small;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            // 
            // refreshAllToolStripMenuItem
            // 
            this.refreshAllToolStripMenuItem.Name = "refreshAllToolStripMenuItem";
            resources.ApplyResources(this.refreshAllToolStripMenuItem, "refreshAllToolStripMenuItem");
            // 
            // refreshToolStripSeparator
            // 
            this.refreshToolStripSeparator.Name = "refreshToolStripSeparator";
            resources.ApplyResources(this.refreshToolStripSeparator, "refreshToolStripSeparator");
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Image = global::NBWebExplorer.Properties.Resources.New_Small;
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            resources.ApplyResources(this.newTabToolStripMenuItem, "newTabToolStripMenuItem");
            // 
            // repeatTabToolStripMenuItem
            // 
            this.repeatTabToolStripMenuItem.Name = "repeatTabToolStripMenuItem";
            resources.ApplyResources(this.repeatTabToolStripMenuItem, "repeatTabToolStripMenuItem");
            // 
            // newTabPage
            // 
            resources.ApplyResources(this.newTabPage, "newTabPage");
            this.newTabPage.Name = "newTabPage";
            this.newTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabControlContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton backToolStripButton;
        private System.Windows.Forms.ToolStripSeparator navigateToolStripSeparator;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripButton homeToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton pageToolStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton toolsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripStatusLabel mainToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar mainToolStripProgressBar;
        private System.Windows.Forms.ToolStripComboBox urlToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator urlToolStripSeparator;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.ToolStripSplitButton pageSwitchToolStripSpiltButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInNewTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator controlToolStripSeparator;
        private System.Windows.Forms.TabPage newTabPage;
        private System.Windows.Forms.ContextMenuStrip tabControlContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeOtherTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabsOnTheLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabsOnTheRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator closeTabsToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator refreshToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton favoritesToolStripSpiltButton;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator findInPageToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desktopShortcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator processPageToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator printPageToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator optionsToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator importExportToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem organizeFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator organizeFavoritesToolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator openTabPageToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton forwardToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton historyListToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator searchToolStripSeparator;
    }
}