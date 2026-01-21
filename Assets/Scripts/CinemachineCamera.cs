using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.InputSystem.Processors;


public class CinemachineCamera : MonoBehaviour
{
    private CinemachineCamera cinemachineCamera;

    private void Awake()
    {
        //Camera.main.gameObject.TryGetComponent<CinemachineBrain>(out var brain);
        //if (brain = null)
        //{
        //    brain = Camera.main.gameObject.AddComponent<CinemachineBrain>();
        //}
    // my player camera will always have a component, reactivate this code if i make any other cameras in my scene.


        cinemachineCamera = gameObject.AddComponent<CinemachineCamera>();
    }


}
