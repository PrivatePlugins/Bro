using Rocket.API;

namespace DM
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool Enabled = true;

        public bool ShowSuicideMessages ;
        public bool ShowHeadshotMessages ;
        public string DeathMessagesColor;

        public void LoadDefaults()
        {
            Enabled = true;
            ShowSuicideMessages = true;
            ShowHeadshotMessages = true;
            DeathMessagesColor = "Red";
        }
    }
}
