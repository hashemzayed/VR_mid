using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;


public class On_Off : MonoBehaviour
{
    public Toggle movementToggle;
    public TeleportationProvider teleportationProvider;
    public ActionBasedContinuousMoveProvider dynamicMoveProvider;
    public XRRayInteractor teleportInteractor; // The teleportation interactor object

    void Start()
    {
        if (movementToggle != null)
            movementToggle.onValueChanged.AddListener(ToggleMovementMode);
    }

    void ToggleMovementMode(bool isTeleport)
    {
        if (teleportationProvider != null)
            teleportationProvider.enabled = isTeleport;

        if (dynamicMoveProvider != null)
            dynamicMoveProvider.enabled = !isTeleport;

        if (teleportInteractor != null)
            teleportInteractor.gameObject.SetActive(isTeleport);
    }
}