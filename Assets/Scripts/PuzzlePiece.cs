using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePiece : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    //[SerializeField] private AudioSource _source;
    //[SerializeField] private AudioClip _pickupClip, _dropClip;

    private bool _dragging, _placed;

    private Vector2 _offset, _originalPosition;

    private PuzzleSlot _slot;

    public void Init(PuzzleSlot slot)
    {
        _renderer.sprite = slot.Renderer.sprite;
        _slot = slot;
    }

    void Awake()
    {
        _originalPosition = transform.position;
    }

    void Update()
    {
        if (_placed) return;
        if (!_dragging) return;

        var mousePosition = GetMousePos();
        transform.position = mousePosition - _offset;
    }

    void OnMouseDown()
    {
        _dragging = true;
        //_source.PlayOneShot(_pickupClip);
        _offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, _slot.transform.position) < 3)
        {
            transform.position = _slot.transform.position;
            _placed = true;
            //_slot.Placed();
        }
        else
        {
            transform.position = _originalPosition;
            _dragging = false;
            //_source.PlayOneShot(_dropClip);
        }
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
