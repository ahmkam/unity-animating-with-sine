using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomAnimation
{
    public class Basic : MonoBehaviour
    {
        [SerializeField] private RectTransform rectTransform;
        [SerializeField] private float frequency = 1f;
        [SerializeField] private float amplitude = 1f;
        [SerializeField] private MovementType movementType;

        void Start()
        {

        }

        void Update()
        {
            Vector3 anchoredPosition = rectTransform.anchoredPosition;
            float movementValue = Mathf.Sin((Time.time * 2 * Mathf.PI) * (1 / frequency)) * amplitude;
            switch (movementType)
            {
                case MovementType.Vertical:
                    anchoredPosition.y = movementValue;
                    break;

                case MovementType.Horizontal:
                    anchoredPosition.x = movementValue;
                    break;

                case MovementType.Both:
                    anchoredPosition.x = movementValue;
                    anchoredPosition.y = movementValue;
                    break;

                default:
                    break;
            }
            rectTransform.anchoredPosition = anchoredPosition;
        }
    }

    [System.Serializable]
    public enum MovementType : byte
    {
        None = 0,
        Vertical = 1,
        Horizontal = 2,
        Both = 3
    }
}
