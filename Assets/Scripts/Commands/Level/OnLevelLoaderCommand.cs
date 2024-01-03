using UnityEngine;

public class OnLevelLoaderCommand
{
    private Transform _levelHolder;

    public OnLevelLoaderCommand(Transform levelHolder)
    {
        _levelHolder = levelHolder;
    }

    public void Execute(byte levelIndex)
    {
        Object.Instantiate(Resources.Load<GameObject>($"Prefabs/Levels/level {levelIndex}"), _levelHolder);
    }
}
