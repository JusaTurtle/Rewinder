using System.Collections.Generic;
using UnityEngine;

public interface Recordable
{
    void StartRecord();
    void PauseRecord();
    void Record();
    Vector2 GetPositions();
    Quaternion GetRotation();
    bool IsRecording { get; }
}
