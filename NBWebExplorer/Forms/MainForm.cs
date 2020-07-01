using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using NBWebExplorer.Properties;

namespace NBWebExplorer
{
    public partial class MainForm : Form
    {
        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Methods

        #region MainForm

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Width * 0.80), Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Height * 0.80));

            openNewWebBrowserTabPage(0, null);

            homeToolStripButton.PerformClick();
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            openNewWebBrowserTabPage(mainTabControl.TabCount - 1, String.Empty);

            urlToolStripComboBox.Focus();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                String[] files = e.Data.GetData(DataFormats.FileDrop) as String[];

                if (files != null && files.Length > 0)
                {
                    urlToolStripComboBox.Text = DataHelper.RegexCollection.UrlShortcutRegex.Match(File.ReadAllText(files[0])).Groups["URL"].Value;
                }
                else
                {
                    urlToolStripComboBox.Text = e.Data.GetData(DataFormats.Text).ToString();
                }

                webBrowserTabPage.Navigate(urlToolStripComboBox.Text, true);
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            // AutoSize: urlToolStripComboBox

            Int32 leftX = mainToolStrip.Location.X;
            Int32 rightX = leftX + mainToolStrip.Size.Width;

            foreach (ToolStripItem item in mainToolStrip.Items)
            {
                if (item != urlToolStripComboBox)
                {
                    leftX += item.Size.Width;
                }
                else
                {
                    break;
                }
            }

            for (Int32 i = mainToolStrip.Items.Count - 1; i > 0; i--)
            {
                if (mainToolStrip.Items[i] != urlToolStripComboBox)
                {
                    rightX -= mainToolStrip.Items[i].Size.Width;
                }
                else
                {
                    break;
                }
            }

            urlToolStripComboBox.Size = new Size(rightX - leftX - 5, urlToolStripComboBox.Size.Height);

            //AutoSize: mainTabControl.TabPages

            foreach (TabPage page in mainTabControl.TabPages)
            {
                WebBrowserTabPage webBrowserTabPage = page as WebBrowserTabPage;

                if (webBrowserTabPage != null)
                {
                    resizeWebBrowserTabPage(webBrowserTabPage);
                }
            }
        }

        #endregion

        #region mainToolStrip

        private void mainToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                if (e.ClickedItem == backToolStripButton)
                {
                    webBrowserTabPage.Browser.GoBack();
                }
                else if (e.ClickedItem == forwardToolStripButton)
                {
                    webBrowserTabPage.Browser.GoForward();
                }
                else if (e.ClickedItem == refreshToolStripButton)
                {
                    webBrowserTabPage.Browser.Refresh();
                }
                else if (e.ClickedItem == homeToolStripButton)
                {
                    webBrowserTabPage.Browser.GoHome();
                }
            }
        }

        private void mainToolStrip_ButtonClick(object sender, EventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                if (sender == favoritesToolStripSpiltButton)
                {
                    addToFavoritesToolStripMenuItem.PerformClick();
                }
                else if (sender == pageSwitchToolStripSpiltButton)
                {
                    if (!webBrowserTabPage.IsBusy)
                    {
                        openToolStripMenuItem.PerformClick();
                    }
                    else
                    {
                        stopToolStripMenuItem.PerformClick();
                    }
                }
            }
        }

        private void historyListToolStripDropDownButton_DropDownOpening(object sender, EventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                historyListToolStripDropDownButton.DropDownItems.Clear();

                foreach (KeyValuePair<String, String> pair in webBrowserTabPage.HistoryList)
                {
                    historyListToolStripDropDownButton.DropDownItems.Insert(0, createURLToolStripMenuItem(pair.Value, pair.Key, Resources.Link));

                    ToolStripMenuItem menuItem = historyListToolStripDropDownButton.DropDownItems[0] as ToolStripMenuItem;

                    menuItem.Checked = (menuItem.Text == webBrowserTabPage.Title);
                }
            }
        }

        private void historyListToolStripDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem historyToolStripMenuItem = e.ClickedItem as ToolStripMenuItem;
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (historyToolStripMenuItem != null && webBrowserTabPage != null)
            {
                if (historyToolStripMenuItem.Checked)
                {
                    refreshToolStripButton.PerformClick();
                }
                else
                {
                    foreach (ToolStripMenuItem item in historyListToolStripDropDownButton.DropDownItems)
                    {
                        item.Checked = (item == historyToolStripMenuItem);
                    }

                    urlToolStripComboBox.Text = historyToolStripMenuItem.Tag.ToString();
                    webBrowserTabPage.Navigate(urlToolStripComboBox.Text, false);
                }
            }
        }

        private void favoritesToolStripSpiltButton_DropDownOpening(object sender, EventArgs e)
        {
            favoritesToolStripSpiltButton.DropDownItems.Remove(addToFavoritesToolStripMenuItem);
            favoritesToolStripSpiltButton.DropDownItems.Remove(organizeFavoritesToolStripMenuItem);
            favoritesToolStripSpiltButton.DropDownItems.Remove(organizeFavoritesToolStripSeparator);

            favoritesToolStripSpiltButton.DropDownItems.Clear();

            addFavoritesToolStripItems(favoritesToolStripSpiltButton.DropDownItems, Environment.GetFolderPath(Environment.SpecialFolder.Favorites));

            favoritesToolStripSpiltButton.DropDownItems.Insert(0, organizeFavoritesToolStripSeparator);
            favoritesToolStripSpiltButton.DropDownItems.Insert(0, organizeFavoritesToolStripMenuItem);
            favoritesToolStripSpiltButton.DropDownItems.Insert(0, addToFavoritesToolStripMenuItem);
        }

        private void favoritesToolStripSpiltButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem menuItem = e.ClickedItem as ToolStripMenuItem;

            if (menuItem != null && menuItem.DropDownItems.Count == 0)
            {
                favoritesToolStripSpiltButton.HideDropDown();
            }

            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                if (e.ClickedItem == addToFavoritesToolStripMenuItem)
                {
                    WinAPIHelper.InvokeCommandByMessage(2, WinAPIHelper.Messages.ID_IE_CONTEXTMENU_ADDFAV, webBrowserTabPage);
                }
                else if (e.ClickedItem == organizeFavoritesToolStripMenuItem)
                {
                    using (Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Favorites))) { }
                }
                else if (e.ClickedItem.Tag != null)
                {
                    urlToolStripComboBox.Text = e.ClickedItem.Tag.ToString();

                    webBrowserTabPage.Navigate(urlToolStripComboBox.Text, true);
                }
            }
        }

        private void pageSwitchToolStripSpiltButton_DropDownOpening(object sender, EventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                stopToolStripMenuItem.Enabled = webBrowserTabPage.IsBusy;
            }
        }

        private void pageSwitchToolStripSpiltButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                if (e.ClickedItem == openToolStripMenuItem)
                {
                    if (!String.IsNullOrEmpty(urlToolStripComboBox.Text))
                    {
                        if (!urlToolStripComboBox.Items.Contains(urlToolStripComboBox.Text))
                        {
                            urlToolStripComboBox.Items.Add(urlToolStripComboBox.Text);
                        }

                        webBrowserTabPage.Navigate(urlToolStripComboBox.Text, true);
                    }
                }
                else if (e.ClickedItem == openInNewTabToolStripMenuItem)
                {
                    openNewWebBrowserTabPage(mainTabControl.SelectedIndex + 1, urlToolStripComboBox.Text);
                }
                else if (e.ClickedItem == searchToolStripMenuItem)
                {
                    urlToolStripComboBox.Text = !String.IsNullOrEmpty(urlToolStripComboBox.Text) ? String.Format("? {0}", urlToolStripComboBox.Text) : "? ";

                    if (urlToolStripComboBox.Text.Length > 2)
                    {
                        openToolStripMenuItem.PerformClick();
                    }
                    else
                    {
                        urlToolStripComboBox.Focus();
                        urlToolStripComboBox.Select(urlToolStripComboBox.Text.Length, 0);
                    }
                }
                else if (e.ClickedItem == stopToolStripMenuItem)
                {
                    webBrowserTabPage.Browser.Stop();
                }
            }
        }

        private void pageToolStripDropDownButton_DropDownOpening(object sender, EventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                findToolStripMenuItem.Enabled = (webBrowserTabPage.Browser.ReadyState != WebBrowserReadyState.Uninitialized);
                saveAsToolStripMenuItem.Enabled = (webBrowserTabPage.Browser.ReadyState != WebBrowserReadyState.Uninitialized);
                sendToToolStripMenuItem.Enabled = (webBrowserTabPage.Browser.ReadyState != WebBrowserReadyState.Uninitialized);
                printToolStripMenuItem.Enabled = (webBrowserTabPage.Browser.ReadyState != WebBrowserReadyState.Uninitialized);
                printPreviewToolStripMenuItem.Enabled = (webBrowserTabPage.Browser.ReadyState != WebBrowserReadyState.Uninitialized);
                pageSetupToolStripMenuItem.Enabled = (webBrowserTabPage.Browser.ReadyState != WebBrowserReadyState.Uninitialized);
                viewSourceToolStripMenuItem.Enabled = (webBrowserTabPage.Browser.ReadyState != WebBrowserReadyState.Uninitialized);
            }
        }

        private void pageToolStripDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem menuItem = e.ClickedItem as ToolStripMenuItem;

            if (menuItem != null && menuItem.DropDownItems.Count == 0)
            {
                pageToolStripDropDownButton.HideDropDown();
            }

            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                if (e.ClickedItem == findToolStripMenuItem)
                {
                    WinAPIHelper.InvokeCommandByMessage(2, WinAPIHelper.Messages.ID_IE_EDIT_FIND, webBrowserTabPage);
                }
                else if (e.ClickedItem == saveAsToolStripMenuItem)
                {
                    webBrowserTabPage.Browser.ShowSaveAsDialog();
                }
                else if (e.ClickedItem == desktopShortcutToolStripMenuItem)
                {
                    WinAPIHelper.InvokeCommandByMessage(1, WinAPIHelper.Messages.ID_IE_FILE_SENDDESKTOPSHORTCUT, webBrowserTabPage);

                    MessageBox.Show(this, String.Format("The shortcut of the following page has been created on desktop:{0}{0}{1}", Environment.NewLine, webBrowserTabPage.Title), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (e.ClickedItem == printToolStripMenuItem)
                {
                    webBrowserTabPage.Browser.ShowPrintDialog();
                }
                else if (e.ClickedItem == printPreviewToolStripMenuItem)
                {
                    webBrowserTabPage.Browser.ShowPrintPreviewDialog();
                }
                else if (e.ClickedItem == pageSetupToolStripMenuItem)
                {
                    webBrowserTabPage.Browser.ShowPageSetupDialog();
                }
                else if (e.ClickedItem == viewSourceToolStripMenuItem)
                {
                    WinAPIHelper.InvokeCommandByMessage(2, WinAPIHelper.Messages.ID_IE_CONTEXTMENU_VIEWSOURCE, webBrowserTabPage);
                }
            }
        }

        private void toolsToolStripDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem menuItem = e.ClickedItem as ToolStripMenuItem;

            if (menuItem != null && menuItem.DropDownItems.Count == 0)
            {
                toolsToolStripDropDownButton.HideDropDown();
            }

            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                if (e.ClickedItem == importExportToolStripMenuItem)
                {
                    WinAPIHelper.InvokeCommandByMessage(1, WinAPIHelper.Messages.ID_IE_FILE_IMPORTEXPORT, webBrowserTabPage);
                }
                else if (e.ClickedItem == optionsToolStripMenuItem)
                {
                    WinAPIHelper.InvokeCommandByMessage(2, WinAPIHelper.Messages.ID_IE_VIEW_OPTIONS, webBrowserTabPage);
                }
                else if (e.ClickedItem == aboutToolStripMenuItem)
                {
                    using (AboutBox aboutBox = new AboutBox(webBrowserTabPage))
                    {
                        aboutBox.ShowDialog(this);
                    }
                }
            }
        }

        private void urlToolStripComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                switch ((Int32)e.KeyChar)
                {
                    case 13:
                        {
                            e.Handled = true;

                            openToolStripMenuItem.PerformClick();

                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

        private void urlToolStripComboBox_DropDown(object sender, EventArgs e)
        {
            urlToolStripComboBox.SelectAll();
        }

        private void urlToolStripComboBox_Enter(object sender, EventArgs e)
        {
            urlToolStripComboBox.DroppedDown = true;
        }

        private void urlToolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            pageSwitchToolStripSpiltButton.ToolTipText = !urlToolStripComboBox.Text.StartsWith("? ") ? String.Format(openToolStripMenuItem.Tag.ToString(), urlToolStripComboBox.Text) : String.Format(searchToolStripMenuItem.Tag.ToString(), urlToolStripComboBox.Text.Remove(0, 2));

            if (String.IsNullOrEmpty(urlToolStripComboBox.Text) || urlToolStripComboBox.Text == "? ")
            {
                pageSwitchToolStripSpiltButton.ToolTipText = pageSwitchToolStripSpiltButton.ToolTipText.Replace(@"""", String.Empty).Trim();
            }
        }

        #endregion

        #region mainTabControl

        private void mainTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = e.TabPage as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                checkWebBrowserTabPageStatus(webBrowserTabPage, false);
            }
            else
            {
                openNewWebBrowserTabPage(mainTabControl.TabCount - 1, null);
            }
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                webBrowserTabPage.Browser.Focus();
            }
        }

        private void mainTabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null && mainTabControl.TabCount > 2)
            {
                closeWebBrowserTabPage(webBrowserTabPage);
            }
        }

        private void tabControlContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = mainTabControl.GetTabRect(mainTabControl.TabCount - 1).Contains(mainTabControl.PointToClient(Control.MousePosition));

            for (Int32 i = 0; i < mainTabControl.TabCount - 1; i++)
            {
                if (mainTabControl.GetTabRect(i).Contains(mainTabControl.PointToClient(Control.MousePosition)))
                {
                    tabControlContextMenuStrip.Tag = mainTabControl.TabPages[i];

                    closeToolStripMenuItem.Enabled = (mainTabControl.TabCount != 2);
                    closeOtherTabsToolStripMenuItem.Enabled = (mainTabControl.TabCount != 2);
                    closeTabsOnTheLeftToolStripMenuItem.Enabled = (i != 0);
                    closeTabsOnTheRightToolStripMenuItem.Enabled = (i != mainTabControl.TabCount - 2);

                    break;
                }
            }
        }

        private void tabControlContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = tabControlContextMenuStrip.Tag as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                if (e.ClickedItem == closeToolStripMenuItem)
                {
                    closeWebBrowserTabPage(webBrowserTabPage);
                }
                else if (e.ClickedItem == closeTabsOnTheLeftToolStripMenuItem)
                {
                    Int32 webBrowserTabPageIndex = mainTabControl.TabPages.IndexOf(webBrowserTabPage);

                    for (Int32 i = 0; i < webBrowserTabPageIndex; i++)
                    {
                        closeWebBrowserTabPage(mainTabControl.TabPages[0]);
                    }
                }
                else if (e.ClickedItem == closeTabsOnTheRightToolStripMenuItem)
                {
                    Int32 webBrowserTabPageIndex = mainTabControl.TabPages.IndexOf(webBrowserTabPage);

                    for (Int32 i = mainTabControl.TabCount - 2; i > webBrowserTabPageIndex; i--)
                    {
                        closeWebBrowserTabPage(mainTabControl.TabPages[i]);
                    }
                }
                else if (e.ClickedItem == closeOtherTabsToolStripMenuItem)
                {
                    closeTabsOnTheRightToolStripMenuItem.PerformClick();
                    closeTabsOnTheLeftToolStripMenuItem.PerformClick();
                }
                else if (e.ClickedItem == refreshToolStripMenuItem)
                {
                    webBrowserTabPage.Browser.Refresh();
                }
                else if (e.ClickedItem == refreshAllToolStripMenuItem)
                {
                    foreach (TabPage page in mainTabControl.TabPages)
                    {
                        WebBrowserTabPage tabPage = page as WebBrowserTabPage;

                        if (tabPage != null)
                        {
                            tabPage.Browser.Refresh();
                        }
                    }
                }
                else if (e.ClickedItem == newTabToolStripMenuItem)
                {
                    openNewWebBrowserTabPage(mainTabControl.TabPages.IndexOf(webBrowserTabPage) + 1, null);

                    urlToolStripComboBox.Focus();
                }
                else if (e.ClickedItem == repeatTabToolStripMenuItem)
                {
                    openNewWebBrowserTabPage(mainTabControl.TabPages.IndexOf(webBrowserTabPage) + 1, webBrowserTabPage.Browser.Url.OriginalString);
                }
            }
        }

        #endregion

        #region webBrowser

        private void webBrowser_IsBusyDetection(object sender, EventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                pageSwitchToolStripSpiltButton.Image = !webBrowserTabPage.IsBusy ? Resources.Forward : Resources.Stop;
            }
        }

        private void webBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null && webBrowserTabPage.Browser.Document != null)
            {
                String url = !String.IsNullOrEmpty(webBrowserTabPage.Browser.Document.ActiveElement.GetAttribute("href")) ? webBrowserTabPage.Browser.Document.ActiveElement.GetAttribute("href") : webBrowserTabPage.Browser.Document.ActiveElement.GetElementsByTagName("a")[0].GetAttribute("href");

                openNewWebBrowserTabPage(mainTabControl.SelectedIndex + 1, url);
            }

            e.Cancel = true;
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                if (!urlToolStripComboBox.Focused)
                {
                    urlToolStripComboBox.Text = webBrowserTabPage.Browser.Url.OriginalString;
                }

                checkWebBrowserTabPageStatus(webBrowserTabPage, true);
            }
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                mainToolStripProgressBar.Visible = webBrowserTabPage.IsBusy;
                mainToolStripProgressBar.Maximum = (Int32)e.MaximumProgress;
                mainToolStripProgressBar.Value = (Int32)e.CurrentProgress;

                webBrowser_IsBusyDetection(sender, e);
            }
        }

        private void webBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                mainToolStripStatusLabel.Text = webBrowserTabPage.Browser.StatusText;

                mainStatusStrip.Visible = !String.IsNullOrEmpty(mainToolStripStatusLabel.Text);
            }
        }

        private void webBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            WebBrowserTabPage webBrowserTabPage = mainTabControl.SelectedTab as WebBrowserTabPage;

            if (webBrowserTabPage != null)
            {
                this.Text = String.Format("{0} - {1}", webBrowserTabPage.Title, this.ProductName);

                resizeWebBrowserTabPage(webBrowserTabPage);
            }
        }

        #endregion

        #endregion

        #region Helper Methods

        private void openNewWebBrowserTabPage(Int32 index, String url)
        {
            WebBrowserTabPage webBrowserTabPage = new WebBrowserTabPage("Loading...");

            webBrowserTabPage.Browser.Navigating += webBrowser_IsBusyDetection;
            webBrowserTabPage.Browser.DocumentCompleted += webBrowser_IsBusyDetection;

            webBrowserTabPage.Browser.NewWindow += webBrowser_NewWindow;
            webBrowserTabPage.Browser.Navigated += webBrowser_Navigated;
            webBrowserTabPage.Browser.ProgressChanged += webBrowser_ProgressChanged;
            webBrowserTabPage.Browser.StatusTextChanged += webBrowser_StatusTextChanged;
            webBrowserTabPage.Browser.DocumentTitleChanged += webBrowser_DocumentTitleChanged;

            mainTabControl.TabPages.Insert(index, webBrowserTabPage);
            mainTabControl.SelectedTab = webBrowserTabPage;

            urlToolStripComboBox.Text = url;

            if (!String.IsNullOrEmpty(url))
            {
                webBrowserTabPage.Navigate(urlToolStripComboBox.Text, false);
            }
            else
            {
                urlToolStripComboBox.Focus();
            }

            MainForm_SizeChanged(null, EventArgs.Empty);
        }

        private void closeWebBrowserTabPage(TabPage tabPage)
        {
            if (mainTabControl.TabPages.Contains(tabPage))
            {
                // If specified tab page is the current selected tab page, try to move to right tab once closed
                // (But if the current selected tab page is the rightmost, move to left, and skip <New> tab)

                Int32 nextIndex = (tabPage == mainTabControl.SelectedTab) ?
                    ((mainTabControl.SelectedIndex < mainTabControl.TabCount - 2) ? mainTabControl.SelectedIndex : mainTabControl.SelectedIndex - 1)
                     : mainTabControl.SelectedIndex;

                mainTabControl.TabPages.Remove(tabPage);

                mainTabControl.SelectedIndex = nextIndex;

                MainForm_SizeChanged(null, EventArgs.Empty);
            }

            tabPage.Dispose();
        }

        private void checkWebBrowserTabPageStatus(WebBrowserTabPage webBrowserTabPage, Boolean isMainToolStripOnly)
        {
            WebBrowser webBrowser = webBrowserTabPage.Controls[0] as WebBrowser;

            if (webBrowser != null)
            {
                backToolStripButton.Enabled = webBrowser.CanGoBack;
                forwardToolStripButton.Enabled = webBrowser.CanGoForward;
                historyListToolStripDropDownButton.Enabled = webBrowser.CanGoBack || webBrowser.CanGoForward;

                if (!isMainToolStripOnly)
                {
                    this.Text = String.Format("{0} - {1}", webBrowserTabPage.Title, this.ProductName);

                    urlToolStripComboBox.Text = (webBrowser.Url != null) ? webBrowser.Url.OriginalString : String.Empty;

                    mainToolStripStatusLabel.Text = webBrowser.StatusText;

                    mainToolStripProgressBar.Visible = webBrowserTabPage.IsBusy;
                }
            }
        }

        private void resizeWebBrowserTabPage(WebBrowserTabPage webBrowserTabPage)
        {
            Int32 width = mainTabControl.Size.Width;
            String title = webBrowserTabPage.Title;
            Int32 titleLength = (width / 100 - mainTabControl.TabCount) * ((width / 100));

            titleLength = titleLength <= 0 ? 5 : titleLength;

            webBrowserTabPage.Text = title.Length > titleLength ? title.Substring(0, titleLength) + "..." : title;
        }

        private void addFavoritesToolStripItems(ToolStripItemCollection itemCollection, String favPath)
        {
            String[] entries = Directory.GetDirectories(favPath);

            if (entries.Length > 0)
            {
                foreach (String linkDirectory in entries)
                {
                    ToolStripMenuItem menuItem = createURLToolStripMenuItem(Path.GetFileNameWithoutExtension(linkDirectory), null, Resources.Folder);

                    menuItem.DropDownItemClicked += favoritesToolStripSpiltButton_DropDownItemClicked;

                    itemCollection.Add(menuItem);

                    addFavoritesToolStripItems(menuItem.DropDownItems, linkDirectory);
                }
            }

            entries = Directory.GetFiles(favPath, "*.url", SearchOption.TopDirectoryOnly);

            if (entries.Length > 0)
            {
                foreach (String linkPath in entries)
                {
                    String url = DataHelper.RegexCollection.UrlShortcutRegex.Match(File.ReadAllText(linkPath)).Groups["URL"].Value;

                    ToolStripMenuItem menuItem = createURLToolStripMenuItem(Path.GetFileNameWithoutExtension(linkPath), url, Resources.Link);

                    itemCollection.Add(menuItem);
                }
            }
        }

        private ToolStripMenuItem createURLToolStripMenuItem(String title, String url, Image image)
        {
            ToolStripMenuItem urlToolStripMenuItem = new ToolStripMenuItem(title);

            urlToolStripMenuItem.Tag = url;
            urlToolStripMenuItem.ToolTipText = url;
            urlToolStripMenuItem.Image = image;

            return urlToolStripMenuItem;
        }

        #endregion
    }
}