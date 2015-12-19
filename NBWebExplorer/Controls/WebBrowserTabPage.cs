using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NBWebExplorer
{
    public class WebBrowserTabPage : TabPage
    {
        #region Constructors

        public WebBrowserTabPage()
            : base()
        {
            initializeControls();
        }

        public WebBrowserTabPage(String text)
            : base(text)
        {
            initializeControls();
        }

        #endregion

        #region Fields

        private WebBrowser _browser = new WebBrowser();
        private List<KeyValuePair<String, String>> _historyList = new List<KeyValuePair<String, String>>();
        private Boolean _addToHistoryList = true;

        #endregion

        #region Properties

        public WebBrowser Browser
        {
            get { return _browser; }
        }

        public List<KeyValuePair<String, String>> HistoryList
        {
            get { return _historyList; }
        }

        public String Title
        {
            get { return (_browser.Url != null) ? (!String.IsNullOrEmpty(_browser.DocumentTitle) ? _browser.DocumentTitle : _browser.Url.OriginalString) : "New Tab"; }
        }

        public Boolean IsBusy
        {
            get { return (_browser.ReadyState != WebBrowserReadyState.Complete && _browser.ReadyState != WebBrowserReadyState.Uninitialized); }
        }

        public Version IEVersion
        {
            get { return _browser.Version; }
        }

        #endregion

        #region Methods

        private void initializeControls()
        {
            _browser.Dock = DockStyle.Fill;
            _browser.ScriptErrorsSuppressed = true;

            _browser.DocumentTitleChanged += new EventHandler(WebBrowser_DocumentTitleChanged);

            this.Controls.Add(_browser);
        }

        protected override void Dispose(bool disposing)
        {
            _historyList.Clear();

            _browser.Dispose();

            base.Dispose(disposing);
        }

        private void WebBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.ToolTipText = this.Title;

            this.OnSizeChanged(e);

            if (_addToHistoryList && !Helper.RegexCollection.TitleRegex.IsMatch(this.Title) && !Helper.RegexCollection.UrlRegex.IsMatch(_browser.Url.OriginalString))
            {
                KeyValuePair<String, String> oldPair = new KeyValuePair<String, String>();
                KeyValuePair<String, String> newPair = new KeyValuePair<String, String>(this.Title, _browser.Url.OriginalString);

                foreach (KeyValuePair<String, String> pair in _historyList)
                {
                    if (pair.Value == _browser.Url.OriginalString)
                    {
                        oldPair = pair;

                        break;
                    }
                }

                if (!String.IsNullOrEmpty(oldPair.Value))
                {
                    _historyList.Remove(oldPair);
                }

                _historyList.Add(newPair);
            }
        }

        public void Navigate(String url, Boolean addToHistoryList)
        {
            if (!String.IsNullOrEmpty(url))
            {
                _browser.Navigate(url);
                _browser.Focus();

                _addToHistoryList = addToHistoryList;
            }
        }

        #endregion
    }
}