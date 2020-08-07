using System.Collections;
using UnityEngine;

public class Rewinder : MonoBehaviour, Rewindable
{
    [SerializeField] private float delay;
    private float timer;
    private Recordable recorder;
    private bool isRewindng;
    private Vector2 targetPos;
    private Quaternion targetRot;
    private Vector2 startPos;
    private Quaternion startRot;
    private Rigidbody2D rb;

    public bool IsRewindng { get => isRewindng; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        recorder = GetComponent<Recordable>();
        timer = delay;
    }

    private void Update()
    {
        if (timer <= 0f)
        {
            if (!recorder.IsRecording)
            {
                rb.simulated = true;
                isRewindng = false;
                recorder.StartRecord();
            }
            return;
        }

        if (isRewindng)
        {
            transform.position = Vector2.Lerp(startPos, targetPos, 1f - (timer / delay));
            transform.rotation = Quaternion.Lerp(startRot, targetRot, 1f - (timer / delay));
        }

        timer -= Time.deltaTime;
    }

    public void Rewind()
    {
        rb.simulated = false;
        targetPos = recorder.GetPositions();
        targetRot = recorder.GetRotation();
        startPos = transform.position;
        startRot = transform.rotation;
        isRewindng = true;
        recorder.PauseRecord();
        timer = delay;
    }

    public float GetFillPercent()
    {
        return timer / delay;
    }
}