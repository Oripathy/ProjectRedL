using Base;

namespace Presentation.MainMenu
{
    public class MainMenuPresenter : Presenter<MainMenuView>
    {
        public override void SetView(MainMenuView view)
        {
            base.SetView(view);
            View.LevelsPanelRequested += OnLevelsPanelRequested;
            View.UnitsPanelRequested += OnUnitsPanelRequested;
            View.SettingsPanelRequested += OnSettingsPanelRequested;
        }

        private void OnLevelsPanelRequested()
        {
            
        }

        private void OnUnitsPanelRequested()
        {
            
        }

        private void OnSettingsPanelRequested()
        {
            
        }
    }
}