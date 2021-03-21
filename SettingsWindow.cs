using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicBeePlugin
{
    public partial class SettingsWindow : Form
    {
        private readonly Plugin plugin;
        private readonly Settings settings;

        public SettingsWindow(Plugin plugin, Settings settings)
        {
            this.plugin = plugin;
            this.settings = settings;

            InitializeComponent();
        }

        private void OnShown(object sender, EventArgs eventArgs)
        {
            requestMethodComboBox.Text = settings.RequestMethod;
            requestUriTextBox.Text = settings.RequestUri;
            mediaTypeComboBox.Text = settings.MediaType;
            contentTextBox.Text = settings.Content;

            var fields = new Dictionary<string, string>{
                { "property:Bitrate", "Bitrate" },
                { "property:Channels", "Channels" },
                { "property:Duration", "Duration" },
                { "property:Format", "Format" },
                { "property:Kind", "Kind" },
                { "property:SampleRate", "Sample Rate" },
                { "property:Size", "Size" },
                { "property:Status", "Status" },
                { "property:Url", "Url" },

                { "tag:Album", "Album" },
                { "tag:AlbumArtist", "Album Artist" },
                { "tag:Artist", "Artist" },
                { "tag:Artwork", "Artwork" },
                { "tag:BeatsPerMin", "Beats Per Minute" },
                { "tag:Composer", "Composer" },
                { "tag:Comment", "Comment" },
                { "tag:DiscNo", "Disc Number" },
                { "tag:DiscCount", "Disc Count" },
                { "tag:Encoder", "Encoder" },
                { "tag:Genre", "Genre" },
                { "tag:TrackCount", "Track Count" },
                { "tag:TrackNo", "Track Number" },
                { "tag:TrackTitle", "Track Title" },
                { "tag:Year", "Year" },
            };

            foreach (var field in fields)
            {
                var button = new Button
                {
                    Dock = DockStyle.Top,
                    Tag = field.Key,
                    Text = field.Value,
                };

                button.Click += OnFieldClick;

                fieldsPanel.Controls.Add(button);
            }

            foreach (var pair in settings.Headers)
                headersDataGridView.Rows.Add(new string[] { pair.Key, pair.Value });
        }

        private void OnSave(object sender, EventArgs e)
        {
            var headers = new Dictionary<string, string>();

            foreach (DataGridViewRow row in headersDataGridView.Rows)
            {
                var name = $"{row.Cells[0].Value}";
                var value = $"{row.Cells[1].Value}";

                if (string.IsNullOrEmpty(name))
                    continue;

                headers.Add(name, value);
            }

            settings.RequestMethod = requestMethodComboBox.Text;
            settings.RequestUri = requestUriTextBox.Text;
            settings.MediaType = mediaTypeComboBox.Text;
            settings.Content = contentTextBox.Text;
            settings.Headers = headers;

            settings.Save();

            Close();
        }

        private void OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            headersDataGridView.Rows[e.RowIndex].Tag = e.Value;

            if (e.ColumnIndex == 1 && e.Value != null)
                e.Value = new string('\u25CF', e.Value.ToString().Length);
        }

        private void OnEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var tag = headersDataGridView.CurrentRow.Tag;

            if (tag != null)
                e.Control.Text = tag.ToString();
        }

        private void OnFieldClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            var fieldName = $"{{{button.Tag}}}";

            contentTextBox.Text = contentTextBox.Text.Insert(contentTextBox.SelectionStart, fieldName);
        }
    }
}
