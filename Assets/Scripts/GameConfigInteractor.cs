using Assets.Scripts.AB;

namespace Assets.Scripts
{
    public class GameConfigInteractor : BaseConfigInteractor<GameConfig>
    {
        public GameConfigInteractor(ABTestInteractor testInteractor) : base(testInteractor)
        {
        }
    }
}