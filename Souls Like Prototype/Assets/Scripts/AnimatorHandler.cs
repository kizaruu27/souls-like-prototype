using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulsLike
{
    public class AnimatorHandler : MonoBehaviour
    {
        public Animator anim;
        int vertical;
        int horizontal;
        public bool canRotate;

        public void Initialzed()
        {
            anim = GetComponent<Animator>();
            vertical = Animator.StringToHash("Vertical");
            horizontal = Animator.StringToHash("Horizontal");
        }

        public void UpdateAnimatorValues(float verticalMovement, float horizontalMovement)
        {
            #region Vertical

            float v = 0;

            if (verticalMovement > 0 && verticalMovement < .55f)
            {
                v = .5f;
            }
            else if (verticalMovement > .55f)
            {
                v = 1;
            }
            else if (verticalMovement < 0 && verticalMovement > -.55f)
            {
                v = -.5f;
            }
            else if (verticalMovement < -.55f)
            {
                v = -1;
            }
            else
            {
                v = 0;
            }

            #endregion

            #region Horizontal

            float h = 0;

            if (horizontalMovement > 0 && horizontalMovement < .55f)
            {
                h = .5f;
            }
            else if (horizontalMovement > .55f)
            {
                h = 1;
            }
            else if (horizontalMovement < 0 && horizontalMovement > -.55f)
            {
                h = -.5f;
            }
            else if (horizontalMovement < -.55f)
            {
                h = -1;
            }
            else
            {
                h = 0;
            }

            #endregion

            anim.SetFloat(vertical, v, .1f, Time.deltaTime);
            anim.SetFloat(horizontal, h, .1f, Time.deltaTime);

        }

        public void CanRotate()
        {
            canRotate = true;
        }

        public void StopRotation()
        {
            canRotate = false;
        }
    }
}

