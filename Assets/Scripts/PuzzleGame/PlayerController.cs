using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : NetworkBehaviour
{
    /*
        public GameObject SelectedPiece;
        public Camera _camera;
        private int OIL = 1;
        public bool isPause = false;
    
        private void Awake()
        {
            _camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        }
    
        void Update()
        {
            if (!isLocalPlayer) { return; }
            if (!isPause)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        RaycastHit2D hit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                        if (hit.transform != null && hit.transform.CompareTag("Puzzle"))
                        {
                            if (!hit.transform.GetComponent<piceseScript>().InRightPosition)
                            {
                                SelectedPiece = hit.transform.gameObject;
                                SelectedPiece.GetComponent<piceseScript>().Selected = true;
                                SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                                OIL++;
                            }
                        }
                    }
    
                    if (Input.GetMouseButtonUp(0))
                    {
                        if (SelectedPiece != null)
                        {
                            SelectedPiece.GetComponent<piceseScript>().Selected = false;
                            SelectedPiece = null;
                        }
                    }
    
                    if (SelectedPiece != null)
                    {
                        Vector3 MousePoint = _camera.ScreenToWorldPoint(Input.mousePosition);
                        MousePoint.z = 0; // Ensure the z position is 0 to keep it in the 2D plane
                        SelectedPiece.transform.position = MousePoint;
                    }
                }
            }*/


    public GameObject SelectedPiece;
    public Camera _camera;
    private int OIL = 1;
    public bool isPause = false;

    private void Awake()
    {

        _camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();

    }

    void Update()
    {
        MovePuzzle();
        
    }


    void MovePuzzle()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        if (!isPause)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.transform != null && hit.transform.CompareTag("Puzzle"))
                {
                    if (!hit.transform.GetComponent<piceseScript>().InRightPosition)
                    {
                        SelectedPiece = hit.transform.gameObject;
                        SelectedPiece.GetComponent<piceseScript>().Selected = true;
                        SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                        OIL++;
                    }
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                if (SelectedPiece != null)
                {
                    SelectedPiece.GetComponent<piceseScript>().Selected = false;
                    SelectedPiece = null;
                }
            }

            if (SelectedPiece != null)
            {
                Vector3 MousePoint = _camera.ScreenToWorldPoint(Input.mousePosition);
                MousePoint.z = 0; // Ensure the z position is 0 to keep it in the 2D plane
                SelectedPiece.transform.position = MousePoint;
            }
        }
    }
    
    
    [Command]
    void CmdApplyForce(Vector3 force)
    {

        MovePuzzle();
    }
}
