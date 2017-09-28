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
using System.Xml.Serialization;

namespace Org.Zpf.XFeiCards.UI.Implement
{
    /// <summary>
    /// Option.xaml 的交互逻辑
    /// </summary>
    public partial class Option : Window
    {
        private GameOptions _gameOptions;
        public Option()
        {
            if (_gameOptions == null) {
                if (File.Exists("GameOptions.xml"))
                {
                    using (var content = File.OpenRead("GameOptions.xml"))
                    {
                        var serializable = new XmlSerializer(typeof(GameOptions));
                        _gameOptions = serializable.Deserialize(content) as GameOptions;
                    }
                }
                else {
                    _gameOptions = new GameOptions();
                }
            }
            DataContext = _gameOptions;
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            using (var stream=File.Open("GameOptions.xml",FileMode.Create)) {
                var serializer = new XmlSerializer(typeof(GameOptions));
                serializer.Serialize(stream,_gameOptions);
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            _gameOptions = null;
            this.Close();
        }

        private void DumbRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _gameOptions.ComputerSkill = ComputerSkillLevel.Domb;
        }

        private void GoodRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _gameOptions.ComputerSkill = ComputerSkillLevel.Good;
        }

        private void CheatsRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _gameOptions.ComputerSkill = ComputerSkillLevel.Cheats;
        }
    }
}
