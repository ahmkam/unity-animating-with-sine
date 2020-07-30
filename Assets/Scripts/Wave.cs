using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomAnimation
{
    public class Wave : MonoBehaviour
    {
        [SerializeField] private List<RectTransform> rectTransforms;
        [SerializeField] private float frequency = 1f;
        [SerializeField] private float amplitude = 1f;
        [Range(0.1f, 0.5f)]
        [SerializeField] private float offset = 0.2f;

        void Start()
        {
        }

        void Update()
        {
            for (int i = 0; i < rectTransforms.Count; i++)
            {
                Vector3 anchoredPosition = rectTransforms[i].anchoredPosition;
                anchoredPosition.y = Mathf.Sin((Time.time + (i * offset)) * 2 * Mathf.PI * (1 / frequency)) * amplitude;
                rectTransforms[i].anchoredPosition = anchoredPosition;
            }
        }
    }

}
