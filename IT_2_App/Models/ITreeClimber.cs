namespace IT_2_App.Models;

public interface ITreeClimber
{
    bool IsOnTree { get; }
    void ClimbTree();
    void GetDownFromTree();
} 