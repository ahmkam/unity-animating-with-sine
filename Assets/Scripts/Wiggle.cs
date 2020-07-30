using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomAnimation
{
    public class Wiggle : MonoBehaviour
    {
        [SerializeField] private List<RectTransform> rectTransforms;
        [SerializeField] private float frequency = 1f;
        [SerializeField] private float amplitude = 1f;
        private List<Vector3> startPositions;
        private List<Vector3> wiggleOffsets;

        void Start()
        {
            startPositions = new List<Vector3>();
            wiggleOffsets = new List<Vector3>();
            for (int i = 0; i < rectTransforms.Count; i++)
            {
                startPositions.Add(rectTransforms[i].anchoredPosition);
                wiggleOffsets.Add(Random.insideUnitCircle.normalized);
            }
        }

        void Update()
        {
            for (int i = 0; i < rectTransforms.Count; i++)
            {
                Vector3 anchoredPosition = rectTransforms[i].anchoredPosition;
                anchoredPosition = startPositions[i] + Mathf.Sin(Time.time * 2 * Mathf.PI * (1 / frequency)) * wiggleOffsets[i] * amplitude;
                rectTransforms[i].anchoredPosition = anchoredPosition;
            }
        }
    }

}
