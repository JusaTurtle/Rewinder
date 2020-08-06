using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour, Recordable
{
    [SerializeField] private float interval;
    private Stack<Vector2> pos;
    private Stack<Quaternion> rot;
    private bool isRecording;
    private float timer;

    private void Awake()
    {
        pos = new Stack<Vector2>();
        rot = new Stack<Quaternion>();
    }

    private void Start()
    {
        Record();
    }

    private void Update() {
        if(!isRecording) return;
        if(timer <= 0f)
        {
            Record();
            timer = interval;
        }
        timer -= Time.deltaTime;
        Debug.Log(pos.Peek(), this);
    }

    public Vector2 GetPositions()
    {
        return pos.Pop();
    }

    public Quaternion GetRotation()
    {
        return rot.Pop();
    }

    public void Record()
    {
        pos.Push(transform.position);
        rot.Push(transform.rotation);
    }

    public void StartRecord()
    {
        timer = 0;
        isRecording = true;
    }

    public void PauseRecord()
    {
        timer = interval;
        isRecording = false;
    }

    public bool IsRecording => isRecording;
}