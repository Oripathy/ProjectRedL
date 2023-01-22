using System;
using UnityEngine;
using UnityEngine.UI;

namespace Presentation.MainMenu
{
    public class MainMenuView : View
    {
        [SerializeField] private Button _levelsButton;
        [SerializeField] private Button _unitsButton;
        [SerializeField] private Button _settingsButton;

        public event Action LevelsPanelRequested;
        public event Action UnitsPanelRequested;
        public event Action SettingsPanelRequested;

        private void Awake()
        {
            _levelsButton.onClick.AddListener(() => LevelsPanelRequested?.Invoke());
            _unitsButton.onClick.AddListener(() => UnitsPanelRequested?.Invoke());
            _settingsButton.onClick.AddListener(() => SettingsPanelRequested?.Invoke());
        }

        private void OnDestroy()
        {
            _levelsButton.onClick.RemoveAllListeners();
            _unitsButton.onClick.RemoveAllListeners();
            _settingsButton.onClick.RemoveAllListeners();
        }
    }
}