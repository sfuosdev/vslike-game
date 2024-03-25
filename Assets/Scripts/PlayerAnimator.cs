using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _am;
    private PlayerMovement _pm;
    private SpriteRenderer _sr;
    void Start()
    {
        _pm = GetComponent<PlayerMovement>();
        _am = GetComponentInChildren<Animator>();
        _sr = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {
        if (_pm.moveDir.x != 0 || _pm.moveDir.y != 0)
        {
            _am.SetBool("Move", true);
            if (_pm.lastHorizontalVector < 0 ? _sr.flipX = true : _sr.flipX = false) ; // Sprite Direct Check
        }
        else
            _am.SetBool("Move", false);
    }
}
