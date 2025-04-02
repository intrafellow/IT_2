namespace Animal.Models

{
    public interface ITreeClimber
    {
        bool IsOnTree { get; }

        void ClimbTree();

        void GetDownFromTree();
    }
}