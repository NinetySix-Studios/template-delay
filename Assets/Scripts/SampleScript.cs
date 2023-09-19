using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;
using Valari.Utilities;

namespace NinetySix.Utilities
{
    public class SampleScript : MonoBehaviour
    {
        private Vector3 _newPositionUp = new Vector3(0, 5f, 0);
        private Vector3 _originalPosition = new Vector3(0, 0, 0);

        private void Start()
        {
            Delay.RunLater(this, 5f, ChangePositionUp);
        }

        private void ChangePositionUp()
        {
            Debug.Log("Moving Object Up!");
            transform.position = _newPositionUp;
        }
    }
}
