using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Zpf.XFeiCards.UI.Implement
{
    [Serializable]
    sealed class GameOptions:INotifyPropertyChanged
    {
        private ObservableCollection<string> _playerNames = new ObservableCollection<string>();
        private bool _isCheckBox = true;
        private int _numberOfPlayers = 3;
        private ComputerSkillLevel _skill = ComputerSkillLevel.Domb;
        public GameOptions() {
            SelectedPlayers = new List<string>();
        }
        public ObservableCollection<string> PlayerNames{
            get{
                return _playerNames;
            }
            set{
                _playerNames=value;
                OnpropertyChanged(nameof(PlayerNames));
            }
        }
        public void AddPlayer(string playName) {
            if (_playerNames.Contains(playName))
                return;
            else
                _playerNames.Add(playName);
            OnpropertyChanged(nameof(PlayerNames));
        }
        public List<string> SelectedPlayers { set; get; }
        public bool IsCheckBox {
            get { return _isCheckBox; }
            set { _isCheckBox = value;
                OnpropertyChanged(nameof(IsCheckBox));
            }
           
        }
        public int NumerOfPlayers {
            get { return _numberOfPlayers; }
            set { _numberOfPlayers = value;
                OnpropertyChanged(nameof(NumerOfPlayers));
            }
        }
        public int MinuteBeforeLoss { set; get; }
        public ComputerSkillLevel ComputerSkill {
            get { return _skill; }
            set { _skill = value;
                OnpropertyChanged(nameof(ComputerSkill));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnpropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
    [Serializable]
    public enum ComputerSkillLevel{
        Domb,
        Good,
       Cheats
    }
}
