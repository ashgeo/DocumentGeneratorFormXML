using Document_Generator_From_XML.GeneralClasses;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Document_Generator_From_XML
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : MahApps.Metro.Controls.MetroWindow
    {
        List<ClassTiles> objTileList = new List<ClassTiles>();
        private const string WORD_DOCUMENT_GENERATOR_TILE = "Create Word Document";
        private XmlReader xmlReader;
        private string SelectedTile;
        public TestWindow()
        {
            InitializeComponent();
            xmlReader = new XmlReader();
            SetTileProperties();            
        }
        private void SetTileProperties()
        {
            var ScreenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            objTileList.Add(new ClassTiles { Title = "Generate XML", Color = "Red", Type = "Form", Icon = "F1 M 17,23L 31,23L 31,27L 34,27L 34,30L 37,30L 37,33L 39,33L 39,30L 42,30L 42,27L 45,27L 45,23L 59,23L 59,27L 56,27L 56,30L 53,30L 53,33L 50,33L 50,36L 47,36L 47,40L 50,40L 50,43L 53,43L 53,46L 56,46L 56,49L 59,49L 59,53L 45,53L 45,49L 42,49L 42,46L 39,46L 39,43L 37,43L 37,46L 34,46L 34,49L 31,49L 31,53L 17,53L 17,49L 20,49L 20,46L 23,46L 23,43L 26,43L 26,40L 29,40L 29,36L 26,36L 26,33L 23,33L 23,30L 20,30L 20,27L 17,27L 17,23 Z " });
            objTileList.Add(new ClassTiles { Title = "Create Word Document", Color = "#D2691E", Type = "Form", Icon = "F1 M 38,15.8334L 58.5833,23.75L 58.5833,30.0833L 38,38L 17.4167,30.0833L 17.4166,23.75L 38,15.8334 Z M 58.5833,44.3333L 58.5833,52.25L 38,60.1667L 17.4167,52.25L 17.4167,44.3333L 21.5333,45.9167L 38,52.25L 54.4667,45.9167L 58.5833,44.3333 Z M 58.5833,33.25L 58.5833,41.1667L 38,49.0833L 17.4167,41.1667L 17.4167,33.25L 21.5333,34.8333L 38,41.1667L 54.4666,34.8333L 58.5833,33.25 Z " });
            objTileList.Add(new ClassTiles { Title = "Tile 3", Color = "#1E90FF", Type = "Form", Icon = "F1 M 38,15.8334L 58.5833,23.75L 58.5833,30.0833L 38,38L 17.4167,30.0833L 17.4166,23.75L 38,15.8334 Z M 58.5833,44.3333L 58.5833,52.25L 38,60.1667L 17.4167,52.25L 17.4167,44.3333L 21.5333,45.9167L 38,52.25L 54.4667,45.9167L 58.5833,44.3333 Z M 58.5833,33.25L 58.5833,41.1667L 38,49.0833L 17.4167,41.1667L 17.4167,33.25L 21.5333,34.8333L 38,41.1667L 54.4666,34.8333L 58.5833,33.25 Z " });
            objTileList.Add(new ClassTiles { Title = "Tile 4", Color = "Green", Type = "Form", Icon = "F1 M 38,15.8334L 58.5833,23.75L 58.5833,30.0833L 38,38L 17.4167,30.0833L 17.4166,23.75L 38,15.8334 Z M 58.5833,44.3333L 58.5833,52.25L 38,60.1667L 17.4167,52.25L 17.4167,44.3333L 21.5333,45.9167L 38,52.25L 54.4667,45.9167L 58.5833,44.3333 Z M 58.5833,33.25L 58.5833,41.1667L 38,49.0833L 17.4167,41.1667L 17.4167,33.25L 21.5333,34.8333L 38,41.1667L 54.4666,34.8333L 58.5833,33.25 Z " });
            objTileList.Add(new ClassTiles { Title = "Tile 5", Color = "Green", Type = "Form", Icon = "F1 M 38,15.8334L 58.5833,23.75L 58.5833,30.0833L 38,38L 17.4167,30.0833L 17.4166,23.75L 38,15.8334 Z M 58.5833,44.3333L 58.5833,52.25L 38,60.1667L 17.4167,52.25L 17.4167,44.3333L 21.5333,45.9167L 38,52.25L 54.4667,45.9167L 58.5833,44.3333 Z M 58.5833,33.25L 58.5833,41.1667L 38,49.0833L 17.4167,41.1667L 17.4167,33.25L 21.5333,34.8333L 38,41.1667L 54.4666,34.8333L 58.5833,33.25 Z " });
            objTileList.Add(new ClassTiles { Title = "Tile 6", Color = "#1E90FF", Type = "Form", Icon = "F1 M 38,15.8334L 58.5833,23.75L 58.5833,30.0833L 38,38L 17.4167,30.0833L 17.4166,23.75L 38,15.8334 Z M 58.5833,44.3333L 58.5833,52.25L 38,60.1667L 17.4167,52.25L 17.4167,44.3333L 21.5333,45.9167L 38,52.25L 54.4667,45.9167L 58.5833,44.3333 Z M 58.5833,33.25L 58.5833,41.1667L 38,49.0833L 17.4167,41.1667L 17.4167,33.25L 21.5333,34.8333L 38,41.1667L 54.4666,34.8333L 58.5833,33.25 Z " });
            objTileList.Add(new ClassTiles { Title = "Tile 7", Color = "Red", Type = "Form", Icon = "F1 M 17,23L 31,23L 31,27L 34,27L 34,30L 37,30L 37,33L 39,33L 39,30L 42,30L 42,27L 45,27L 45,23L 59,23L 59,27L 56,27L 56,30L 53,30L 53,33L 50,33L 50,36L 47,36L 47,40L 50,40L 50,43L 53,43L 53,46L 56,46L 56,49L 59,49L 59,53L 45,53L 45,49L 42,49L 42,46L 39,46L 39,43L 37,43L 37,46L 34,46L 34,49L 31,49L 31,53L 17,53L 17,49L 20,49L 20,46L 23,46L 23,43L 26,43L 26,40L 29,40L 29,36L 26,36L 26,33L 23,33L 23,30L 20,30L 20,27L 17,27L 17,23 Z " });
            objTileList.Add(new ClassTiles { Title = "Tile 8", Color = "Green", Type = "Form", Icon = "F1 M 38,15.8334L 58.5833,23.75L 58.5833,30.0833L 38,38L 17.4167,30.0833L 17.4166,23.75L 38,15.8334 Z M 58.5833,44.3333L 58.5833,52.25L 38,60.1667L 17.4167,52.25L 17.4167,44.3333L 21.5333,45.9167L 38,52.25L 54.4667,45.9167L 58.5833,44.3333 Z M 58.5833,33.25L 58.5833,41.1667L 38,49.0833L 17.4167,41.1667L 17.4167,33.25L 21.5333,34.8333L 38,41.1667L 54.4666,34.8333L 58.5833,33.23 Z " });
            ItemsTiles.ItemsSource = objTileList;
            ItemsTiles.Width = ScreenWidth + 100;
        }

       
        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            var Sender = (MahApps.Metro.Controls.Tile)sender;
            SelectedTile = Sender.Title;
            //ShowMessageDialog(this, null);
            SetFlyoutIndex(SelectedTile);            
        }
        private void SetFlyoutIndex(string title)
        {
            if(title== WORD_DOCUMENT_GENERATOR_TILE)
            {
                this.ToggleFlyout(2);
            }
        }
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
                if (openFileDialog.FileName != null|| openFileDialog.FileName == string.Empty)
                {
                    LoadXml(openFileDialog.FileName);
                }
            }
        }
        private void LoadXml(string fileName)
        {
            xmlReader.LoadXmlFile(fileName);
            xmlReader.GetNodeValues();
        }
        private void ToggleFlyout(int index)
        {
            var flyout = this.Flyouts.Items[index] as Flyout;
            if (flyout == null)
            {
                return;
            }
            flyout.IsOpen = !flyout.IsOpen;
        }
        private async void ShowMessageDialog(object sender, RoutedEventArgs e)
        {
            MahApps.Metro.Controls.Dialogs.MessageDialogResult result = await this.ShowMessageAsync("Information!", "You Selected " + SelectedTile, MessageDialogStyle.Affirmative);
        }
    }    
}

